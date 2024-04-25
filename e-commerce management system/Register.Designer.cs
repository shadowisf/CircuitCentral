namespace e_commerce_management_system
{
    partial class Register
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            r_linkBUTTON = new LinkLabel();
            r_registerBUTTON = new Button();
            label3 = new Label();
            r_passwordBOX = new TextBox();
            label2 = new Label();
            r_nameBOX = new TextBox();
            label4 = new Label();
            label5 = new Label();
            r_emailBOX = new TextBox();
            label6 = new Label();
            r_phoneBOX = new TextBox();
            r_countryBOX = new TextBox();
            r_postalBOX = new TextBox();
            r_cityBOX = new TextBox();
            r_lineBOX = new TextBox();
            label8 = new Label();
            r_clearBUTTON = new Button();
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
            panel1.TabIndex = 9;
            // 
            // r_linkBUTTON
            // 
            r_linkBUTTON.AutoSize = true;
            r_linkBUTTON.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_linkBUTTON.LinkColor = Color.MidnightBlue;
            r_linkBUTTON.Location = new Point(617, 702);
            r_linkBUTTON.Name = "r_linkBUTTON";
            r_linkBUTTON.Size = new Size(36, 14);
            r_linkBUTTON.TabIndex = 11;
            r_linkBUTTON.TabStop = true;
            r_linkBUTTON.Text = "here";
            r_linkBUTTON.TextAlign = ContentAlignment.MiddleCenter;
            r_linkBUTTON.VisitedLinkColor = Color.MidnightBlue;
            r_linkBUTTON.LinkClicked += r_linkBUTTON_LinkClicked;
            // 
            // r_registerBUTTON
            // 
            r_registerBUTTON.BackColor = Color.MidnightBlue;
            r_registerBUTTON.FlatStyle = FlatStyle.Flat;
            r_registerBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            r_registerBUTTON.ForeColor = Color.White;
            r_registerBUTTON.Location = new Point(493, 610);
            r_registerBUTTON.Name = "r_registerBUTTON";
            r_registerBUTTON.Size = new Size(118, 35);
            r_registerBUTTON.TabIndex = 9;
            r_registerBUTTON.Text = "Register";
            r_registerBUTTON.UseVisualStyleBackColor = false;
            r_registerBUTTON.Click += r_registerBUTTON_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.Location = new Point(286, 329);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // r_passwordBOX
            // 
            r_passwordBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_passwordBOX.Location = new Point(286, 350);
            r_passwordBOX.Name = "r_passwordBOX";
            r_passwordBOX.PasswordChar = '*';
            r_passwordBOX.Size = new Size(524, 22);
            r_passwordBOX.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(286, 171);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // r_nameBOX
            // 
            r_nameBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_nameBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_nameBOX.Location = new Point(286, 192);
            r_nameBOX.Name = "r_nameBOX";
            r_nameBOX.Size = new Size(524, 22);
            r_nameBOX.TabIndex = 1;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(286, 689);
            label4.Name = "label4";
            label4.Size = new Size(524, 40);
            label4.TabIndex = 17;
            label4.Text = "Already a member? Click     ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.Location = new Point(286, 248);
            label5.Name = "label5";
            label5.Size = new Size(138, 18);
            label5.TabIndex = 20;
            label5.Text = "E-mail Address";
            // 
            // r_emailBOX
            // 
            r_emailBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_emailBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_emailBOX.Location = new Point(286, 269);
            r_emailBOX.Name = "r_emailBOX";
            r_emailBOX.Size = new Size(524, 22);
            r_emailBOX.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.Location = new Point(286, 411);
            label6.Name = "label6";
            label6.Size = new Size(139, 18);
            label6.TabIndex = 22;
            label6.Text = "Phone Number";
            // 
            // r_phoneBOX
            // 
            r_phoneBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_phoneBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_phoneBOX.Location = new Point(286, 432);
            r_phoneBOX.Name = "r_phoneBOX";
            r_phoneBOX.Size = new Size(524, 22);
            r_phoneBOX.TabIndex = 4;
            // 
            // r_countryBOX
            // 
            r_countryBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_countryBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_countryBOX.Location = new Point(617, 549);
            r_countryBOX.Name = "r_countryBOX";
            r_countryBOX.PlaceholderText = "Country";
            r_countryBOX.Size = new Size(193, 22);
            r_countryBOX.TabIndex = 8;
            // 
            // r_postalBOX
            // 
            r_postalBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_postalBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_postalBOX.Location = new Point(493, 549);
            r_postalBOX.Name = "r_postalBOX";
            r_postalBOX.PlaceholderText = "Postal Code";
            r_postalBOX.Size = new Size(118, 22);
            r_postalBOX.TabIndex = 7;
            // 
            // r_cityBOX
            // 
            r_cityBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_cityBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_cityBOX.Location = new Point(286, 549);
            r_cityBOX.Name = "r_cityBOX";
            r_cityBOX.PlaceholderText = "City";
            r_cityBOX.Size = new Size(201, 22);
            r_cityBOX.TabIndex = 6;
            // 
            // r_lineBOX
            // 
            r_lineBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_lineBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_lineBOX.Location = new Point(286, 516);
            r_lineBOX.Name = "r_lineBOX";
            r_lineBOX.PlaceholderText = "Street";
            r_lineBOX.Size = new Size(524, 22);
            r_lineBOX.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label8.Location = new Point(286, 495);
            label8.Name = "label8";
            label8.Size = new Size(79, 18);
            label8.TabIndex = 33;
            label8.Text = "Address";
            // 
            // r_clearBUTTON
            // 
            r_clearBUTTON.BackColor = Color.MidnightBlue;
            r_clearBUTTON.FlatStyle = FlatStyle.Flat;
            r_clearBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            r_clearBUTTON.ForeColor = Color.White;
            r_clearBUTTON.Location = new Point(726, 610);
            r_clearBUTTON.Name = "r_clearBUTTON";
            r_clearBUTTON.Size = new Size(84, 35);
            r_clearBUTTON.TabIndex = 10;
            r_clearBUTTON.Text = "Clear";
            r_clearBUTTON.UseVisualStyleBackColor = false;
            r_clearBUTTON.Click += r_clearBUTTON_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
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
            label1.TabIndex = 35;
            label1.Text = "CircuitCentral";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 800);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(r_clearBUTTON);
            Controls.Add(r_countryBOX);
            Controls.Add(r_postalBOX);
            Controls.Add(r_cityBOX);
            Controls.Add(r_lineBOX);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(r_phoneBOX);
            Controls.Add(label5);
            Controls.Add(r_emailBOX);
            Controls.Add(panel1);
            Controls.Add(r_linkBUTTON);
            Controls.Add(r_registerBUTTON);
            Controls.Add(label3);
            Controls.Add(r_passwordBOX);
            Controls.Add(label2);
            Controls.Add(r_nameBOX);
            Controls.Add(label4);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel r_linkBUTTON;
        private Button r_registerBUTTON;
        private Label label3;
        private TextBox r_passwordBOX;
        private Label label2;
        private TextBox r_nameBOX;
        private Label label4;
        private Label label5;
        private TextBox r_emailBOX;
        private Label label6;
        private TextBox r_phoneBOX;
        private TextBox r_countryBOX;
        private TextBox r_postalBOX;
        private TextBox r_cityBOX;
        private TextBox r_lineBOX;
        private Label label8;
        private Button r_clearBUTTON;
        private PictureBox pictureBox1;
        private Label label1;
    }
}