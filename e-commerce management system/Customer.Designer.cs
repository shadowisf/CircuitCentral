using System.Windows.Forms;

namespace e_commerce_management_system
{
    partial class Customer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            c_streetBOX = new TextBox();
            c_passwordBOX = new TextBox();
            c_nameBOX = new TextBox();
            c_LIST = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email_address = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            address_id = new DataGridViewTextBoxColumn();
            street = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            postal_code = new DataGridViewTextBoxColumn();
            country = new DataGridViewTextBoxColumn();
            c_deleteBUTTON = new Button();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            c_userLABEL = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            c_productBUTTON = new Button();
            c_orderBUTTON = new Button();
            c_supplierBUTTON = new Button();
            c_customerBUTTON = new Button();
            c_staffBUTTON = new Button();
            c_logoutBUTTON = new Button();
            label2 = new Label();
            panel1 = new Panel();
            c_phoneBOX = new TextBox();
            c_emailBOX = new TextBox();
            c_updateBUTTON = new Button();
            c_addBUTTON = new Button();
            c_cityBOX = new TextBox();
            c_postalBOX = new TextBox();
            c_countryBOX = new TextBox();
            c_clearBUTTON = new Button();
            c_refreshBUTTON = new Button();
            c_searchBOX = new TextBox();
            ((System.ComponentModel.ISupportInitialize)c_LIST).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // c_streetBOX
            // 
            c_streetBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_streetBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_streetBOX.Location = new Point(268, 687);
            c_streetBOX.Name = "c_streetBOX";
            c_streetBOX.PlaceholderText = "Street";
            c_streetBOX.Size = new Size(312, 22);
            c_streetBOX.TabIndex = 5;
            // 
            // c_passwordBOX
            // 
            c_passwordBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_passwordBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_passwordBOX.Location = new Point(268, 414);
            c_passwordBOX.Name = "c_passwordBOX";
            c_passwordBOX.PasswordChar = '*';
            c_passwordBOX.Size = new Size(312, 22);
            c_passwordBOX.TabIndex = 3;
            // 
            // c_nameBOX
            // 
            c_nameBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_nameBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_nameBOX.Location = new Point(268, 125);
            c_nameBOX.Name = "c_nameBOX";
            c_nameBOX.Size = new Size(312, 22);
            c_nameBOX.TabIndex = 1;
            // 
            // c_LIST
            // 
            c_LIST.AllowUserToAddRows = false;
            c_LIST.AllowUserToDeleteRows = false;
            c_LIST.AllowUserToResizeColumns = false;
            c_LIST.AllowUserToResizeRows = false;
            c_LIST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            c_LIST.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            c_LIST.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            c_LIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            c_LIST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            c_LIST.Columns.AddRange(new DataGridViewColumn[] { id, name, email_address, password, phone_number, address_id, street, city, postal_code, country });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            c_LIST.DefaultCellStyle = dataGridViewCellStyle7;
            c_LIST.Location = new Point(636, 104);
            c_LIST.MultiSelect = false;
            c_LIST.Name = "c_LIST";
            c_LIST.ReadOnly = true;
            c_LIST.RowHeadersVisible = false;
            c_LIST.RowHeadersWidth = 82;
            c_LIST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            c_LIST.ShowEditingIcon = false;
            c_LIST.Size = new Size(792, 664);
            c_LIST.TabIndex = 100;
            c_LIST.TabStop = false;
            c_LIST.SelectionChanged += c_LIST_SelectionChanged;
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
            password.HeaderText = "password";
            password.Name = "password";
            password.ReadOnly = true;
            password.Resizable = DataGridViewTriState.False;
            password.Visible = false;
            // 
            // phone_number
            // 
            phone_number.DataPropertyName = "phone_number";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            phone_number.DefaultCellStyle = dataGridViewCellStyle5;
            phone_number.HeaderText = "phone number";
            phone_number.Name = "phone_number";
            phone_number.ReadOnly = true;
            phone_number.Resizable = DataGridViewTriState.False;
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
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            country.DefaultCellStyle = dataGridViewCellStyle6;
            country.HeaderText = "country";
            country.Name = "country";
            country.ReadOnly = true;
            country.Resizable = DataGridViewTriState.False;
            // 
            // c_deleteBUTTON
            // 
            c_deleteBUTTON.BackColor = Color.DarkRed;
            c_deleteBUTTON.FlatStyle = FlatStyle.Flat;
            c_deleteBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            c_deleteBUTTON.ForeColor = Color.White;
            c_deleteBUTTON.Location = new Point(1328, 774);
            c_deleteBUTTON.Name = "c_deleteBUTTON";
            c_deleteBUTTON.Size = new Size(100, 30);
            c_deleteBUTTON.TabIndex = 14;
            c_deleteBUTTON.Text = "Delete";
            c_deleteBUTTON.UseVisualStyleBackColor = false;
            c_deleteBUTTON.Click += c_deleteBUTTON_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label8.Location = new Point(268, 535);
            label8.Name = "label8";
            label8.Size = new Size(139, 18);
            label8.TabIndex = 32;
            label8.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.Location = new Point(268, 393);
            label5.Name = "label5";
            label5.Size = new Size(95, 18);
            label5.TabIndex = 30;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.Location = new Point(268, 244);
            label4.Name = "label4";
            label4.Size = new Size(138, 18);
            label4.TabIndex = 29;
            label4.Text = "E-mail Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.Location = new Point(268, 666);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 28;
            label3.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 9);
            label7.Name = "label7";
            label7.Size = new Size(300, 26);
            label7.TabIndex = 0;
            label7.Text = "Customer Management";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(c_userLABEL);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 50);
            panel2.TabIndex = 26;
            // 
            // c_userLABEL
            // 
            c_userLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            c_userLABEL.ForeColor = Color.White;
            c_userLABEL.Location = new Point(436, 17);
            c_userLABEL.Name = "c_userLABEL";
            c_userLABEL.Size = new Size(792, 18);
            c_userLABEL.TabIndex = 102;
            c_userLABEL.TextAlign = ContentAlignment.MiddleRight;
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
            // c_productBUTTON
            // 
            c_productBUTTON.BackColor = Color.MidnightBlue;
            c_productBUTTON.FlatStyle = FlatStyle.Flat;
            c_productBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c_productBUTTON.ForeColor = Color.White;
            c_productBUTTON.Image = (Image)resources.GetObject("c_productBUTTON.Image");
            c_productBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            c_productBUTTON.Location = new Point(12, 307);
            c_productBUTTON.Name = "c_productBUTTON";
            c_productBUTTON.Size = new Size(177, 74);
            c_productBUTTON.TabIndex = 16;
            c_productBUTTON.Text = "Products";
            c_productBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            c_productBUTTON.UseVisualStyleBackColor = false;
            c_productBUTTON.Click += c_productBUTTON_Click;
            // 
            // c_orderBUTTON
            // 
            c_orderBUTTON.BackColor = Color.MidnightBlue;
            c_orderBUTTON.FlatStyle = FlatStyle.Flat;
            c_orderBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c_orderBUTTON.ForeColor = Color.White;
            c_orderBUTTON.Image = (Image)resources.GetObject("c_orderBUTTON.Image");
            c_orderBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            c_orderBUTTON.Location = new Point(12, 227);
            c_orderBUTTON.Name = "c_orderBUTTON";
            c_orderBUTTON.Size = new Size(177, 74);
            c_orderBUTTON.TabIndex = 15;
            c_orderBUTTON.Text = "Orders";
            c_orderBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            c_orderBUTTON.UseVisualStyleBackColor = false;
            c_orderBUTTON.Click += c_orderBUTTON_Click;
            // 
            // c_supplierBUTTON
            // 
            c_supplierBUTTON.BackColor = Color.MidnightBlue;
            c_supplierBUTTON.FlatStyle = FlatStyle.Flat;
            c_supplierBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c_supplierBUTTON.ForeColor = Color.White;
            c_supplierBUTTON.Image = (Image)resources.GetObject("c_supplierBUTTON.Image");
            c_supplierBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            c_supplierBUTTON.Location = new Point(12, 623);
            c_supplierBUTTON.Name = "c_supplierBUTTON";
            c_supplierBUTTON.Size = new Size(177, 74);
            c_supplierBUTTON.TabIndex = 18;
            c_supplierBUTTON.Text = "Suppliers";
            c_supplierBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            c_supplierBUTTON.UseVisualStyleBackColor = false;
            c_supplierBUTTON.Click += c_supplierBUTTON_Click;
            // 
            // c_customerBUTTON
            // 
            c_customerBUTTON.BackColor = Color.DodgerBlue;
            c_customerBUTTON.FlatStyle = FlatStyle.Flat;
            c_customerBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c_customerBUTTON.ForeColor = Color.White;
            c_customerBUTTON.Image = (Image)resources.GetObject("c_customerBUTTON.Image");
            c_customerBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            c_customerBUTTON.Location = new Point(12, 463);
            c_customerBUTTON.Name = "c_customerBUTTON";
            c_customerBUTTON.Size = new Size(177, 74);
            c_customerBUTTON.TabIndex = 100;
            c_customerBUTTON.TabStop = false;
            c_customerBUTTON.Text = "Customers";
            c_customerBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            c_customerBUTTON.UseVisualStyleBackColor = false;
            // 
            // c_staffBUTTON
            // 
            c_staffBUTTON.BackColor = Color.MidnightBlue;
            c_staffBUTTON.FlatStyle = FlatStyle.Flat;
            c_staffBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c_staffBUTTON.ForeColor = Color.White;
            c_staffBUTTON.Image = (Image)resources.GetObject("c_staffBUTTON.Image");
            c_staffBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            c_staffBUTTON.Location = new Point(12, 543);
            c_staffBUTTON.Name = "c_staffBUTTON";
            c_staffBUTTON.Size = new Size(177, 74);
            c_staffBUTTON.TabIndex = 17;
            c_staffBUTTON.Text = "Staff";
            c_staffBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            c_staffBUTTON.UseVisualStyleBackColor = false;
            c_staffBUTTON.Click += c_staffBUTTON_Click;
            // 
            // c_logoutBUTTON
            // 
            c_logoutBUTTON.BackColor = Color.MidnightBlue;
            c_logoutBUTTON.FlatStyle = FlatStyle.Flat;
            c_logoutBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c_logoutBUTTON.ForeColor = Color.White;
            c_logoutBUTTON.Image = (Image)resources.GetObject("c_logoutBUTTON.Image");
            c_logoutBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            c_logoutBUTTON.Location = new Point(12, 774);
            c_logoutBUTTON.Name = "c_logoutBUTTON";
            c_logoutBUTTON.Size = new Size(177, 74);
            c_logoutBUTTON.TabIndex = 19;
            c_logoutBUTTON.Text = "Logout";
            c_logoutBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            c_logoutBUTTON.UseVisualStyleBackColor = false;
            c_logoutBUTTON.Click += c_logoutBUTTON_Click;
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
            panel1.Controls.Add(c_orderBUTTON);
            panel1.Controls.Add(c_logoutBUTTON);
            panel1.Controls.Add(c_productBUTTON);
            panel1.Controls.Add(c_customerBUTTON);
            panel1.Controls.Add(c_staffBUTTON);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 860);
            panel1.TabIndex = 25;
            // 
            // c_phoneBOX
            // 
            c_phoneBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_phoneBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_phoneBOX.Location = new Point(268, 556);
            c_phoneBOX.Name = "c_phoneBOX";
            c_phoneBOX.Size = new Size(312, 22);
            c_phoneBOX.TabIndex = 4;
            // 
            // c_emailBOX
            // 
            c_emailBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_emailBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_emailBOX.Location = new Point(268, 265);
            c_emailBOX.Name = "c_emailBOX";
            c_emailBOX.Size = new Size(312, 22);
            c_emailBOX.TabIndex = 2;
            // 
            // c_updateBUTTON
            // 
            c_updateBUTTON.BackColor = Color.MidnightBlue;
            c_updateBUTTON.FlatStyle = FlatStyle.Flat;
            c_updateBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            c_updateBUTTON.ForeColor = Color.White;
            c_updateBUTTON.Location = new Point(742, 774);
            c_updateBUTTON.Name = "c_updateBUTTON";
            c_updateBUTTON.Size = new Size(100, 30);
            c_updateBUTTON.TabIndex = 12;
            c_updateBUTTON.Text = "Update";
            c_updateBUTTON.UseVisualStyleBackColor = false;
            c_updateBUTTON.Click += c_updateBUTTON_Click;
            // 
            // c_addBUTTON
            // 
            c_addBUTTON.BackColor = Color.Goldenrod;
            c_addBUTTON.FlatStyle = FlatStyle.Flat;
            c_addBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            c_addBUTTON.ForeColor = Color.White;
            c_addBUTTON.Location = new Point(268, 774);
            c_addBUTTON.Name = "c_addBUTTON";
            c_addBUTTON.Size = new Size(146, 30);
            c_addBUTTON.TabIndex = 9;
            c_addBUTTON.Text = "Add Customer";
            c_addBUTTON.UseVisualStyleBackColor = false;
            c_addBUTTON.Click += c_createBUTTON_Click;
            // 
            // c_cityBOX
            // 
            c_cityBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_cityBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_cityBOX.Location = new Point(268, 718);
            c_cityBOX.Name = "c_cityBOX";
            c_cityBOX.PlaceholderText = "City";
            c_cityBOX.Size = new Size(100, 22);
            c_cityBOX.TabIndex = 6;
            // 
            // c_postalBOX
            // 
            c_postalBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_postalBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_postalBOX.Location = new Point(374, 718);
            c_postalBOX.Name = "c_postalBOX";
            c_postalBOX.PlaceholderText = "Postal Code";
            c_postalBOX.Size = new Size(100, 22);
            c_postalBOX.TabIndex = 7;
            // 
            // c_countryBOX
            // 
            c_countryBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_countryBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_countryBOX.Location = new Point(480, 718);
            c_countryBOX.Name = "c_countryBOX";
            c_countryBOX.PlaceholderText = "Country";
            c_countryBOX.Size = new Size(100, 22);
            c_countryBOX.TabIndex = 8;
            // 
            // c_clearBUTTON
            // 
            c_clearBUTTON.BackColor = Color.MidnightBlue;
            c_clearBUTTON.FlatStyle = FlatStyle.Flat;
            c_clearBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            c_clearBUTTON.ForeColor = Color.White;
            c_clearBUTTON.Location = new Point(480, 774);
            c_clearBUTTON.Name = "c_clearBUTTON";
            c_clearBUTTON.Size = new Size(100, 30);
            c_clearBUTTON.TabIndex = 10;
            c_clearBUTTON.Text = "Clear";
            c_clearBUTTON.UseVisualStyleBackColor = false;
            c_clearBUTTON.Click += c_clearBUTTON_Click;
            // 
            // c_refreshBUTTON
            // 
            c_refreshBUTTON.BackColor = Color.MidnightBlue;
            c_refreshBUTTON.FlatStyle = FlatStyle.Flat;
            c_refreshBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            c_refreshBUTTON.ForeColor = Color.White;
            c_refreshBUTTON.Location = new Point(636, 774);
            c_refreshBUTTON.Name = "c_refreshBUTTON";
            c_refreshBUTTON.Size = new Size(100, 30);
            c_refreshBUTTON.TabIndex = 11;
            c_refreshBUTTON.Text = "Refresh";
            c_refreshBUTTON.UseVisualStyleBackColor = false;
            c_refreshBUTTON.Click += c_refreshBUTTON_Click;
            // 
            // c_searchBOX
            // 
            c_searchBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c_searchBOX.BackColor = SystemColors.Window;
            c_searchBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_searchBOX.ForeColor = Color.Black;
            c_searchBOX.Location = new Point(996, 774);
            c_searchBOX.Name = "c_searchBOX";
            c_searchBOX.PlaceholderText = "Search";
            c_searchBOX.Size = new Size(186, 22);
            c_searchBOX.TabIndex = 13;
            c_searchBOX.TextChanged += c_searchBOX_TextChanged;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1500, 860);
            Controls.Add(c_searchBOX);
            Controls.Add(c_refreshBUTTON);
            Controls.Add(c_clearBUTTON);
            Controls.Add(c_countryBOX);
            Controls.Add(c_postalBOX);
            Controls.Add(c_cityBOX);
            Controls.Add(c_supplierBUTTON);
            Controls.Add(c_updateBUTTON);
            Controls.Add(c_addBUTTON);
            Controls.Add(c_emailBOX);
            Controls.Add(c_phoneBOX);
            Controls.Add(c_streetBOX);
            Controls.Add(c_passwordBOX);
            Controls.Add(c_nameBOX);
            Controls.Add(c_LIST);
            Controls.Add(c_deleteBUTTON);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)c_LIST).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox c_streetBOX;
        private TextBox c_passwordBOX;
        private TextBox c_nameBOX;
        private DataGridView c_LIST;
        private Button c_deleteBUTTON;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button c_productBUTTON;
        private Button c_orderBUTTON;
        private Button c_supplierBUTTON;
        private Button c_customerBUTTON;
        private Button c_staffBUTTON;
        private Button c_logoutBUTTON;
        private Label label2;
        private Panel panel1;
        private TextBox c_phoneBOX;
        private TextBox c_emailBOX;
        private Button c_updateBUTTON;
        private Button c_addBUTTON;
        private TextBox c_cityBOX;
        private TextBox c_postalBOX;
        private TextBox c_countryBOX;
        private Button c_clearBUTTON;
        private Button c_refreshBUTTON;
        private TextBox c_searchBOX;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email_address;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn address_id;
        private DataGridViewTextBoxColumn street;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn postal_code;
        private DataGridViewTextBoxColumn country;
        private Label c_userLABEL;
    }
}