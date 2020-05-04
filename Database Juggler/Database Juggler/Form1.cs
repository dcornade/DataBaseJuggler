using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database_Juggler
{
    public partial class Form1 : Form
    {
        OleDbConnection cn;
        public int sel,se,de,take1,take2,take3,take4,take5;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel4.Location = new Point(2, 36);
            panel6.Location = new Point(842, 36);
            panel7.Location = new Point(842, 36);
            panel4.Size = new Size(832, 471);
            panel6.Size = new Size(832, 471);
            panel7.Size = new Size(832, 471);
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            button3.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Enabled = true;
            sel = 1;
            panel6.BringToFront();
            textBox1.Select();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sel == 1)
            {
                panel6.Left -= 40;
                if (panel6.Left <= 2)
                {
                    timer1.Stop();
                }
            }
            else
            {
                panel7.Left -= 40;
                if (panel7.Left <= 2)
                {
                    timer1.Stop();
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Interval = 1;
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sel == 1)
            {
                panel6.Left += 40;
                if (panel6.Left >= 842)
                {
                    timer2.Stop();
                }
            }
            else
            {
                panel7.Left += 40;
                if (panel7.Left >= 842)
                {
                    timer2.Stop();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel7.BringToFront();
            sel = 2;
            timer1.Interval = 1;
            timer1.Enabled = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Interval = 1;
            timer2.Start();
        }
        public void pron()
        {
            label19.ForeColor = Color.Red;
            groupBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            button3.Enabled = false;
        }
        public void proff()
        {
            groupBox2.BackColor = Color.Gainsboro;
            textBox3.BackColor = Color.Gainsboro;
            textBox4.BackColor = Color.Gainsboro;
            textBox5.BackColor = Color.Gainsboro;
            textBox6.BackColor = Color.Gainsboro;
            textBox7.BackColor = Color.Gainsboro;
            textBox8.BackColor = Color.Gainsboro;
            textBox9.BackColor = Color.Gainsboro;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            button3.Enabled = false;
            textBox3.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                pron();
            }
            else
            {
                proff();
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                if (int.Parse(textBox8.Text) < 100)
                {
                    textBox9.Text = "Fail";
                }
                else if(int.Parse(textBox8.Text) < 200)
                {
                    textBox9.Text = "Pass";
                }
                else if(int.Parse(textBox8.Text) < 300)
                {
                    textBox9.Text = "C";
                }
                else if(int.Parse(textBox8.Text) < 400)
                {
                    textBox9.Text = "B";
                }
                else
                {
                    textBox9.Text = "A";
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                pron();
            }
            else
            {
                proff();
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                int len = textBox4.Text.Length;
                char kin = textBox4.Text[len - 1];
                if (!char.IsDigit(kin))
                {
                    textBox4.Text = textBox4.Text.Substring(0, len - 1);
                    textBox4.SelectionStart = textBox4.Text.Length;
                    textBox4.SelectionLength = 0;
                    label19.Text = "Whoa there let's keep it Numbers";
                }
                else if (char.IsDigit(kin))
                {
                    label19.Text = "";
                    take2 = Convert.ToInt32(textBox4.Text);
                    if (take2 > 99)
                    {
                        textBox4.Text = Convert.ToString(99);
                        textBox4.SelectionStart = textBox4.Text.Length;
                        textBox4.SelectionLength = 0;
                        label19.Text = "Let's keep it under 100";
                    }
                    else
                    {
                        textBox8.Text = Convert.ToString(take1 + take2 + take3 + take4 + take5);
                    }
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                int len = textBox6.Text.Length;
                char kin = textBox6.Text[len - 1];
                if (!char.IsDigit(kin))
                {
                    textBox6.Text = textBox6.Text.Substring(0, len - 1);
                    textBox6.SelectionStart = textBox6.Text.Length;
                    textBox6.SelectionLength = 0;
                    label19.Text = "Whoa there let's keep it Numbers";
                }
                else if (char.IsDigit(kin))
                {
                    label19.Text = "";
                    tex();
                    take4 = Convert.ToInt32(textBox6.Text);
                    if (take4 > 99)
                    {
                        textBox6.Text = Convert.ToString(99);
                        textBox6.SelectionStart = textBox5.Text.Length;
                        textBox6.SelectionLength = 0;
                        label19.Text = "Let's keep it under 100";
                    }
                    else
                    {
                        textBox8.Text = Convert.ToString(take1 + take2 + take3 + take4 + take5);
                    }
                }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                int len = textBox5.Text.Length;
                char kin = textBox5.Text[len - 1];
                if (!char.IsDigit(kin))
                {
                    textBox5.Text = textBox5.Text.Substring(0, len - 1);
                    textBox5.SelectionStart = textBox5.Text.Length;
                    textBox5.SelectionLength = 0;
                    label19.Text = "Whoa there let's keep it Numbers";
                }
                else if (char.IsDigit(kin))
                {
                    label19.Text = "";
                    take3 = Convert.ToInt32(textBox5.Text);
                    tex();
                    if (take3 > 99)
                    {
                        textBox5.Text = Convert.ToString(99);
                        textBox5.SelectionStart = textBox5.Text.Length;
                        textBox5.SelectionLength = 0;
                        label19.Text = "Let's keep it under 100";
                    }
                    else
                    {
                        textBox8.Text = Convert.ToString(take1 + take2 + take3 + take4 + take5);
                    }
                }
            }
        }
        public void tex()
        {
            if (textBox3.Text == "")
            {
                take1 = 0;
            }
            else
            {
                take1 = Convert.ToInt32(textBox3.Text);
            }
            if (textBox5.Text == "")
            {
                take3 = 0;
            }
            else
            {
                take3 = Convert.ToInt32(textBox5.Text);
            }
            if (textBox4.Text == "")
            {
                take2 = 0;
            }
            else
            {
                take2 = Convert.ToInt32(textBox4.Text);
            }
            if (textBox6.Text == "")
            {
                take4 = 0;
            }
            else
            {
                take4 = Convert.ToInt32(textBox6.Text);
            }
            if (textBox7.Text == "")
            {
                take5 = 0;
            }
            else
            {
                take5 = Convert.ToInt32(textBox7.Text);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int len = textBox3.Text.Length;
                char kin = textBox3.Text[len - 1];
                if (!char.IsDigit(kin))
                {
                    textBox3.Text = textBox3.Text.Substring(0, len - 1);
                    textBox3.SelectionStart = textBox3.Text.Length;
                    textBox3.SelectionLength = 0;
                    label19.Text = "Whoa there let's keep it Numbers";
                }
                else if (char.IsDigit(kin))
                {
                    label19.Text = "";
                    tex();
                    take1 = Convert.ToInt32(textBox3.Text);
                    if (take1 > 99)
                    {
                        textBox3.Text = Convert.ToString(99);
                        textBox3.SelectionStart = textBox3.Text.Length;
                        textBox3.SelectionLength = 0;
                        label19.Text = "Let's keep it under 100";
                    }
                    else
                    {
                        textBox8.Text = Convert.ToString(take1 + take2 + take3 + take4 + take5);
                    }
                }
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                button3.Enabled = true;
                button3.BackColor = Color.FromArgb(104, 144, 255);
            }
            if (textBox7.Text != "")
            {
                int len = textBox7.Text.Length;
                char kin = textBox7.Text[len - 1];
                if (!char.IsDigit(kin))
                {
                    textBox7.Text = textBox7.Text.Substring(0, len - 1);
                    textBox7.SelectionStart = textBox7.Text.Length;
                    textBox7.SelectionLength = 0;
                    label19.Text = "Whoa there let's keep it Numbers";
                }
                else if (char.IsDigit(kin))
                {
                    label19.Text = "";
                    tex();
                    take5 = Convert.ToInt32(textBox7.Text);
                    if (take5 > 99)
                    {
                        textBox7.Text = Convert.ToString(99);
                        textBox7.SelectionStart = textBox7.Text.Length;
                        textBox7.SelectionLength = 0;
                        label19.Text = "Let's keep it under 100";
                    }
                    else
                    {
                        textBox8.Text = Convert.ToString(take1 + take2 + take3 + take4 + take5);
                    }
                }
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox5.Select();
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Select();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Select();
            }
        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Select();
            }
        }
        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Select();
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox7.Select();
            }
        }
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender,e);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            con();
            cn.Open();
            string sql = "insert into tab values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sql, cn);
            cmd.ExecuteNonQuery();
            label19.ForeColor = Color.Green;
            label19.Text = "Record Inserted Succesfully";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox1.Select();
        }
        public void con()
        {
            cn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = student.mdb");
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox10_MouseDown(object sender, MouseEventArgs e)
        {
            textBox11.Text = "";
            textBox12.Text = "";
            se = 2;
        }
        private void textBox12_MouseDown(object sender, MouseEventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            se = 3;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string ui,mi;
            con();
            cn.Open();
            if (se == 1) { ui = "Roll";mi = textBox11.Text;de = 1; }
            else if(se == 2){ ui = "sname"; mi = textBox10.Text;de = 2; }
            else { ui = "grade"; mi = textBox11.Text;de = 3; }
            string sql = "select * from tab where " + ui + " ='" + mi + "'";
            OleDbDataAdapter c = new OleDbDataAdapter(sql, cn);
            DataSet ws = new DataSet();
            c.Fill(ws);
            if (ws.Tables[0].Rows.Count != 0)
            {
                textBox11.Text = ws.Tables[0].Rows[0].ItemArray[0].ToString();
                textBox10.Text = ws.Tables[0].Rows[0].ItemArray[1].ToString();
                textBox12.Text = ws.Tables[0].Rows[0].ItemArray[8].ToString();
                textBox19.Text = ws.Tables[0].Rows[0].ItemArray[2].ToString();
                textBox18.Text = ws.Tables[0].Rows[0].ItemArray[3].ToString();
                textBox17.Text = ws.Tables[0].Rows[0].ItemArray[4].ToString();
                textBox16.Text = ws.Tables[0].Rows[0].ItemArray[5].ToString();
                textBox15.Text = ws.Tables[0].Rows[0].ItemArray[6].ToString();
                textBox14.Text = ws.Tables[0].Rows[0].ItemArray[7].ToString();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string ui, mi;
            con();
            cn.Open();
            if (de == 1) { ui = "Roll"; mi = textBox11.Text;}
            else if (de == 2) { ui = "sname"; mi = textBox10.Text; }
            else { ui = "grade"; mi = textBox11.Text; }
            string sql = "delete from tab where " + ui + " ='" + mi + "'";
            OleDbCommand cmd = new OleDbCommand(sql, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
        }
        private void textBox11_MouseDown(object sender, MouseEventArgs e)
        {
            textBox10.Text = "";
            textBox12.Text = "";
            se = 1;
        }
    }
}
