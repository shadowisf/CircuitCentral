using System.Windows.Forms;

namespace e_commerce_management_system
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            su_emailBOX = new TextBox();
            su_nameBOX = new TextBox();
            su_deleteBUTTON = new Button();
            su_updateBUTTON = new Button();
            su_createBUTTON = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            su_userLABEL = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            su_productBUTTON = new Button();
            su_orderBUTTON = new Button();
            button4 = new Button();
            su_customerBUTTON = new Button();
            su_staffBUTTON = new Button();
            su_logoutBUTTON = new Button();
            label2 = new Label();
            panel1 = new Panel();
            su_phoneBOX = new TextBox();
            su_clearBUTTON = new Button();
            su_countryBOX = new TextBox();
            su_postalBOX = new TextBox();
            su_cityBOX = new TextBox();
            su_streetBOX = new TextBox();
            su_refreshBUTTON = new Button();
            su_searchBOX = new TextBox();
            su_LIST = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email_address = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            address_id = new DataGridViewTextBoxColumn();
            street = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            postal_code = new DataGridViewTextBoxColumn();
            country = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)su_LIST).BeginInit();
            SuspendLayout();
            // 
            // su_emailBOX
            // 
            su_emailBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            su_emailBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            su_emailBOX.Location = new Point(268, 301);
            su_emailBOX.Name = "su_emailBOX";
            su_emailBOX.Size = new Size(312, 22);
            su_emailBOX.TabIndex = 2;
            // 
            // su_nameBOX
            // 
            su_nameBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            su_nameBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            su_nameBOX.Location = new Point(268, 125);
            su_nameBOX.Name = "su_nameBOX";
            su_nameBOX.Size = new Size(312, 22);
            su_nameBOX.TabIndex = 1;
            // 
            // su_deleteBUTTON
            // 
            su_deleteBUTTON.BackColor = Color.DarkRed;
            su_deleteBUTTON.FlatStyle = FlatStyle.Flat;
            su_deleteBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            su_deleteBUTTON.ForeColor = Color.White;
            su_deleteBUTTON.Location = new Point(1328, 774);
            su_deleteBUTTON.Name = "su_deleteBUTTON";
            su_deleteBUTTON.Size = new Size(100, 30);
            su_deleteBUTTON.TabIndex = 13;
            su_deleteBUTTON.Text = "Delete";
            su_deleteBUTTON.UseVisualStyleBackColor = false;
            su_deleteBUTTON.Click += su_deleteBUTTON_Click;
            // 
            // su_updateBUTTON
            // 
            su_updateBUTTON.BackColor = Color.MidnightBlue;
            su_updateBUTTON.FlatStyle = FlatStyle.Flat;
            su_updateBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            su_updateBUTTON.ForeColor = Color.White;
            su_updateBUTTON.Location = new Point(742, 774);
            su_updateBUTTON.Name = "su_updateBUTTON";
            su_updateBUTTON.Size = new Size(100, 30);
            su_updateBUTTON.TabIndex = 11;
            su_updateBUTTON.Text = "Update";
            su_updateBUTTON.UseVisualStyleBackColor = false;
            su_updateBUTTON.Click += su_updateBUTTON_Click;
            // 
            // su_createBUTTON
            // 
            su_createBUTTON.BackColor = Color.Goldenrod;
            su_createBUTTON.FlatStyle = FlatStyle.Flat;
            su_createBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            su_createBUTTON.ForeColor = Color.White;
            su_createBUTTON.Location = new Point(268, 774);
            su_createBUTTON.Name = "su_createBUTTON";
            su_createBUTTON.Size = new Size(129, 30);
            su_createBUTTON.TabIndex = 8;
            su_createBUTTON.Text = "Add Supplier";
            su_createBUTTON.UseVisualStyleBackColor = false;
            su_createBUTTON.Click += su_createBUTTON_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.Location = new Point(268, 666);
            label6.Name = "label6";
            label6.Size = new Size(79, 18);
            label6.TabIndex = 31;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.Location = new Point(267, 479);
            label5.Name = "label5";
            label5.Size = new Size(139, 18);
            label5.TabIndex = 30;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.Location = new Point(268, 280);
            label4.Name = "label4";
            label4.Size = new Size(138, 18);
            label4.TabIndex = 29;
            label4.Text = "E-mail Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 9);
            label7.Name = "label7";
            label7.Size = new Size(285, 26);
            label7.TabIndex = 0;
            label7.Text = "Supplier Management";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(su_userLABEL);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 50);
            panel2.TabIndex = 26;
            // 
            // su_userLABEL
            // 
            su_userLABEL.BackColor = Color.MidnightBlue;
            su_userLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            su_userLABEL.ForeColor = Color.White;
            su_userLABEL.Location = new Point(436, 17);
            su_userLABEL.Name = "su_userLABEL";
            su_userLABEL.Size = new Size(792, 18);
            su_userLABEL.TabIndex = 104;
            su_userLABEL.TextAlign = ContentAlignment.MiddleRight;
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
            // su_productBUTTON
            // 
            su_productBUTTON.BackColor = Color.MidnightBlue;
            su_productBUTTON.FlatStyle = FlatStyle.Flat;
            su_productBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            su_productBUTTON.ForeColor = Color.White;
            su_productBUTTON.Image = (Image)resources.GetObject("su_productBUTTON.Image");
            su_productBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            su_productBUTTON.Location = new Point(12, 307);
            su_productBUTTON.Name = "su_productBUTTON";
            su_productBUTTON.Size = new Size(177, 74);
            su_productBUTTON.TabIndex = 15;
            su_productBUTTON.Text = "Products";
            su_productBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            su_productBUTTON.UseVisualStyleBackColor = false;
            su_productBUTTON.Click += su_productBUTTON_Click;
            // 
            // su_orderBUTTON
            // 
            su_orderBUTTON.BackColor = Color.MidnightBlue;
            su_orderBUTTON.FlatStyle = FlatStyle.Flat;
            su_orderBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            su_orderBUTTON.ForeColor = Color.White;
            su_orderBUTTON.Image = (Image)resources.GetObject("su_orderBUTTON.Image");
            su_orderBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            su_orderBUTTON.Location = new Point(12, 227);
            su_orderBUTTON.Name = "su_orderBUTTON";
            su_orderBUTTON.Size = new Size(177, 74);
            su_orderBUTTON.TabIndex = 14;
            su_orderBUTTON.Text = "Orders";
            su_orderBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            su_orderBUTTON.UseVisualStyleBackColor = false;
            su_orderBUTTON.Click += su_orderBUTTON_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(12, 623);
            button4.Name = "button4";
            button4.Size = new Size(177, 74);
            button4.TabIndex = 100;
            button4.TabStop = false;
            button4.Text = "Suppliers";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // su_customerBUTTON
            // 
            su_customerBUTTON.BackColor = Color.MidnightBlue;
            su_customerBUTTON.FlatStyle = FlatStyle.Flat;
            su_customerBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            su_customerBUTTON.ForeColor = Color.White;
            su_customerBUTTON.Image = (Image)resources.GetObject("su_customerBUTTON.Image");
            su_customerBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            su_customerBUTTON.Location = new Point(12, 463);
            su_customerBUTTON.Name = "su_customerBUTTON";
            su_customerBUTTON.Size = new Size(177, 74);
            su_customerBUTTON.TabIndex = 16;
            su_customerBUTTON.Text = "Customers";
            su_customerBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            su_customerBUTTON.UseVisualStyleBackColor = false;
            su_customerBUTTON.Click += su_customerBUTTON_Click;
            // 
            // su_staffBUTTON
            // 
            su_staffBUTTON.BackColor = Color.MidnightBlue;
            su_staffBUTTON.FlatStyle = FlatStyle.Flat;
            su_staffBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            su_staffBUTTON.ForeColor = Color.White;
            su_staffBUTTON.Image = (Image)resources.GetObject("su_staffBUTTON.Image");
            su_staffBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            su_staffBUTTON.Location = new Point(12, 543);
            su_staffBUTTON.Name = "su_staffBUTTON";
            su_staffBUTTON.Size = new Size(177, 74);
            su_staffBUTTON.TabIndex = 17;
            su_staffBUTTON.Text = "Staff";
            su_staffBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            su_staffBUTTON.UseVisualStyleBackColor = false;
            su_staffBUTTON.Click += su_staffBUTTON_Click;
            // 
            // su_logoutBUTTON
            // 
            su_logoutBUTTON.BackColor = Color.MidnightBlue;
            su_logoutBUTTON.FlatStyle = FlatStyle.Flat;
            su_logoutBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            su_logoutBUTTON.ForeColor = Color.White;
            su_logoutBUTTON.Image = (Image)resources.GetObject("su_logoutBUTTON.Image");
            su_logoutBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            su_logoutBUTTON.Location = new Point(12, 774);
            su_logoutBUTTON.Name = "su_logoutBUTTON";
            su_logoutBUTTON.Size = new Size(177, 74);
            su_logoutBUTTON.TabIndex = 18;
            su_logoutBUTTON.Text = "Logout";
            su_logoutBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            su_logoutBUTTON.UseVisualStyleBackColor = false;
            su_logoutBUTTON.Click += su_logoutBUTTON_Click;
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
            panel1.Controls.Add(su_productBUTTON);
            panel1.Controls.Add(su_orderBUTTON);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(su_customerBUTTON);
            panel1.Controls.Add(su_staffBUTTON);
            panel1.Controls.Add(su_logoutBUTTON);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 860);
            panel1.TabIndex = 25;
            // 
            // su_phoneBOX
            // 
            su_phoneBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            su_phoneBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            su_phoneBOX.Location = new Point(267, 501);
            su_phoneBOX.Name = "su_phoneBOX";
            su_phoneBOX.Size = new Size(312, 22);
            su_phoneBOX.TabIndex = 3;
            // 
            // su_clearBUTTON
            // 
            su_clearBUTTON.BackColor = Color.MidnightBlue;
            su_clearBUTTON.FlatStyle = FlatStyle.Flat;
            su_clearBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            su_clearBUTTON.ForeColor = Color.White;
            su_clearBUTTON.Location = new Point(480, 774);
            su_clearBUTTON.Name = "su_clearBUTTON";
            su_clearBUTTON.Size = new Size(100, 30);
            su_clearBUTTON.TabIndex = 9;
            su_clearBUTTON.Text = "Clear";
            su_clearBUTTON.UseVisualStyleBackColor = false;
            su_clearBUTTON.Click += su_clearBUTTON_Click;
            // 
            // su_countryBOX
            // 
            su_countryBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            su_countryBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            su_countryBOX.Location = new Point(480, 718);
            su_countryBOX.Name = "su_countryBOX";
            su_countryBOX.PlaceholderText = "Country";
            su_countryBOX.Size = new Size(100, 22);
            su_countryBOX.TabIndex = 7;
            // 
            // su_postalBOX
            // 
            su_postalBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            su_postalBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            su_postalBOX.Location = new Point(374, 718);
            su_postalBOX.Name = "su_postalBOX";
            su_postalBOX.PlaceholderText = "Postal Code";
            su_postalBOX.Size = new Size(100, 22);
            su_postalBOX.TabIndex = 6;
            // 
            // su_cityBOX
            // 
            su_cityBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            su_cityBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            su_cityBOX.Location = new Point(268, 718);
            su_cityBOX.Name = "su_cityBOX";
            su_cityBOX.PlaceholderText = "City";
            su_cityBOX.Size = new Size(100, 22);
            su_cityBOX.TabIndex = 5;
            // 
            // su_streetBOX
            // 
            su_streetBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            su_streetBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            su_streetBOX.Location = new Point(268, 687);
            su_streetBOX.Name = "su_streetBOX";
            su_streetBOX.PlaceholderText = "Street";
            su_streetBOX.Size = new Size(312, 22);
            su_streetBOX.TabIndex = 4;
            // 
            // su_refreshBUTTON
            // 
            su_refreshBUTTON.BackColor = Color.MidnightBlue;
            su_refreshBUTTON.FlatStyle = FlatStyle.Flat;
            su_refreshBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            su_refreshBUTTON.ForeColor = Color.White;
            su_refreshBUTTON.Location = new Point(636, 774);
            su_refreshBUTTON.Name = "su_refreshBUTTON";
            su_refreshBUTTON.Size = new Size(100, 30);
            su_refreshBUTTON.TabIndex = 10;
            su_refreshBUTTON.Text = "Refresh";
            su_refreshBUTTON.UseVisualStyleBackColor = false;
            su_refreshBUTTON.Click += su_refreshBUTTON_Click;
            // 
            // su_searchBOX
            // 
            su_searchBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            su_searchBOX.BackColor = SystemColors.Window;
            su_searchBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            su_searchBOX.ForeColor = Color.Black;
            su_searchBOX.Location = new Point(996, 774);
            su_searchBOX.Name = "su_searchBOX";
            su_searchBOX.PlaceholderText = "Search";
            su_searchBOX.Size = new Size(186, 22);
            su_searchBOX.TabIndex = 12;
            su_searchBOX.TextChanged += su_searchBOX_TextChanged;
            // 
            // su_LIST
            // 
            su_LIST.AllowUserToAddRows = false;
            su_LIST.AllowUserToDeleteRows = false;
            su_LIST.AllowUserToResizeColumns = false;
            su_LIST.AllowUserToResizeRows = false;
            su_LIST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            su_LIST.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            su_LIST.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            su_LIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            su_LIST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            su_LIST.Columns.AddRange(new DataGridViewColumn[] { id, name, email_address, phone_number, address_id, street, city, postal_code, country });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            su_LIST.DefaultCellStyle = dataGridViewCellStyle7;
            su_LIST.Location = new Point(636, 104);
            su_LIST.MultiSelect = false;
            su_LIST.Name = "su_LIST";
            su_LIST.ReadOnly = true;
            su_LIST.RowHeadersVisible = false;
            su_LIST.RowHeadersWidth = 82;
            su_LIST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            su_LIST.ShowEditingIcon = false;
            su_LIST.Size = new Size(792, 664);
            su_LIST.TabIndex = 101;
            su_LIST.TabStop = false;
            su_LIST.SelectionChanged += su_LIST_SelectionChanged;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 860);
            Controls.Add(su_LIST);
            Controls.Add(su_searchBOX);
            Controls.Add(su_refreshBUTTON);
            Controls.Add(su_countryBOX);
            Controls.Add(su_postalBOX);
            Controls.Add(su_cityBOX);
            Controls.Add(su_streetBOX);
            Controls.Add(su_clearBUTTON);
            Controls.Add(su_phoneBOX);
            Controls.Add(su_emailBOX);
            Controls.Add(su_nameBOX);
            Controls.Add(su_deleteBUTTON);
            Controls.Add(su_updateBUTTON);
            Controls.Add(su_createBUTTON);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Supplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)su_LIST).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox su_emailBOX;
        private TextBox su_nameBOX;
        private Button su_deleteBUTTON;
        private Button su_updateBUTTON;
        private Button su_createBUTTON;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button su_productBUTTON;
        private Button su_orderBUTTON;
        private Button button4;
        private Button su_customerBUTTON;
        private Button su_staffBUTTON;
        private Button su_logoutBUTTON;
        private Label label2;
        private Panel panel1;
        private TextBox su_phoneBOX;
        private Button su_clearBUTTON;
        private TextBox su_countryBOX;
        private TextBox su_postalBOX;
        private TextBox su_cityBOX;
        private TextBox su_streetBOX;
        private Button su_refreshBUTTON;
        private TextBox su_searchBOX;
        private DataGridView su_LIST;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email_address;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn address_id;
        private DataGridViewTextBoxColumn street;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn postal_code;
        private DataGridViewTextBoxColumn country;
        private Label su_userLABEL;
    }
}