using System.Windows.Forms;

namespace e_commerce_management_system
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            s_phoneBOX = new TextBox();
            s_passwordBOX = new TextBox();
            s_nameBOX = new TextBox();
            s_deleteBUTTON = new Button();
            s_updateBUTTON = new Button();
            s_createBUTTON = new Button();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            s_productBUTTON = new Button();
            s_orderBUTTON = new Button();
            s_supplierBUTTON = new Button();
            s_customerBUTTON = new Button();
            button2 = new Button();
            s_logoutBUTTON = new Button();
            label2 = new Label();
            panel1 = new Panel();
            s_departmentBOX = new ComboBox();
            s_emailBOX = new TextBox();
            s_refreshBUTTON = new Button();
            s_countryBOX = new TextBox();
            s_postalBOX = new TextBox();
            s_cityBOX = new TextBox();
            s_streetBOX = new TextBox();
            label9 = new Label();
            s_clearBUTTON = new Button();
            s_searchBOX = new TextBox();
            s_LIST = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email_address = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            address_id = new DataGridViewTextBoxColumn();
            street = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            postal_code = new DataGridViewTextBoxColumn();
            country = new DataGridViewTextBoxColumn();
            s_userLABEL = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)s_LIST).BeginInit();
            SuspendLayout();
            // 
            // s_phoneBOX
            // 
            s_phoneBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            s_phoneBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_phoneBOX.Location = new Point(268, 456);
            s_phoneBOX.Name = "s_phoneBOX";
            s_phoneBOX.Size = new Size(312, 22);
            s_phoneBOX.TabIndex = 4;
            // 
            // s_passwordBOX
            // 
            s_passwordBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_passwordBOX.Location = new Point(268, 333);
            s_passwordBOX.Name = "s_passwordBOX";
            s_passwordBOX.PasswordChar = '*';
            s_passwordBOX.Size = new Size(312, 22);
            s_passwordBOX.TabIndex = 3;
            // 
            // s_nameBOX
            // 
            s_nameBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            s_nameBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_nameBOX.Location = new Point(268, 125);
            s_nameBOX.Name = "s_nameBOX";
            s_nameBOX.Size = new Size(312, 22);
            s_nameBOX.TabIndex = 1;
            // 
            // s_deleteBUTTON
            // 
            s_deleteBUTTON.BackColor = Color.DarkRed;
            s_deleteBUTTON.FlatStyle = FlatStyle.Flat;
            s_deleteBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            s_deleteBUTTON.ForeColor = Color.White;
            s_deleteBUTTON.Location = new Point(1328, 774);
            s_deleteBUTTON.Name = "s_deleteBUTTON";
            s_deleteBUTTON.Size = new Size(100, 30);
            s_deleteBUTTON.TabIndex = 15;
            s_deleteBUTTON.Text = "Delete";
            s_deleteBUTTON.UseVisualStyleBackColor = false;
            s_deleteBUTTON.Click += s_deleteBUTTON_Click;
            // 
            // s_updateBUTTON
            // 
            s_updateBUTTON.BackColor = Color.MidnightBlue;
            s_updateBUTTON.FlatStyle = FlatStyle.Flat;
            s_updateBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            s_updateBUTTON.ForeColor = Color.White;
            s_updateBUTTON.Location = new Point(742, 774);
            s_updateBUTTON.Name = "s_updateBUTTON";
            s_updateBUTTON.Size = new Size(100, 30);
            s_updateBUTTON.TabIndex = 13;
            s_updateBUTTON.Text = "Update";
            s_updateBUTTON.UseVisualStyleBackColor = false;
            s_updateBUTTON.Click += s_updateBUTTON_Click;
            // 
            // s_createBUTTON
            // 
            s_createBUTTON.BackColor = Color.Goldenrod;
            s_createBUTTON.FlatStyle = FlatStyle.Flat;
            s_createBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            s_createBUTTON.ForeColor = Color.White;
            s_createBUTTON.Location = new Point(268, 774);
            s_createBUTTON.Name = "s_createBUTTON";
            s_createBUTTON.Size = new Size(100, 30);
            s_createBUTTON.TabIndex = 10;
            s_createBUTTON.Text = "Add Staff";
            s_createBUTTON.UseVisualStyleBackColor = false;
            s_createBUTTON.Click += s_addBUTTON_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label8.Location = new Point(268, 435);
            label8.Name = "label8";
            label8.Size = new Size(139, 18);
            label8.TabIndex = 32;
            label8.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.Location = new Point(268, 312);
            label5.Name = "label5";
            label5.Size = new Size(95, 18);
            label5.TabIndex = 30;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.Location = new Point(268, 199);
            label4.Name = "label4";
            label4.Size = new Size(138, 18);
            label4.TabIndex = 29;
            label4.Text = "E-mail Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.Location = new Point(268, 559);
            label3.Name = "label3";
            label3.Size = new Size(114, 18);
            label3.TabIndex = 28;
            label3.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 9);
            label7.Name = "label7";
            label7.Size = new Size(240, 26);
            label7.TabIndex = 0;
            label7.Text = "Staff Management";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 50);
            panel2.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 122);
            label1.Name = "label1";
            label1.Size = new Size(112, 17);
            label1.TabIndex = 2;
            label1.Text = "CircuitCentral";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // s_productBUTTON
            // 
            s_productBUTTON.BackColor = Color.MidnightBlue;
            s_productBUTTON.FlatStyle = FlatStyle.Flat;
            s_productBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s_productBUTTON.ForeColor = Color.White;
            s_productBUTTON.Image = (Image)resources.GetObject("s_productBUTTON.Image");
            s_productBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            s_productBUTTON.Location = new Point(12, 306);
            s_productBUTTON.Name = "s_productBUTTON";
            s_productBUTTON.Size = new Size(177, 74);
            s_productBUTTON.TabIndex = 17;
            s_productBUTTON.Text = "Products";
            s_productBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            s_productBUTTON.UseVisualStyleBackColor = false;
            s_productBUTTON.Click += s_productBUTTON_Click;
            // 
            // s_orderBUTTON
            // 
            s_orderBUTTON.BackColor = Color.MidnightBlue;
            s_orderBUTTON.FlatStyle = FlatStyle.Flat;
            s_orderBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s_orderBUTTON.ForeColor = Color.White;
            s_orderBUTTON.Image = (Image)resources.GetObject("s_orderBUTTON.Image");
            s_orderBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            s_orderBUTTON.Location = new Point(12, 227);
            s_orderBUTTON.Name = "s_orderBUTTON";
            s_orderBUTTON.Size = new Size(177, 74);
            s_orderBUTTON.TabIndex = 16;
            s_orderBUTTON.Text = "Orders";
            s_orderBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            s_orderBUTTON.UseVisualStyleBackColor = false;
            s_orderBUTTON.Click += s_orderBUTTON_Click;
            // 
            // s_supplierBUTTON
            // 
            s_supplierBUTTON.BackColor = Color.MidnightBlue;
            s_supplierBUTTON.FlatStyle = FlatStyle.Flat;
            s_supplierBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s_supplierBUTTON.ForeColor = Color.White;
            s_supplierBUTTON.Image = (Image)resources.GetObject("s_supplierBUTTON.Image");
            s_supplierBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            s_supplierBUTTON.Location = new Point(12, 623);
            s_supplierBUTTON.Name = "s_supplierBUTTON";
            s_supplierBUTTON.Size = new Size(177, 74);
            s_supplierBUTTON.TabIndex = 19;
            s_supplierBUTTON.Text = "Suppliers";
            s_supplierBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            s_supplierBUTTON.UseVisualStyleBackColor = false;
            s_supplierBUTTON.Click += s_supplierBUTTON_Click;
            // 
            // s_customerBUTTON
            // 
            s_customerBUTTON.BackColor = Color.MidnightBlue;
            s_customerBUTTON.FlatStyle = FlatStyle.Flat;
            s_customerBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s_customerBUTTON.ForeColor = Color.White;
            s_customerBUTTON.Image = (Image)resources.GetObject("s_customerBUTTON.Image");
            s_customerBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            s_customerBUTTON.Location = new Point(12, 463);
            s_customerBUTTON.Name = "s_customerBUTTON";
            s_customerBUTTON.Size = new Size(177, 74);
            s_customerBUTTON.TabIndex = 18;
            s_customerBUTTON.Text = "Customers";
            s_customerBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            s_customerBUTTON.UseVisualStyleBackColor = false;
            s_customerBUTTON.Click += s_customerBUTTON_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(12, 543);
            button2.Name = "button2";
            button2.Size = new Size(177, 74);
            button2.TabIndex = 100;
            button2.TabStop = false;
            button2.Text = "Staff";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // s_logoutBUTTON
            // 
            s_logoutBUTTON.BackColor = Color.MidnightBlue;
            s_logoutBUTTON.FlatStyle = FlatStyle.Flat;
            s_logoutBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s_logoutBUTTON.ForeColor = Color.White;
            s_logoutBUTTON.Image = (Image)resources.GetObject("s_logoutBUTTON.Image");
            s_logoutBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            s_logoutBUTTON.Location = new Point(12, 774);
            s_logoutBUTTON.Name = "s_logoutBUTTON";
            s_logoutBUTTON.Size = new Size(177, 74);
            s_logoutBUTTON.TabIndex = 20;
            s_logoutBUTTON.Text = "Logout";
            s_logoutBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            s_logoutBUTTON.UseVisualStyleBackColor = false;
            s_logoutBUTTON.Click += s_logoutBUTTON_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(268, 104);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 27;
            label2.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(s_productBUTTON);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(s_supplierBUTTON);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 860);
            panel1.TabIndex = 25;
            // 
            // s_departmentBOX
            // 
            s_departmentBOX.BackColor = Color.White;
            s_departmentBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            s_departmentBOX.FlatStyle = FlatStyle.Flat;
            s_departmentBOX.Font = new Font("Verdana", 9F);
            s_departmentBOX.FormattingEnabled = true;
            s_departmentBOX.Items.AddRange(new object[] { "sales & marketing", "customer support", "operations & logistics", "technology & it", "product management" });
            s_departmentBOX.Location = new Point(268, 580);
            s_departmentBOX.Name = "s_departmentBOX";
            s_departmentBOX.Size = new Size(312, 22);
            s_departmentBOX.TabIndex = 5;
            // 
            // s_emailBOX
            // 
            s_emailBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            s_emailBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_emailBOX.Location = new Point(268, 221);
            s_emailBOX.Name = "s_emailBOX";
            s_emailBOX.Size = new Size(312, 22);
            s_emailBOX.TabIndex = 2;
            // 
            // s_refreshBUTTON
            // 
            s_refreshBUTTON.BackColor = Color.MidnightBlue;
            s_refreshBUTTON.FlatStyle = FlatStyle.Flat;
            s_refreshBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            s_refreshBUTTON.ForeColor = Color.White;
            s_refreshBUTTON.Location = new Point(636, 774);
            s_refreshBUTTON.Name = "s_refreshBUTTON";
            s_refreshBUTTON.Size = new Size(100, 30);
            s_refreshBUTTON.TabIndex = 12;
            s_refreshBUTTON.Text = "Refresh";
            s_refreshBUTTON.UseVisualStyleBackColor = false;
            s_refreshBUTTON.Click += s_refreshBUTTON_Click;
            // 
            // s_countryBOX
            // 
            s_countryBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            s_countryBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_countryBOX.Location = new Point(480, 718);
            s_countryBOX.Name = "s_countryBOX";
            s_countryBOX.PlaceholderText = "Country";
            s_countryBOX.Size = new Size(100, 22);
            s_countryBOX.TabIndex = 9;
            // 
            // s_postalBOX
            // 
            s_postalBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            s_postalBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_postalBOX.Location = new Point(374, 718);
            s_postalBOX.Name = "s_postalBOX";
            s_postalBOX.PlaceholderText = "Postal Code";
            s_postalBOX.Size = new Size(100, 22);
            s_postalBOX.TabIndex = 8;
            // 
            // s_cityBOX
            // 
            s_cityBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            s_cityBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_cityBOX.Location = new Point(268, 718);
            s_cityBOX.Name = "s_cityBOX";
            s_cityBOX.PlaceholderText = "City";
            s_cityBOX.Size = new Size(100, 22);
            s_cityBOX.TabIndex = 7;
            // 
            // s_streetBOX
            // 
            s_streetBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            s_streetBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_streetBOX.Location = new Point(268, 687);
            s_streetBOX.Name = "s_streetBOX";
            s_streetBOX.PlaceholderText = "Street";
            s_streetBOX.Size = new Size(312, 22);
            s_streetBOX.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label9.Location = new Point(268, 666);
            label9.Name = "label9";
            label9.Size = new Size(79, 18);
            label9.TabIndex = 53;
            label9.Text = "Address";
            // 
            // s_clearBUTTON
            // 
            s_clearBUTTON.BackColor = Color.MidnightBlue;
            s_clearBUTTON.FlatStyle = FlatStyle.Flat;
            s_clearBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            s_clearBUTTON.ForeColor = Color.White;
            s_clearBUTTON.Location = new Point(480, 774);
            s_clearBUTTON.Name = "s_clearBUTTON";
            s_clearBUTTON.Size = new Size(100, 30);
            s_clearBUTTON.TabIndex = 11;
            s_clearBUTTON.Text = "Clear";
            s_clearBUTTON.UseVisualStyleBackColor = false;
            s_clearBUTTON.Click += s_clearBUTTON_Click;
            // 
            // s_searchBOX
            // 
            s_searchBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            s_searchBOX.BackColor = SystemColors.Window;
            s_searchBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_searchBOX.ForeColor = Color.Black;
            s_searchBOX.Location = new Point(996, 774);
            s_searchBOX.Name = "s_searchBOX";
            s_searchBOX.PlaceholderText = "Search";
            s_searchBOX.Size = new Size(186, 22);
            s_searchBOX.TabIndex = 14;
            s_searchBOX.TextChanged += s_searchBOX_TextChanged;
            // 
            // s_LIST
            // 
            s_LIST.AllowUserToAddRows = false;
            s_LIST.AllowUserToDeleteRows = false;
            s_LIST.AllowUserToResizeColumns = false;
            s_LIST.AllowUserToResizeRows = false;
            s_LIST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            s_LIST.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            s_LIST.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            s_LIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            s_LIST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            s_LIST.Columns.AddRange(new DataGridViewColumn[] { id, name, email_address, password, phone_number, department, address_id, street, city, postal_code, country });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            s_LIST.DefaultCellStyle = dataGridViewCellStyle9;
            s_LIST.Location = new Point(636, 104);
            s_LIST.MultiSelect = false;
            s_LIST.Name = "s_LIST";
            s_LIST.ReadOnly = true;
            s_LIST.RowHeadersVisible = false;
            s_LIST.RowHeadersWidth = 82;
            s_LIST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            s_LIST.ShowEditingIcon = false;
            s_LIST.Size = new Size(792, 664);
            s_LIST.TabIndex = 101;
            s_LIST.TabStop = false;
            s_LIST.SelectionChanged += s_LIST_SelectionChanged;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            id.DefaultCellStyle = dataGridViewCellStyle2;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            name.DefaultCellStyle = dataGridViewCellStyle3;
            name.HeaderText = "name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.False;
            // 
            // email_address
            // 
            email_address.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            email_address.DataPropertyName = "email_address";
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            email_address.DefaultCellStyle = dataGridViewCellStyle4;
            email_address.HeaderText = "email address";
            email_address.Name = "email_address";
            email_address.ReadOnly = true;
            email_address.Resizable = DataGridViewTriState.False;
            email_address.Width = 114;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            password.DefaultCellStyle = dataGridViewCellStyle5;
            password.HeaderText = "password";
            password.Name = "password";
            password.ReadOnly = true;
            password.Resizable = DataGridViewTriState.False;
            password.Visible = false;
            // 
            // phone_number
            // 
            phone_number.DataPropertyName = "phone_number";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            phone_number.DefaultCellStyle = dataGridViewCellStyle6;
            phone_number.HeaderText = "contact number";
            phone_number.Name = "phone_number";
            phone_number.ReadOnly = true;
            phone_number.Resizable = DataGridViewTriState.False;
            // 
            // department
            // 
            department.DataPropertyName = "department";
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            department.DefaultCellStyle = dataGridViewCellStyle7;
            department.HeaderText = "department";
            department.Name = "department";
            department.ReadOnly = true;
            department.Resizable = DataGridViewTriState.False;
            // 
            // address_id
            // 
            address_id.DataPropertyName = "address_id";
            address_id.HeaderText = "address_id";
            address_id.Name = "address_id";
            address_id.ReadOnly = true;
            address_id.Resizable = DataGridViewTriState.False;
            address_id.Visible = false;
            // 
            // street
            // 
            street.DataPropertyName = "street";
            street.HeaderText = "street";
            street.Name = "street";
            street.ReadOnly = true;
            street.Resizable = DataGridViewTriState.False;
            street.Visible = false;
            // 
            // city
            // 
            city.DataPropertyName = "city";
            city.HeaderText = "city";
            city.Name = "city";
            city.ReadOnly = true;
            city.Resizable = DataGridViewTriState.False;
            city.Visible = false;
            // 
            // postal_code
            // 
            postal_code.DataPropertyName = "postal_code";
            postal_code.HeaderText = "postal_code";
            postal_code.Name = "postal_code";
            postal_code.ReadOnly = true;
            postal_code.Resizable = DataGridViewTriState.False;
            postal_code.Visible = false;
            // 
            // country
            // 
            country.DataPropertyName = "country";
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            country.DefaultCellStyle = dataGridViewCellStyle8;
            country.HeaderText = "country";
            country.Name = "country";
            country.ReadOnly = true;
            country.Resizable = DataGridViewTriState.False;
            // 
            // s_userLABEL
            // 
            s_userLABEL.BackColor = Color.MidnightBlue;
            s_userLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            s_userLABEL.ForeColor = Color.White;
            s_userLABEL.Location = new Point(636, 17);
            s_userLABEL.Name = "s_userLABEL";
            s_userLABEL.Size = new Size(792, 18);
            s_userLABEL.TabIndex = 103;
            s_userLABEL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1500, 860);
            Controls.Add(s_userLABEL);
            Controls.Add(s_LIST);
            Controls.Add(s_searchBOX);
            Controls.Add(s_clearBUTTON);
            Controls.Add(s_logoutBUTTON);
            Controls.Add(s_orderBUTTON);
            Controls.Add(s_countryBOX);
            Controls.Add(s_postalBOX);
            Controls.Add(s_cityBOX);
            Controls.Add(s_streetBOX);
            Controls.Add(s_customerBUTTON);
            Controls.Add(label9);
            Controls.Add(s_refreshBUTTON);
            Controls.Add(s_emailBOX);
            Controls.Add(s_phoneBOX);
            Controls.Add(s_passwordBOX);
            Controls.Add(s_nameBOX);
            Controls.Add(s_deleteBUTTON);
            Controls.Add(s_updateBUTTON);
            Controls.Add(s_createBUTTON);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(s_departmentBOX);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)s_LIST).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox s_streetBOX;
        private TextBox s_phoneBOX;
        private TextBox s_passwordBOX;
        private TextBox s_nameBOX;
        private Button s_deleteBUTTON;
        private Button s_updateBUTTON;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button s_productBUTTON;
        private Button s_orderBUTTON;
        private Button s_supplierBUTTON;
        private Button s_customerBUTTON;
        private Button button2;
        private Button s_logoutBUTTON;
        private Label label2;
        private Panel panel1;
        private ComboBox s_departmentBOX;
        private TextBox s_emailBOX;
        private Button s_refreshBUTTON;
        private TextBox s_countryBOX;
        private TextBox s_postalBOX;
        private TextBox s_cityBOX;
        private Label label9;
        private Button s_clearBUTTON;
        private Button s_createBUTTON;
        private DataGridView s_LIST;
        private TextBox s_searchBOX;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email_address;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn address_id;
        private DataGridViewTextBoxColumn street;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn postal_code;
        private DataGridViewTextBoxColumn country;
        private Label s_userLABEL;
    }
}