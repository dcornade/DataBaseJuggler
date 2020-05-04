using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Drawing.Drawing2D;

namespace Animation
{
    public class Animation
    {
        public System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public Control c;
        public int L, T, t, trns1, trns2, chnge1 = 0, chnge2 = 0, r1, r2,x,y,intrvl , intrvl1, intrvl2,tr1,tr2 ;
        public Animation()
        {
            timer1.Tick += new EventHandler(onchange);
        }

        public void Move(int X, int Y, Control Movecontrol, int time)
        {
            L = 0; T = 0; t = 0; trns1 = 0; trns2 = 0; chnge1 = 0; chnge2 = 0; r1 = 0; r2 = 0; x = 0; y = 0; intrvl = 0; intrvl1 = 0; intrvl2 = 0; tr1 = 0; tr2 = 0;
            c = Movecontrol;
            Movecontrol.BringToFront();
            L = Movecontrol.Left;
            T = Movecontrol.Top;
            t = time;
            x = X;
            y = Y;
            trns1 = L - X;
            trns2 = T - Y;
            r1 = trns1 % t;
            if (trns1 != r1)
            {
                chnge1 = (trns1 - r1) / t;
                tr1 = chnge1 % t;
            }
            r2 = trns2 % t;
            if (trns2 != r2)
            {
                chnge2 = (trns2 - r2) / t;
                tr2 = chnge2 % t;
            }
            timer1.Interval = 1;
            timer1.Enabled = true;
        }

        void onchange(Object sender,EventArgs e)
        {
            if(chnge1 == 0 && chnge2 == 0)
            {
                c.Left = x;
                c.Top = y;
                timer1.Stop();
            }
            if (trns1 != 0)
            {
                if (trns1 > 0)
                {
                    if (c.Left > x + tr1)
                    {
                        c.Left -= chnge1;
                    }
                    else
                    {
                        c.Left = x;
                        if (chnge2 != 0)
                        {
                            c.Left -= tr1;
                            timer1.Stop();
                        }
                    }
                }
                else
                {
                    if (c.Left < x - tr1)
                    {
                        c.Left -= chnge1;
                    }
                    else
                    {
                        c.Left = x;
                        if (chnge2 != 0)
                        {
                            c.Left -= tr1;
                            timer1.Stop();
                        }
                    }
                }
            }
            if (trns2 != 0)
            {
                if (trns2 > 0)
                {
                    if (c.Top > y + tr2)
                    {
                        c.Top -= chnge2;
                    }
                    else
                    {
                        c.Top = y;
                        if (chnge2 != 0)
                        {
                            c.Top -= tr2;
                            timer1.Stop();
                        }
                    }
                }
                else
                {
                    if (c.Top < y - tr2)
                    {
                        c.Top -= chnge2;
                    }
                    else
                    {
                        c.Top = y;
                        if (chnge2 != 0)
                        {
                            c.Top -= tr2;
                            timer1.Stop();
                        }
                    }
                }
            }
        }
    }
}
