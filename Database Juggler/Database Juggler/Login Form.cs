using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Animation;

namespace Database_Juggler
{
    public partial class Login_Form : Form
    {

        OleDbConnection cn;
        public int atempts = 3;

        public Login_Form()
        {
            InitializeComponent();
            InitializeAnimation();
        }
        public void con()
        {
            cn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = student.mdb");
        }
        private void Login_Form_Load(object sender, EventArgs e)
        {
            int sx = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width) / 2;
            int sy = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height) / 2;
            int fx = Convert.ToInt32(this.Height) / 2;
            int fy = Convert.ToInt32(this.Width) / 2;
            this.Location = new Point(sx - fx + 30, sy - fy - 100);
            panel2.Location = new Point(345, 234);
            panel3.Location = new Point(345, 234);
            panel7.Location = new Point(0, 542);
            label1.Select();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(204, 0, 0);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = panel1.BackColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con();
            cn.Open();
            string sql = "select * from log where us = '" + owlimginput1.Textin + "' and pass='" + owlimginput2.Textin + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                owlimginput2.Textin = "";
                owlimginput2.Focus();
                owlimginput1.Textin = "";
                owlimginput1.Focus();
                atempts--;
                label4.Text = "Username or Password is Incorrect - " + atempts + " Attempts remaining!";
                if (atempts == 0)
                {
                    label4.Text = "Maximum Attempts reached Application will be closed!";
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(1000);
                    }
                    Application.Exit();
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Animation.Move(0, 234, panel2, 25);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animation.Move(345, 234, panel2, 25);
        }

        private void owlimginput3_Textin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con();
                cn.Open();
                string sql = "select * from log where us = '" + owlimginput3.Textin + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    label5.Text = "";
                    owlimginput4.Textin = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    owlimginput5.Enabled = true;
                    owlimginput5.Focus();
                }
                else
                {
                    label5.Text = "User not Found!";
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (owlimginput3.Textin == "" || owlimginput3.Textin == "Enter Your Username And Press Enter..." || owlimginput5.Textin == "" || owlimginput5.Textin == "Your Answer...")
            {
                label5.Text = "Please Fill Appropriate Fields";
            }
            else if(owlimginput5.Textin == "")
            {
                label6.Text = "Please Fill Appropriate fields";
            }
            else 
            {
                con();
                cn.Open();
                string sql = "select * from log where sq=\"" + owlimginput4.Textin + "\" and sa=\"" + owlimginput5.Textin + "\"";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    label11.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    Animation.Move(0, 234, panel3, 25);
                }
                else
                {
                    label6.Text = "Answer doesn't Match";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(owlimginput6.Textin == "" || owlimginput6.Textin == "New Password..." || owlimginput7.Textin == "" || owlimginput7.Textin == "Confirm Password...")
            {
                label12.Text = "Please Fill Appropriate Fields";
                owlimginput6.Focus();
                owlimginput6.IsError = true;
            }
            else if(owlimginput6.Textin != owlimginput7.Textin)
            {
                label12.Text = "Passwords Doesn't Match!";
                owlimginput7.Focus();
                owlimginput7.IsError = true;
            }
            else
            {
                con();
                cn.Open();
                string sql = "Update log set pass=\"" + owlimginput6.Textin + "\" where us=\"" + label11.Text + "\"";
                OleDbCommand cmd = new OleDbCommand(sql, cn);
                cmd.ExecuteNonQuery();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Animation.Move(0, 50, panel7, 25);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            Animation.Move(0, 542, panel7, 25);
        }

        private void owlimginput8_Textin_Changed(object sender, EventArgs e)
        {
            con();
            cn.Open();
            string sql = "select * from log where us = '" + owlimginput8.Textin + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                label21.Text = "User Already Exist";
                owlimginput8.IsError = true;
                owlimginput9.Enabled = false;
                owlimginput9.Textin = "";
                owlimginput10.Enabled = false;
                owlimginput10.Textin = "";
            }
            else
            {
                owlimginput8.IsError = false;
                label21.Text = "";
                owlimginput9.Enabled = true;
                owlimginput9.Textin = "Password...";
                owlimginput10.Enabled = true;
                owlimginput10.Textin = "New Password...";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (owlimginput8.Textin == "" || owlimginput8.Textin == "" || owlimginput9.Textin == "" || owlimginput9.Textin == "Password..." || owlimginput10.Textin == "" || owlimginput10.Textin == "Confirm Password...")
            {
                label21.Text = "Please Fill Appropriate Fields!";
            }
            else if(owlimginput9.Textin != owlimginput10.Textin)
            {
                label22.Text = "Passwords doesn't Match";
            }
            else
            {
                con();
                cn.Open();
                string sql = "insert into log values (\"" + owlimginput8.Textin + "\", \"" + owlimginput9.Textin + "\" , \"\");";
                OleDbCommand cmd = new OleDbCommand(sql, cn);
                cmd.ExecuteNonQuery();
                Animation.Move(0, 542, panel7, 25);
            }
        }
    }
}
