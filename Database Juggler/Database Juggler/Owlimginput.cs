using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Database_Juggler
{
    public partial class Owlimginput : UserControl
    {
        bool pass = false,tin = true, pblm;
        public string s;
        int pos;
        public Owlimginput()
        {
            InitializeComponent();
        }

        public event KeyEventHandler Textin_KeyDown;

        public event EventHandler Textin_Changed;

        protected virtual void OnTextin_Changed(EventArgs e)
        {
            Textin_Changed?.Invoke(this, e);
        }

        protected virtual void OnTextin_KeyDown(KeyEventArgs e)
        {
            Textin_KeyDown?.Invoke(this, e);
        }

        private void Owlimginput_Load(object sender, EventArgs e)
        {
            
        }

        private void textin_KeyDown(object sender, KeyEventArgs e)
        {
            OnTextin_KeyDown(e);
        }

        private void Owlimginput_Click(object sender, EventArgs e)
        {
            textin.Focus();
        }

        private void textin_Enter(object sender, EventArgs e)
        {
            timer2.Stop();
            if (tin == true)
            {
                s = textin.Text;
                tin = false;
            }
            if (s == textin.Text)
            {
                textin.Text = "";
            }
            if(pass == true)
            {
                textin.UseSystemPasswordChar = true;
            }
            timer1.Interval = 1;
            timer1.Start();
            textin.Font = new Font(textin.Font.Name, 12);
        }

        private void textin_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Interval = 1;
            timer2.Start();
            if (textin.Text == "")
            {
                textin.UseSystemPasswordChar = false;
                textin.Text = s;
            }
            textin.Font = new Font(textin.Font.Name, 9);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Owl_icon.Top != 8)
            {
                textin.Top += 1;
                Owl_icon.Top += 1;
            }
            if (Undeline.Width <= pos)
            {
                Undeline.Size = new Size(Undeline.Width + 10, 2);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Owl_icon.Top != 0)
            {
                textin.Top -= 1;
                Owl_icon.Top -= 1;
            }
            if (Undeline.Width != 0)
            {
                Undeline.Size = new Size(Undeline.Width - 10, 2);
            }
            else
            {
                timer2.Stop();
            }
        }

        [Browsable(true)]
        [Category("OwlControl")]
        [Description("Set's the text in Owlcontrol")]
        [DisplayName("Textin")]
        public string Textin
        {
            get
            {
                return textin.Text;
            }
            set
            {
                textin.Text = value;
            }
        }

        [Browsable(true)]
        [Category("OwlControl")]
        [Description("Set's the Icon in Owlcontrol")]
        [DisplayName("Icon")]
        public string I
        {
            get
            {
                return Owl_icon.ImageLocation;
            }
            set
            {
                Owl_icon.ImageLocation = value;
            }
        }

        private void textin_TextChanged(object sender, EventArgs e)
        {
            OnTextin_Changed(e);
        }

        [Browsable(true)]
        [Category("OwlControl")]
        [Description("Set's Password Characteristic of text")]
        [DisplayName("Use Password")]
        public bool Ispassword
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
        }

        [Browsable(true)]
        [Category("OwlControl")]
        [Description("Set's if Icon is Needed or not")]
        [DisplayName("Use Icon")]
        public bool isicon
        {
            get
            {
                return Owl_icon.Visible;
            }
            set
            {
                Owl_icon.Visible = value;
                if (Owl_icon.Visible == true)
                {
                    textin.Left = 45;
                    pos = 240;
                    Undeline.Left = 45;
                }
                else
                {
                    textin.Left = 10;
                    pos = 285;
                    Undeline.Left = 0;
                }
            }
        }

        [Browsable(true)]
        [Category("OwlControl")]
        [Description("Set's Underline Red")]
        [DisplayName("Error")]
        public bool IsError
        {
            get
            {
                return pblm;
            }
            set
            {
                pblm = value;
                if(pblm == true)
                {
                    Undeline.BackColor = Color.FromArgb(204, 0, 0);
                }
                else
                {
                    Undeline.BackColor = Color.FromArgb(104, 144, 255);
                }
            }
        }
    }
    
}
