using System.Windows.Forms;

namespace e_commerce_management_system
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            p_productBUTTON = new Button();
            p_orderBUTTON = new Button();
            p_supplierBUTTON = new Button();
            p_customerBUTTON = new Button();
            p_staffBUTTON = new Button();
            p_logoutBUTTON = new Button();
            panel2 = new Panel();
            p_userLABEL = new Label();
            label7 = new Label();
            p_nameLABEL = new Label();
            p_priceLABEL = new Label();
            p_categoryLABEL = new Label();
            p_descriptionLABEL = new Label();
            p_stockLABEL = new Label();
            p_supplierLABEL = new Label();
            p_categoryBOX = new ComboBox();
            p_supplierBOX = new ComboBox();
            p_addBUTTON = new Button();
            p_updateBUTTON = new Button();
            p_deleteBUTTON = new Button();
            p_nameBOX = new TextBox();
            p_descriptionBOX = new TextBox();
            p_priceBOX = new TextBox();
            p_stockBOX = new TextBox();
            p_refreshBUTON = new Button();
            p_clearBUTTON = new Button();
            p_LIST = new DataGridView();
            image = new DataGridViewImageColumn();
            image_link = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            supplier_id = new DataGridViewTextBoxColumn();
            supplier_name = new DataGridViewTextBoxColumn();
            p_searchBOX = new TextBox();
            p_imageBOX = new TextBox();
            p_imageLABEL = new Label();
            p_uploadBUTTON = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p_LIST).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(p_productBUTTON);
            panel1.Controls.Add(p_orderBUTTON);
            panel1.Controls.Add(p_supplierBUTTON);
            panel1.Controls.Add(p_customerBUTTON);
            panel1.Controls.Add(p_staffBUTTON);
            panel1.Controls.Add(p_logoutBUTTON);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 860);
            panel1.TabIndex = 1;
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
            // p_productBUTTON
            // 
            p_productBUTTON.BackColor = Color.DodgerBlue;
            p_productBUTTON.FlatStyle = FlatStyle.Flat;
            p_productBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p_productBUTTON.ForeColor = Color.White;
            p_productBUTTON.Image = (Image)resources.GetObject("p_productBUTTON.Image");
            p_productBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            p_productBUTTON.Location = new Point(12, 307);
            p_productBUTTON.Name = "p_productBUTTON";
            p_productBUTTON.Size = new Size(177, 74);
            p_productBUTTON.TabIndex = 111;
            p_productBUTTON.TabStop = false;
            p_productBUTTON.Text = "Products";
            p_productBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            p_productBUTTON.UseVisualStyleBackColor = false;
            // 
            // p_orderBUTTON
            // 
            p_orderBUTTON.BackColor = Color.MidnightBlue;
            p_orderBUTTON.FlatStyle = FlatStyle.Flat;
            p_orderBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p_orderBUTTON.ForeColor = Color.White;
            p_orderBUTTON.Image = (Image)resources.GetObject("p_orderBUTTON.Image");
            p_orderBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            p_orderBUTTON.Location = new Point(12, 227);
            p_orderBUTTON.Name = "p_orderBUTTON";
            p_orderBUTTON.Size = new Size(177, 74);
            p_orderBUTTON.TabIndex = 14;
            p_orderBUTTON.Text = "Orders";
            p_orderBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            p_orderBUTTON.UseVisualStyleBackColor = false;
            p_orderBUTTON.Click += p_orderBUTTON_Click;
            // 
            // p_supplierBUTTON
            // 
            p_supplierBUTTON.BackColor = Color.MidnightBlue;
            p_supplierBUTTON.FlatStyle = FlatStyle.Flat;
            p_supplierBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p_supplierBUTTON.ForeColor = Color.White;
            p_supplierBUTTON.Image = (Image)resources.GetObject("p_supplierBUTTON.Image");
            p_supplierBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            p_supplierBUTTON.Location = new Point(12, 623);
            p_supplierBUTTON.Name = "p_supplierBUTTON";
            p_supplierBUTTON.Size = new Size(177, 74);
            p_supplierBUTTON.TabIndex = 17;
            p_supplierBUTTON.Text = "Suppliers";
            p_supplierBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            p_supplierBUTTON.UseVisualStyleBackColor = false;
            p_supplierBUTTON.Click += p_supplierBUTTON_Click;
            // 
            // p_customerBUTTON
            // 
            p_customerBUTTON.BackColor = Color.MidnightBlue;
            p_customerBUTTON.FlatStyle = FlatStyle.Flat;
            p_customerBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p_customerBUTTON.ForeColor = Color.White;
            p_customerBUTTON.Image = (Image)resources.GetObject("p_customerBUTTON.Image");
            p_customerBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            p_customerBUTTON.Location = new Point(12, 463);
            p_customerBUTTON.Name = "p_customerBUTTON";
            p_customerBUTTON.Size = new Size(177, 74);
            p_customerBUTTON.TabIndex = 15;
            p_customerBUTTON.Text = "Customers";
            p_customerBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            p_customerBUTTON.UseVisualStyleBackColor = false;
            p_customerBUTTON.Click += p_customerBUTTON_Click;
            // 
            // p_staffBUTTON
            // 
            p_staffBUTTON.BackColor = Color.MidnightBlue;
            p_staffBUTTON.FlatStyle = FlatStyle.Flat;
            p_staffBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p_staffBUTTON.ForeColor = Color.White;
            p_staffBUTTON.Image = (Image)resources.GetObject("p_staffBUTTON.Image");
            p_staffBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            p_staffBUTTON.Location = new Point(12, 543);
            p_staffBUTTON.Name = "p_staffBUTTON";
            p_staffBUTTON.Size = new Size(177, 74);
            p_staffBUTTON.TabIndex = 16;
            p_staffBUTTON.Text = "Staff";
            p_staffBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            p_staffBUTTON.UseVisualStyleBackColor = false;
            p_staffBUTTON.Click += p_staffBUTTON_Click;
            // 
            // p_logoutBUTTON
            // 
            p_logoutBUTTON.BackColor = Color.MidnightBlue;
            p_logoutBUTTON.FlatStyle = FlatStyle.Flat;
            p_logoutBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p_logoutBUTTON.ForeColor = Color.White;
            p_logoutBUTTON.Image = (Image)resources.GetObject("p_logoutBUTTON.Image");
            p_logoutBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            p_logoutBUTTON.Location = new Point(12, 774);
            p_logoutBUTTON.Name = "p_logoutBUTTON";
            p_logoutBUTTON.Size = new Size(177, 74);
            p_logoutBUTTON.TabIndex = 18;
            p_logoutBUTTON.Text = "Logout";
            p_logoutBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            p_logoutBUTTON.UseVisualStyleBackColor = false;
            p_logoutBUTTON.Click += p_logoutBUTTON_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(p_userLABEL);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 50);
            panel2.TabIndex = 2;
            // 
            // p_userLABEL
            // 
            p_userLABEL.BackColor = Color.MidnightBlue;
            p_userLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_userLABEL.ForeColor = Color.White;
            p_userLABEL.Location = new Point(436, 17);
            p_userLABEL.Name = "p_userLABEL";
            p_userLABEL.Size = new Size(792, 18);
            p_userLABEL.TabIndex = 118;
            p_userLABEL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 9);
            label7.Name = "label7";
            label7.Size = new Size(277, 26);
            label7.TabIndex = 0;
            label7.Text = "Product Management";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p_nameLABEL
            // 
            p_nameLABEL.AutoSize = true;
            p_nameLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_nameLABEL.Location = new Point(268, 104);
            p_nameLABEL.Name = "p_nameLABEL";
            p_nameLABEL.Size = new Size(59, 18);
            p_nameLABEL.TabIndex = 4;
            p_nameLABEL.Text = "Name";
            // 
            // p_priceLABEL
            // 
            p_priceLABEL.AutoSize = true;
            p_priceLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_priceLABEL.Location = new Point(268, 503);
            p_priceLABEL.Name = "p_priceLABEL";
            p_priceLABEL.Size = new Size(111, 18);
            p_priceLABEL.TabIndex = 6;
            p_priceLABEL.Text = "Price (AED)";
            // 
            // p_categoryLABEL
            // 
            p_categoryLABEL.AutoSize = true;
            p_categoryLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_categoryLABEL.Location = new Point(268, 295);
            p_categoryLABEL.Name = "p_categoryLABEL";
            p_categoryLABEL.Size = new Size(89, 18);
            p_categoryLABEL.TabIndex = 8;
            p_categoryLABEL.Text = "Category";
            // 
            // p_descriptionLABEL
            // 
            p_descriptionLABEL.AutoSize = true;
            p_descriptionLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_descriptionLABEL.Location = new Point(268, 386);
            p_descriptionLABEL.Name = "p_descriptionLABEL";
            p_descriptionLABEL.Size = new Size(106, 18);
            p_descriptionLABEL.TabIndex = 10;
            p_descriptionLABEL.Text = "Description";
            // 
            // p_stockLABEL
            // 
            p_stockLABEL.AutoSize = true;
            p_stockLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_stockLABEL.Location = new Point(268, 599);
            p_stockLABEL.Name = "p_stockLABEL";
            p_stockLABEL.Size = new Size(56, 18);
            p_stockLABEL.TabIndex = 12;
            p_stockLABEL.Text = "Stock";
            // 
            // p_supplierLABEL
            // 
            p_supplierLABEL.AutoSize = true;
            p_supplierLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_supplierLABEL.Location = new Point(268, 695);
            p_supplierLABEL.Name = "p_supplierLABEL";
            p_supplierLABEL.Size = new Size(105, 18);
            p_supplierLABEL.TabIndex = 14;
            p_supplierLABEL.Text = "Supplier ID";
            // 
            // p_categoryBOX
            // 
            p_categoryBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            p_categoryBOX.FlatStyle = FlatStyle.Flat;
            p_categoryBOX.Font = new Font("Verdana", 9F);
            p_categoryBOX.FormattingEnabled = true;
            p_categoryBOX.Items.AddRange(new object[] { "smartphones & mobile devices", "computers & laptops", "audio & headphones", "cameras & photography", "televisions & home entertainment", "gaming & accessories", "wearable technologies", "home appliances", "networking & accessories", "computer components & parts", "accessories and gadgets", "office electronics", "other" });
            p_categoryBOX.Location = new Point(268, 316);
            p_categoryBOX.Name = "p_categoryBOX";
            p_categoryBOX.Size = new Size(312, 22);
            p_categoryBOX.TabIndex = 3;
            // 
            // p_supplierBOX
            // 
            p_supplierBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            p_supplierBOX.FlatStyle = FlatStyle.Flat;
            p_supplierBOX.Font = new Font("Verdana", 9F);
            p_supplierBOX.Location = new Point(268, 718);
            p_supplierBOX.Name = "p_supplierBOX";
            p_supplierBOX.Size = new Size(312, 22);
            p_supplierBOX.TabIndex = 7;
            // 
            // p_addBUTTON
            // 
            p_addBUTTON.BackColor = Color.Goldenrod;
            p_addBUTTON.FlatStyle = FlatStyle.Flat;
            p_addBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_addBUTTON.ForeColor = Color.White;
            p_addBUTTON.Location = new Point(268, 774);
            p_addBUTTON.Name = "p_addBUTTON";
            p_addBUTTON.Size = new Size(127, 30);
            p_addBUTTON.TabIndex = 8;
            p_addBUTTON.Text = "Add Product";
            p_addBUTTON.UseVisualStyleBackColor = false;
            p_addBUTTON.Click += p_addBUTTON_Click;
            // 
            // p_updateBUTTON
            // 
            p_updateBUTTON.BackColor = Color.MidnightBlue;
            p_updateBUTTON.FlatStyle = FlatStyle.Flat;
            p_updateBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_updateBUTTON.ForeColor = Color.White;
            p_updateBUTTON.Location = new Point(742, 774);
            p_updateBUTTON.Name = "p_updateBUTTON";
            p_updateBUTTON.Size = new Size(100, 30);
            p_updateBUTTON.TabIndex = 11;
            p_updateBUTTON.Text = "Update";
            p_updateBUTTON.UseVisualStyleBackColor = false;
            p_updateBUTTON.Click += p_updateBUTTON_Click;
            // 
            // p_deleteBUTTON
            // 
            p_deleteBUTTON.BackColor = Color.DarkRed;
            p_deleteBUTTON.FlatStyle = FlatStyle.Flat;
            p_deleteBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_deleteBUTTON.ForeColor = Color.White;
            p_deleteBUTTON.Location = new Point(1328, 774);
            p_deleteBUTTON.Name = "p_deleteBUTTON";
            p_deleteBUTTON.Size = new Size(100, 30);
            p_deleteBUTTON.TabIndex = 13;
            p_deleteBUTTON.Text = "Delete";
            p_deleteBUTTON.UseVisualStyleBackColor = false;
            p_deleteBUTTON.Click += p_deleteBUTTON_Click;
            // 
            // p_nameBOX
            // 
            p_nameBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_nameBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p_nameBOX.Location = new Point(268, 125);
            p_nameBOX.Name = "p_nameBOX";
            p_nameBOX.Size = new Size(312, 22);
            p_nameBOX.TabIndex = 1;
            // 
            // p_descriptionBOX
            // 
            p_descriptionBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_descriptionBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p_descriptionBOX.Location = new Point(269, 407);
            p_descriptionBOX.Multiline = true;
            p_descriptionBOX.Name = "p_descriptionBOX";
            p_descriptionBOX.Size = new Size(312, 50);
            p_descriptionBOX.TabIndex = 4;
            // 
            // p_priceBOX
            // 
            p_priceBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_priceBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p_priceBOX.Location = new Point(268, 524);
            p_priceBOX.Name = "p_priceBOX";
            p_priceBOX.Size = new Size(312, 22);
            p_priceBOX.TabIndex = 5;
            // 
            // p_stockBOX
            // 
            p_stockBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_stockBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p_stockBOX.Location = new Point(268, 620);
            p_stockBOX.Name = "p_stockBOX";
            p_stockBOX.Size = new Size(312, 22);
            p_stockBOX.TabIndex = 6;
            // 
            // p_refreshBUTON
            // 
            p_refreshBUTON.BackColor = Color.MidnightBlue;
            p_refreshBUTON.FlatStyle = FlatStyle.Flat;
            p_refreshBUTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_refreshBUTON.ForeColor = Color.White;
            p_refreshBUTON.Location = new Point(636, 774);
            p_refreshBUTON.Name = "p_refreshBUTON";
            p_refreshBUTON.Size = new Size(100, 30);
            p_refreshBUTON.TabIndex = 10;
            p_refreshBUTON.Text = "Refresh";
            p_refreshBUTON.UseVisualStyleBackColor = false;
            p_refreshBUTON.Click += p_refreshBUTON_Click;
            // 
            // p_clearBUTTON
            // 
            p_clearBUTTON.BackColor = Color.MidnightBlue;
            p_clearBUTTON.FlatStyle = FlatStyle.Flat;
            p_clearBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_clearBUTTON.ForeColor = Color.White;
            p_clearBUTTON.Location = new Point(480, 774);
            p_clearBUTTON.Name = "p_clearBUTTON";
            p_clearBUTTON.Size = new Size(100, 30);
            p_clearBUTTON.TabIndex = 9;
            p_clearBUTTON.Text = "Clear";
            p_clearBUTTON.UseVisualStyleBackColor = false;
            p_clearBUTTON.Click += p_clearBUTTON_Click;
            // 
            // p_LIST
            // 
            p_LIST.AllowUserToAddRows = false;
            p_LIST.AllowUserToDeleteRows = false;
            p_LIST.AllowUserToResizeColumns = false;
            p_LIST.AllowUserToResizeRows = false;
            p_LIST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            p_LIST.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            p_LIST.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            p_LIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            p_LIST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            p_LIST.Columns.AddRange(new DataGridViewColumn[] { image, image_link, id, name, category, description, price, stock, supplier_id, supplier_name });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            p_LIST.DefaultCellStyle = dataGridViewCellStyle9;
            p_LIST.Location = new Point(636, 104);
            p_LIST.MultiSelect = false;
            p_LIST.Name = "p_LIST";
            p_LIST.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            p_LIST.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            p_LIST.RowHeadersVisible = false;
            p_LIST.RowHeadersWidth = 82;
            p_LIST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            p_LIST.ShowEditingIcon = false;
            p_LIST.Size = new Size(792, 664);
            p_LIST.TabIndex = 100;
            p_LIST.TabStop = false;
            p_LIST.SelectionChanged += p_LIST_SelectionChanged;
            // 
            // image
            // 
            image.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            image.DataPropertyName = "image";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            image.DefaultCellStyle = dataGridViewCellStyle2;
            image.Description = "image";
            image.FillWeight = 133.333313F;
            image.HeaderText = "image";
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            image.MinimumWidth = 100;
            image.Name = "image";
            image.ReadOnly = true;
            image.Resizable = DataGridViewTriState.True;
            // 
            // image_link
            // 
            image_link.DataPropertyName = "image_link";
            image_link.HeaderText = "image_link";
            image_link.Name = "image_link";
            image_link.ReadOnly = true;
            image_link.Resizable = DataGridViewTriState.False;
            image_link.Visible = false;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            id.DefaultCellStyle = dataGridViewCellStyle3;
            id.FillWeight = 93.33336F;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            name.DataPropertyName = "name";
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            name.DefaultCellStyle = dataGridViewCellStyle4;
            name.HeaderText = "name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.False;
            name.Width = 68;
            // 
            // category
            // 
            category.DataPropertyName = "category";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            category.DefaultCellStyle = dataGridViewCellStyle5;
            category.FillWeight = 93.33336F;
            category.HeaderText = "category";
            category.Name = "category";
            category.ReadOnly = true;
            category.Resizable = DataGridViewTriState.False;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.HeaderText = "description";
            description.Name = "description";
            description.ReadOnly = true;
            description.Resizable = DataGridViewTriState.False;
            description.Visible = false;
            // 
            // price
            // 
            price.DataPropertyName = "price";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            price.DefaultCellStyle = dataGridViewCellStyle6;
            price.FillWeight = 93.33336F;
            price.HeaderText = "price (AED)";
            price.Name = "price";
            price.ReadOnly = true;
            price.Resizable = DataGridViewTriState.False;
            // 
            // stock
            // 
            stock.DataPropertyName = "stock";
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            stock.DefaultCellStyle = dataGridViewCellStyle7;
            stock.FillWeight = 93.33336F;
            stock.HeaderText = "stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Resizable = DataGridViewTriState.False;
            // 
            // supplier_id
            // 
            supplier_id.DataPropertyName = "supplier_id";
            supplier_id.HeaderText = "supplier_id";
            supplier_id.Name = "supplier_id";
            supplier_id.ReadOnly = true;
            supplier_id.Resizable = DataGridViewTriState.False;
            supplier_id.Visible = false;
            // 
            // supplier_name
            // 
            supplier_name.DataPropertyName = "supplier_name";
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            supplier_name.DefaultCellStyle = dataGridViewCellStyle8;
            supplier_name.FillWeight = 93.33336F;
            supplier_name.HeaderText = "supplier";
            supplier_name.Name = "supplier_name";
            supplier_name.ReadOnly = true;
            supplier_name.Resizable = DataGridViewTriState.False;
            // 
            // p_searchBOX
            // 
            p_searchBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_searchBOX.BackColor = SystemColors.Window;
            p_searchBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p_searchBOX.ForeColor = Color.Black;
            p_searchBOX.Location = new Point(996, 774);
            p_searchBOX.Name = "p_searchBOX";
            p_searchBOX.PlaceholderText = "Search";
            p_searchBOX.Size = new Size(186, 22);
            p_searchBOX.TabIndex = 12;
            p_searchBOX.TextChanged += p_searchBOX_TextChanged;
            // 
            // p_imageBOX
            // 
            p_imageBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_imageBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p_imageBOX.Location = new Point(268, 220);
            p_imageBOX.Name = "p_imageBOX";
            p_imageBOX.Size = new Size(195, 22);
            p_imageBOX.TabIndex = 101;
            p_imageBOX.TabStop = false;
            // 
            // p_imageLABEL
            // 
            p_imageLABEL.AutoSize = true;
            p_imageLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            p_imageLABEL.Location = new Point(268, 199);
            p_imageLABEL.Name = "p_imageLABEL";
            p_imageLABEL.Size = new Size(65, 18);
            p_imageLABEL.TabIndex = 102;
            p_imageLABEL.Text = "Image";
            // 
            // p_uploadBUTTON
            // 
            p_uploadBUTTON.BackColor = Color.MidnightBlue;
            p_uploadBUTTON.FlatStyle = FlatStyle.Flat;
            p_uploadBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold);
            p_uploadBUTTON.ForeColor = Color.White;
            p_uploadBUTTON.Location = new Point(469, 220);
            p_uploadBUTTON.Name = "p_uploadBUTTON";
            p_uploadBUTTON.Size = new Size(111, 25);
            p_uploadBUTTON.TabIndex = 2;
            p_uploadBUTTON.Text = "Upload Image";
            p_uploadBUTTON.UseVisualStyleBackColor = false;
            p_uploadBUTTON.Click += p_uploadBUTTON_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1500, 860);
            Controls.Add(p_uploadBUTTON);
            Controls.Add(p_imageLABEL);
            Controls.Add(p_imageBOX);
            Controls.Add(p_searchBOX);
            Controls.Add(p_LIST);
            Controls.Add(p_clearBUTTON);
            Controls.Add(p_refreshBUTON);
            Controls.Add(p_stockBOX);
            Controls.Add(p_priceBOX);
            Controls.Add(p_descriptionBOX);
            Controls.Add(p_nameBOX);
            Controls.Add(p_deleteBUTTON);
            Controls.Add(p_updateBUTTON);
            Controls.Add(p_addBUTTON);
            Controls.Add(p_supplierBOX);
            Controls.Add(p_categoryBOX);
            Controls.Add(p_supplierLABEL);
            Controls.Add(p_stockLABEL);
            Controls.Add(p_descriptionLABEL);
            Controls.Add(p_categoryLABEL);
            Controls.Add(p_priceLABEL);
            Controls.Add(p_nameLABEL);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CircuitCentral";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)p_LIST).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button p_logoutBUTTON;
        private Button p_staffBUTTON;
        private Button p_customerBUTTON;
        private Button p_productBUTTON;
        private Button p_orderBUTTON;
        private Button p_supplierBUTTON;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label7;
        private ComboBox p_categoryBOX;
        private ComboBox p_supplierBOX;
        private Button p_addBUTTON;
        private Button p_updateBUTTON;
        private Button p_deleteBUTTON;
        private TextBox p_nameBOX;
        private TextBox p_descriptionBOX;
        private TextBox p_priceBOX;
        private TextBox p_stockBOX;
        private Button p_refreshBUTON;
        private Button p_clearBUTTON;
        private DataGridView p_LIST;
        private TextBox p_searchBOX;
        private TextBox p_imageBOX;
        private Button p_uploadBUTTON;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn image_link;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn supplier_id;
        private DataGridViewTextBoxColumn supplier_name;
        private Label p_nameLABEL;
        private Label p_priceLABEL;
        private Label p_categoryLABEL;
        private Label p_descriptionLABEL;
        private Label p_stockLABEL;
        private Label p_supplierLABEL;
        private Label p_imageLABEL;
        private Label p_userLABEL;
    }
}