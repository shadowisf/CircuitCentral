namespace e_commerce_management_system
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label4 = new Label();
            l_emailBOX = new TextBox();
            label2 = new Label();
            l_registerBUTTON = new LinkLabel();
            label3 = new Label();
            l_loginBUTTON = new Button();
            l_passwordBOX = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 800);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(206, 667);
            label4.Name = "label4";
            label4.Size = new Size(682, 36);
            label4.TabIndex = 7;
            label4.Text = "Not a member? Click     ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_emailBOX
            // 
            l_emailBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_emailBOX.Location = new Point(426, 295);
            l_emailBOX.Name = "l_emailBOX";
            l_emailBOX.Size = new Size(234, 22);
            l_emailBOX.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(426, 274);
            label2.Name = "label2";
            label2.Size = new Size(138, 18);
            label2.TabIndex = 2;
            label2.Text = "E-mail Address";
            // 
            // l_registerBUTTON
            // 
            l_registerBUTTON.AutoSize = true;
            l_registerBUTTON.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_registerBUTTON.LinkColor = Color.MidnightBlue;
            l_registerBUTTON.Location = new Point(603, 678);
            l_registerBUTTON.Name = "l_registerBUTTON";
            l_registerBUTTON.Size = new Size(36, 14);
            l_registerBUTTON.TabIndex = 4;
            l_registerBUTTON.TabStop = true;
            l_registerBUTTON.Text = "here";
            l_registerBUTTON.TextAlign = ContentAlignment.MiddleCenter;
            l_registerBUTTON.VisitedLinkColor = Color.MidnightBlue;
            l_registerBUTTON.LinkClicked += l_registerBUTTON_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.Location = new Point(426, 357);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // l_loginBUTTON
            // 
            l_loginBUTTON.BackColor = Color.MidnightBlue;
            l_loginBUTTON.FlatStyle = FlatStyle.Flat;
            l_loginBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            l_loginBUTTON.ForeColor = Color.White;
            l_loginBUTTON.Location = new Point(500, 469);
            l_loginBUTTON.Name = "l_loginBUTTON";
            l_loginBUTTON.Size = new Size(88, 39);
            l_loginBUTTON.TabIndex = 3;
            l_loginBUTTON.Text = "Login";
            l_loginBUTTON.UseVisualStyleBackColor = false;
            l_loginBUTTON.Click += l_loginBUTTON_Click;
            // 
            // l_passwordBOX
            // 
            l_passwordBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_passwordBOX.Location = new Point(426, 378);
            l_passwordBOX.Name = "l_passwordBOX";
            l_passwordBOX.PasswordChar = '*';
            l_passwordBOX.Size = new Size(234, 22);
            l_passwordBOX.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 42F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(347, 64);
            label1.Name = "label1";
            label1.Size = new Size(463, 67);
            label1.TabIndex = 9;
            label1.Text = "CircuitCentral";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 800);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(l_registerBUTTON);
            Controls.Add(l_loginBUTTON);
            Controls.Add(label3);
            Controls.Add(l_passwordBOX);
            Controls.Add(label2);
            Controls.Add(l_emailBOX);
            Controls.Add(panel1);
            Controls.Add(label4);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CircuitCentral";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox l_emailBOX;
        private Label label2;
        private LinkLabel l_registerBUTTON;
        private Label label3;
        private Button l_loginBUTTON;
        private TextBox l_passwordBOX;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
