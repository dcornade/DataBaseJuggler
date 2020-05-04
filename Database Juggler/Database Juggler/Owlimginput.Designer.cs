namespace Database_Juggler
{
    partial class Owlimginput
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Owl_icon = new System.Windows.Forms.PictureBox();
            this.textin = new System.Windows.Forms.TextBox();
            this.Undeline = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Owl_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Owl_icon
            // 
            this.Owl_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Owl_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.Owl_icon.Location = new System.Drawing.Point(0, 0);
            this.Owl_icon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Owl_icon.Name = "Owl_icon";
            this.Owl_icon.Size = new System.Drawing.Size(39, 35);
            this.Owl_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Owl_icon.TabIndex = 0;
            this.Owl_icon.TabStop = false;
            // 
            // textin
            // 
            this.textin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.textin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textin.ForeColor = System.Drawing.Color.White;
            this.textin.Location = new System.Drawing.Point(45, 10);
            this.textin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textin.Name = "textin";
            this.textin.Size = new System.Drawing.Size(236, 14);
            this.textin.TabIndex = 1;
            this.textin.TextChanged += new System.EventHandler(this.textin_TextChanged);
            this.textin.Enter += new System.EventHandler(this.textin_Enter);
            this.textin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textin_KeyDown);
            this.textin.Leave += new System.EventHandler(this.textin_Leave);
            // 
            // Undeline
            // 
            this.Undeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.Undeline.Location = new System.Drawing.Point(45, 36);
            this.Undeline.Name = "Undeline";
            this.Undeline.Size = new System.Drawing.Size(0, 2);
            this.Undeline.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Owlimginput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.Undeline);
            this.Controls.Add(this.textin);
            this.Controls.Add(this.Owl_icon);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Owlimginput";
            this.Size = new System.Drawing.Size(285, 38);
            this.Load += new System.EventHandler(this.Owlimginput_Load);
            this.Click += new System.EventHandler(this.Owlimginput_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Owl_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Owl_icon;
        private System.Windows.Forms.TextBox textin;
        private System.Windows.Forms.Panel Undeline;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
