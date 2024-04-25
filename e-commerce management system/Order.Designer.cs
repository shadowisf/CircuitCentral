using System.Windows.Forms;

namespace e_commerce_management_system
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            o_deleteBUTTON = new Button();
            o_updateBUTTON = new Button();
            label7 = new Label();
            panel2 = new Panel();
            o_userLABEL = new Label();
            label3 = new Label();
            o_modeBOX = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            o_productBUTTON = new Button();
            o_orderBUTTON = new Button();
            o_supplierBUTTON = new Button();
            o_customerBUTTON = new Button();
            o_staffBUTTON = new Button();
            o_logoutBUTTON = new Button();
            panel1 = new Panel();
            o_customerLABEL = new Label();
            o_customerBOX = new ComboBox();
            o_dateBOX = new DateTimePicker();
            o_dateLABEL = new Label();
            o_orderstatusBOX = new ComboBox();
            o_orderstatusLABEL = new Label();
            o_LIST = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            products = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            payment_method = new DataGridViewTextBoxColumn();
            transaction_status = new DataGridViewTextBoxColumn();
            order_status = new DataGridViewTextBoxColumn();
            customer_id = new DataGridViewTextBoxColumn();
            transaction_id = new DataGridViewTextBoxColumn();
            o_refreshBUTTON = new Button();
            o_addproductBUTTON = new Button();
            o_clearBUTTON = new Button();
            o_createBUTTON = new Button();
            o_productLIST = new DataGridView();
            p_image = new DataGridViewImageColumn();
            p_id = new DataGridViewTextBoxColumn();
            p_name = new DataGridViewTextBoxColumn();
            p_price = new DataGridViewTextBoxColumn();
            p_image_link = new DataGridViewTextBoxColumn();
            o_cartLIST = new DataGridView();
            c_id = new DataGridViewTextBoxColumn();
            c_name = new DataGridViewTextBoxColumn();
            c_unit_price = new DataGridViewTextBoxColumn();
            c_quantity = new DataGridViewTextBoxColumn();
            o_productLABEL = new Label();
            o_cartLABEL = new Label();
            o_paymentBOX = new ComboBox();
            o_paymentLABEL = new Label();
            o_searchorderBOX = new TextBox();
            o_transactionLABEL = new Label();
            o_transactionstatusBOX = new ComboBox();
            o_searchproductBOX = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)o_LIST).BeginInit();
            ((System.ComponentModel.ISupportInitialize)o_productLIST).BeginInit();
            ((System.ComponentModel.ISupportInitialize)o_cartLIST).BeginInit();
            SuspendLayout();
            // 
            // o_deleteBUTTON
            // 
            o_deleteBUTTON.BackColor = Color.DarkRed;
            o_deleteBUTTON.FlatStyle = FlatStyle.Flat;
            o_deleteBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_deleteBUTTON.ForeColor = Color.White;
            o_deleteBUTTON.Location = new Point(1328, 774);
            o_deleteBUTTON.Name = "o_deleteBUTTON";
            o_deleteBUTTON.Size = new Size(100, 30);
            o_deleteBUTTON.TabIndex = 14;
            o_deleteBUTTON.Text = "Delete";
            o_deleteBUTTON.UseVisualStyleBackColor = false;
            o_deleteBUTTON.Click += o_deleteBUTTON_Click;
            // 
            // o_updateBUTTON
            // 
            o_updateBUTTON.BackColor = Color.MidnightBlue;
            o_updateBUTTON.FlatStyle = FlatStyle.Flat;
            o_updateBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_updateBUTTON.ForeColor = Color.White;
            o_updateBUTTON.Location = new Point(742, 774);
            o_updateBUTTON.Name = "o_updateBUTTON";
            o_updateBUTTON.Size = new Size(100, 30);
            o_updateBUTTON.TabIndex = 10;
            o_updateBUTTON.Text = "Update";
            o_updateBUTTON.UseVisualStyleBackColor = false;
            o_updateBUTTON.Click += o_updateBUTTON_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 9);
            label7.Name = "label7";
            label7.Size = new Size(252, 26);
            label7.TabIndex = 0;
            label7.Text = "Order Management";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(o_userLABEL);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(o_modeBOX);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 50);
            panel2.TabIndex = 26;
            // 
            // o_userLABEL
            // 
            o_userLABEL.BackColor = Color.MidnightBlue;
            o_userLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_userLABEL.ForeColor = Color.White;
            o_userLABEL.Location = new Point(721, 17);
            o_userLABEL.Name = "o_userLABEL";
            o_userLABEL.Size = new Size(507, 18);
            o_userLABEL.TabIndex = 117;
            o_userLABEL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(436, 16);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 113;
            label3.Text = "Mode:";
            // 
            // o_modeBOX
            // 
            o_modeBOX.BackColor = Color.White;
            o_modeBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            o_modeBOX.FlatStyle = FlatStyle.Flat;
            o_modeBOX.Font = new Font("Verdana", 9F);
            o_modeBOX.FormattingEnabled = true;
            o_modeBOX.Items.AddRange(new object[] { "create orders", "manage orders" });
            o_modeBOX.Location = new Point(504, 13);
            o_modeBOX.Name = "o_modeBOX";
            o_modeBOX.Size = new Size(187, 22);
            o_modeBOX.TabIndex = 1;
            o_modeBOX.SelectedIndexChanged += o_modeBOX_SelectionIndexChanged;
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
            // o_productBUTTON
            // 
            o_productBUTTON.BackColor = Color.MidnightBlue;
            o_productBUTTON.FlatStyle = FlatStyle.Flat;
            o_productBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_productBUTTON.ForeColor = Color.White;
            o_productBUTTON.Image = (Image)resources.GetObject("o_productBUTTON.Image");
            o_productBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            o_productBUTTON.Location = new Point(12, 307);
            o_productBUTTON.Name = "o_productBUTTON";
            o_productBUTTON.Size = new Size(177, 74);
            o_productBUTTON.TabIndex = 15;
            o_productBUTTON.Text = "Products";
            o_productBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            o_productBUTTON.UseVisualStyleBackColor = false;
            o_productBUTTON.Click += o_productBUTTON_Click;
            // 
            // o_orderBUTTON
            // 
            o_orderBUTTON.BackColor = Color.DodgerBlue;
            o_orderBUTTON.FlatStyle = FlatStyle.Flat;
            o_orderBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_orderBUTTON.ForeColor = Color.White;
            o_orderBUTTON.Image = (Image)resources.GetObject("o_orderBUTTON.Image");
            o_orderBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            o_orderBUTTON.Location = new Point(12, 227);
            o_orderBUTTON.Name = "o_orderBUTTON";
            o_orderBUTTON.Size = new Size(177, 74);
            o_orderBUTTON.TabIndex = 100;
            o_orderBUTTON.TabStop = false;
            o_orderBUTTON.Text = "Orders";
            o_orderBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            o_orderBUTTON.UseVisualStyleBackColor = false;
            // 
            // o_supplierBUTTON
            // 
            o_supplierBUTTON.BackColor = Color.MidnightBlue;
            o_supplierBUTTON.FlatStyle = FlatStyle.Flat;
            o_supplierBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_supplierBUTTON.ForeColor = Color.White;
            o_supplierBUTTON.Image = (Image)resources.GetObject("o_supplierBUTTON.Image");
            o_supplierBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            o_supplierBUTTON.Location = new Point(12, 623);
            o_supplierBUTTON.Name = "o_supplierBUTTON";
            o_supplierBUTTON.Size = new Size(177, 74);
            o_supplierBUTTON.TabIndex = 18;
            o_supplierBUTTON.Text = "Suppliers";
            o_supplierBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            o_supplierBUTTON.UseVisualStyleBackColor = false;
            // 
            // o_customerBUTTON
            // 
            o_customerBUTTON.BackColor = Color.MidnightBlue;
            o_customerBUTTON.FlatStyle = FlatStyle.Flat;
            o_customerBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_customerBUTTON.ForeColor = Color.White;
            o_customerBUTTON.Image = (Image)resources.GetObject("o_customerBUTTON.Image");
            o_customerBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            o_customerBUTTON.Location = new Point(12, 463);
            o_customerBUTTON.Name = "o_customerBUTTON";
            o_customerBUTTON.Size = new Size(177, 74);
            o_customerBUTTON.TabIndex = 16;
            o_customerBUTTON.Text = "Customers";
            o_customerBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            o_customerBUTTON.UseVisualStyleBackColor = false;
            o_customerBUTTON.Click += o_customerBUTTON_Click;
            // 
            // o_staffBUTTON
            // 
            o_staffBUTTON.BackColor = Color.MidnightBlue;
            o_staffBUTTON.FlatStyle = FlatStyle.Flat;
            o_staffBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_staffBUTTON.ForeColor = Color.White;
            o_staffBUTTON.Image = (Image)resources.GetObject("o_staffBUTTON.Image");
            o_staffBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            o_staffBUTTON.Location = new Point(12, 543);
            o_staffBUTTON.Name = "o_staffBUTTON";
            o_staffBUTTON.Size = new Size(177, 74);
            o_staffBUTTON.TabIndex = 17;
            o_staffBUTTON.Text = "Staff";
            o_staffBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            o_staffBUTTON.UseVisualStyleBackColor = false;
            o_staffBUTTON.Click += o_staffBUTTON_Click;
            // 
            // o_logoutBUTTON
            // 
            o_logoutBUTTON.BackColor = Color.MidnightBlue;
            o_logoutBUTTON.FlatStyle = FlatStyle.Flat;
            o_logoutBUTTON.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_logoutBUTTON.ForeColor = Color.White;
            o_logoutBUTTON.Image = (Image)resources.GetObject("o_logoutBUTTON.Image");
            o_logoutBUTTON.ImageAlign = ContentAlignment.MiddleRight;
            o_logoutBUTTON.Location = new Point(12, 774);
            o_logoutBUTTON.Name = "o_logoutBUTTON";
            o_logoutBUTTON.Size = new Size(177, 74);
            o_logoutBUTTON.TabIndex = 19;
            o_logoutBUTTON.Text = "Logout";
            o_logoutBUTTON.TextImageRelation = TextImageRelation.ImageBeforeText;
            o_logoutBUTTON.UseVisualStyleBackColor = false;
            o_logoutBUTTON.Click += o_logoutBUTTON_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(o_productBUTTON);
            panel1.Controls.Add(o_orderBUTTON);
            panel1.Controls.Add(o_supplierBUTTON);
            panel1.Controls.Add(o_customerBUTTON);
            panel1.Controls.Add(o_staffBUTTON);
            panel1.Controls.Add(o_logoutBUTTON);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 860);
            panel1.TabIndex = 25;
            // 
            // o_customerLABEL
            // 
            o_customerLABEL.AutoSize = true;
            o_customerLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_customerLABEL.Location = new Point(268, 104);
            o_customerLABEL.Name = "o_customerLABEL";
            o_customerLABEL.Size = new Size(119, 18);
            o_customerLABEL.TabIndex = 40;
            o_customerLABEL.Text = "Customer ID";
            // 
            // o_customerBOX
            // 
            o_customerBOX.BackColor = Color.White;
            o_customerBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            o_customerBOX.FlatStyle = FlatStyle.Flat;
            o_customerBOX.Font = new Font("Verdana", 9F);
            o_customerBOX.FormattingEnabled = true;
            o_customerBOX.Location = new Point(268, 125);
            o_customerBOX.Name = "o_customerBOX";
            o_customerBOX.Size = new Size(312, 22);
            o_customerBOX.TabIndex = 1;
            // 
            // o_dateBOX
            // 
            o_dateBOX.CalendarFont = new Font("Verdana", 9F);
            o_dateBOX.Font = new Font("Verdana", 9F);
            o_dateBOX.Format = DateTimePickerFormat.Short;
            o_dateBOX.Location = new Point(268, 259);
            o_dateBOX.Name = "o_dateBOX";
            o_dateBOX.Size = new Size(312, 22);
            o_dateBOX.TabIndex = 3;
            // 
            // o_dateLABEL
            // 
            o_dateLABEL.AutoSize = true;
            o_dateLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_dateLABEL.Location = new Point(265, 238);
            o_dateLABEL.Name = "o_dateLABEL";
            o_dateLABEL.Size = new Size(50, 18);
            o_dateLABEL.TabIndex = 43;
            o_dateLABEL.Text = "Date";
            // 
            // o_orderstatusBOX
            // 
            o_orderstatusBOX.BackColor = Color.White;
            o_orderstatusBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            o_orderstatusBOX.FlatStyle = FlatStyle.Flat;
            o_orderstatusBOX.Font = new Font("Verdana", 9F);
            o_orderstatusBOX.FormattingEnabled = true;
            o_orderstatusBOX.Items.AddRange(new object[] { "pending", "dispatched", "delivered", "cancelled", "COMPLETED" });
            o_orderstatusBOX.Location = new Point(271, 564);
            o_orderstatusBOX.Name = "o_orderstatusBOX";
            o_orderstatusBOX.Size = new Size(312, 22);
            o_orderstatusBOX.TabIndex = 5;
            // 
            // o_orderstatusLABEL
            // 
            o_orderstatusLABEL.AutoSize = true;
            o_orderstatusLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_orderstatusLABEL.Location = new Point(268, 543);
            o_orderstatusLABEL.Name = "o_orderstatusLABEL";
            o_orderstatusLABEL.Size = new Size(121, 18);
            o_orderstatusLABEL.TabIndex = 45;
            o_orderstatusLABEL.Text = "Order Status";
            // 
            // o_LIST
            // 
            o_LIST.AllowUserToAddRows = false;
            o_LIST.AllowUserToDeleteRows = false;
            o_LIST.AllowUserToResizeColumns = false;
            o_LIST.AllowUserToResizeRows = false;
            o_LIST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            o_LIST.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            o_LIST.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            o_LIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            o_LIST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            o_LIST.Columns.AddRange(new DataGridViewColumn[] { id, customer, products, date, total_amount, payment_method, transaction_status, order_status, customer_id, transaction_id });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            o_LIST.DefaultCellStyle = dataGridViewCellStyle12;
            o_LIST.Location = new Point(636, 104);
            o_LIST.MultiSelect = false;
            o_LIST.Name = "o_LIST";
            o_LIST.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            o_LIST.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            o_LIST.RowHeadersVisible = false;
            o_LIST.RowHeadersWidth = 82;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            o_LIST.RowsDefaultCellStyle = dataGridViewCellStyle14;
            o_LIST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            o_LIST.ShowEditingIcon = false;
            o_LIST.Size = new Size(792, 664);
            o_LIST.TabIndex = 101;
            o_LIST.TabStop = false;
            o_LIST.SelectionChanged += o_LIST_SelectionChanged;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            id.DataPropertyName = "id";
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            id.DefaultCellStyle = dataGridViewCellStyle2;
            id.FillWeight = 81.21826F;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            id.Width = 80;
            // 
            // customer
            // 
            customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer.DataPropertyName = "customer";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            customer.DefaultCellStyle = dataGridViewCellStyle3;
            customer.FillWeight = 102.683105F;
            customer.HeaderText = "customer";
            customer.Name = "customer";
            customer.ReadOnly = true;
            // 
            // products
            // 
            products.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            products.DataPropertyName = "products";
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            products.DefaultCellStyle = dataGridViewCellStyle4;
            products.FillWeight = 102.683105F;
            products.HeaderText = "products";
            products.Name = "products";
            products.ReadOnly = true;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            date.DataPropertyName = "date";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            date.DefaultCellStyle = dataGridViewCellStyle5;
            date.FillWeight = 102.683105F;
            date.HeaderText = "date";
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 101;
            // 
            // total_amount
            // 
            total_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            total_amount.DataPropertyName = "total_amount";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            total_amount.DefaultCellStyle = dataGridViewCellStyle6;
            total_amount.FillWeight = 102.683105F;
            total_amount.HeaderText = "total amount (AED)";
            total_amount.Name = "total_amount";
            total_amount.ReadOnly = true;
            total_amount.Width = 101;
            // 
            // payment_method
            // 
            payment_method.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            payment_method.DataPropertyName = "payment_method";
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            payment_method.DefaultCellStyle = dataGridViewCellStyle7;
            payment_method.FillWeight = 102.683105F;
            payment_method.HeaderText = "payment method";
            payment_method.Name = "payment_method";
            payment_method.ReadOnly = true;
            payment_method.Width = 101;
            // 
            // transaction_status
            // 
            transaction_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            transaction_status.DataPropertyName = "transaction_status";
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            transaction_status.DefaultCellStyle = dataGridViewCellStyle8;
            transaction_status.FillWeight = 102.683105F;
            transaction_status.HeaderText = "transaction status";
            transaction_status.Name = "transaction_status";
            transaction_status.ReadOnly = true;
            transaction_status.Width = 102;
            // 
            // order_status
            // 
            order_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            order_status.DataPropertyName = "order_status";
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            order_status.DefaultCellStyle = dataGridViewCellStyle9;
            order_status.FillWeight = 102.683105F;
            order_status.HeaderText = "order status";
            order_status.Name = "order_status";
            order_status.ReadOnly = true;
            order_status.Width = 101;
            // 
            // customer_id
            // 
            customer_id.DataPropertyName = "customer_id";
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            customer_id.DefaultCellStyle = dataGridViewCellStyle10;
            customer_id.HeaderText = "customer_id";
            customer_id.Name = "customer_id";
            customer_id.ReadOnly = true;
            customer_id.Visible = false;
            // 
            // transaction_id
            // 
            transaction_id.DataPropertyName = "transaction_id";
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            transaction_id.DefaultCellStyle = dataGridViewCellStyle11;
            transaction_id.HeaderText = "transaction_id";
            transaction_id.Name = "transaction_id";
            transaction_id.ReadOnly = true;
            transaction_id.Visible = false;
            // 
            // o_refreshBUTTON
            // 
            o_refreshBUTTON.BackColor = Color.MidnightBlue;
            o_refreshBUTTON.FlatStyle = FlatStyle.Flat;
            o_refreshBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_refreshBUTTON.ForeColor = Color.White;
            o_refreshBUTTON.Location = new Point(636, 774);
            o_refreshBUTTON.Name = "o_refreshBUTTON";
            o_refreshBUTTON.Size = new Size(100, 30);
            o_refreshBUTTON.TabIndex = 9;
            o_refreshBUTTON.Text = "Refresh";
            o_refreshBUTTON.UseVisualStyleBackColor = false;
            o_refreshBUTTON.Click += o_refreshBUTTON_Click;
            // 
            // o_addproductBUTTON
            // 
            o_addproductBUTTON.BackColor = Color.MidnightBlue;
            o_addproductBUTTON.FlatStyle = FlatStyle.Flat;
            o_addproductBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_addproductBUTTON.ForeColor = Color.White;
            o_addproductBUTTON.Location = new Point(742, 774);
            o_addproductBUTTON.Name = "o_addproductBUTTON";
            o_addproductBUTTON.Size = new Size(118, 30);
            o_addproductBUTTON.TabIndex = 11;
            o_addproductBUTTON.Text = "Add to Cart";
            o_addproductBUTTON.UseVisualStyleBackColor = false;
            o_addproductBUTTON.Click += o_addproductBUTTON_Click;
            // 
            // o_clearBUTTON
            // 
            o_clearBUTTON.BackColor = Color.MidnightBlue;
            o_clearBUTTON.FlatStyle = FlatStyle.Flat;
            o_clearBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_clearBUTTON.ForeColor = Color.White;
            o_clearBUTTON.Location = new Point(480, 774);
            o_clearBUTTON.Name = "o_clearBUTTON";
            o_clearBUTTON.Size = new Size(100, 30);
            o_clearBUTTON.TabIndex = 8;
            o_clearBUTTON.Text = "Clear";
            o_clearBUTTON.UseVisualStyleBackColor = false;
            o_clearBUTTON.Click += o_clearBUTTON_Click;
            // 
            // o_createBUTTON
            // 
            o_createBUTTON.BackColor = Color.Goldenrod;
            o_createBUTTON.FlatStyle = FlatStyle.Flat;
            o_createBUTTON.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_createBUTTON.ForeColor = Color.White;
            o_createBUTTON.Location = new Point(268, 774);
            o_createBUTTON.Name = "o_createBUTTON";
            o_createBUTTON.Size = new Size(118, 30);
            o_createBUTTON.TabIndex = 7;
            o_createBUTTON.Text = "Add Order";
            o_createBUTTON.UseVisualStyleBackColor = false;
            o_createBUTTON.Click += o_createBUTTON_Click;
            // 
            // o_productLIST
            // 
            o_productLIST.AllowUserToAddRows = false;
            o_productLIST.AllowUserToDeleteRows = false;
            o_productLIST.AllowUserToResizeColumns = false;
            o_productLIST.AllowUserToResizeRows = false;
            o_productLIST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            o_productLIST.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            o_productLIST.BackgroundColor = Color.White;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            o_productLIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            o_productLIST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            o_productLIST.Columns.AddRange(new DataGridViewColumn[] { p_image, p_id, p_name, p_price, p_image_link });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            o_productLIST.DefaultCellStyle = dataGridViewCellStyle18;
            o_productLIST.Location = new Point(636, 125);
            o_productLIST.MultiSelect = false;
            o_productLIST.Name = "o_productLIST";
            o_productLIST.ReadOnly = true;
            o_productLIST.RowHeadersVisible = false;
            o_productLIST.RowHeadersWidth = 82;
            o_productLIST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            o_productLIST.ShowEditingIcon = false;
            o_productLIST.Size = new Size(418, 643);
            o_productLIST.TabIndex = 106;
            o_productLIST.TabStop = false;
            // 
            // p_image
            // 
            p_image.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            p_image.DataPropertyName = "image";
            p_image.HeaderText = "image";
            p_image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            p_image.MinimumWidth = 100;
            p_image.Name = "p_image";
            p_image.ReadOnly = true;
            p_image.Resizable = DataGridViewTriState.False;
            // 
            // p_id
            // 
            p_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            p_id.DataPropertyName = "id";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            p_id.DefaultCellStyle = dataGridViewCellStyle16;
            p_id.HeaderText = "id";
            p_id.Name = "p_id";
            p_id.ReadOnly = true;
            p_id.Resizable = DataGridViewTriState.False;
            p_id.Width = 44;
            // 
            // p_name
            // 
            p_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            p_name.DataPropertyName = "name";
            p_name.HeaderText = "name";
            p_name.Name = "p_name";
            p_name.ReadOnly = true;
            p_name.Resizable = DataGridViewTriState.False;
            // 
            // p_price
            // 
            p_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            p_price.DataPropertyName = "price";
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            p_price.DefaultCellStyle = dataGridViewCellStyle17;
            p_price.HeaderText = "unit price (AED)";
            p_price.Name = "p_price";
            p_price.ReadOnly = true;
            p_price.Resizable = DataGridViewTriState.False;
            p_price.Width = 127;
            // 
            // p_image_link
            // 
            p_image_link.DataPropertyName = "image_link";
            p_image_link.HeaderText = "image_link";
            p_image_link.Name = "p_image_link";
            p_image_link.ReadOnly = true;
            p_image_link.Resizable = DataGridViewTriState.False;
            p_image_link.Visible = false;
            // 
            // o_cartLIST
            // 
            o_cartLIST.AllowUserToAddRows = false;
            o_cartLIST.AllowUserToDeleteRows = false;
            o_cartLIST.AllowUserToResizeColumns = false;
            o_cartLIST.AllowUserToResizeRows = false;
            o_cartLIST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            o_cartLIST.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            o_cartLIST.BackgroundColor = Color.White;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Verdana", 9F, FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            o_cartLIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            o_cartLIST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            o_cartLIST.Columns.AddRange(new DataGridViewColumn[] { c_id, c_name, c_unit_price, c_quantity });
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Window;
            dataGridViewCellStyle22.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            o_cartLIST.DefaultCellStyle = dataGridViewCellStyle22;
            o_cartLIST.Location = new Point(1060, 125);
            o_cartLIST.MultiSelect = false;
            o_cartLIST.Name = "o_cartLIST";
            o_cartLIST.ReadOnly = true;
            o_cartLIST.RowHeadersVisible = false;
            o_cartLIST.RowHeadersWidth = 82;
            o_cartLIST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            o_cartLIST.ShowEditingIcon = false;
            o_cartLIST.Size = new Size(368, 643);
            o_cartLIST.TabIndex = 107;
            o_cartLIST.TabStop = false;
            // 
            // c_id
            // 
            c_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle20.Font = new Font("Verdana", 9F, FontStyle.Bold);
            c_id.DefaultCellStyle = dataGridViewCellStyle20;
            c_id.HeaderText = "id";
            c_id.Name = "c_id";
            c_id.ReadOnly = true;
            c_id.Resizable = DataGridViewTriState.False;
            c_id.Width = 44;
            // 
            // c_name
            // 
            c_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c_name.HeaderText = "name";
            c_name.Name = "c_name";
            c_name.ReadOnly = true;
            c_name.Resizable = DataGridViewTriState.False;
            // 
            // c_unit_price
            // 
            c_unit_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            c_unit_price.DefaultCellStyle = dataGridViewCellStyle21;
            c_unit_price.HeaderText = "unit price (AED)";
            c_unit_price.Name = "c_unit_price";
            c_unit_price.ReadOnly = true;
            c_unit_price.Resizable = DataGridViewTriState.False;
            c_unit_price.Width = 127;
            // 
            // c_quantity
            // 
            c_quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            c_quantity.HeaderText = "quantity";
            c_quantity.Name = "c_quantity";
            c_quantity.ReadOnly = true;
            c_quantity.Resizable = DataGridViewTriState.False;
            c_quantity.Width = 86;
            // 
            // o_productLABEL
            // 
            o_productLABEL.AutoSize = true;
            o_productLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_productLABEL.Location = new Point(636, 104);
            o_productLABEL.Name = "o_productLABEL";
            o_productLABEL.Size = new Size(149, 18);
            o_productLABEL.TabIndex = 108;
            o_productLABEL.Text = "Product Catalog";
            // 
            // o_cartLABEL
            // 
            o_cartLABEL.AutoSize = true;
            o_cartLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_cartLABEL.Location = new Point(1060, 104);
            o_cartLABEL.Name = "o_cartLABEL";
            o_cartLABEL.Size = new Size(46, 18);
            o_cartLABEL.TabIndex = 109;
            o_cartLABEL.Text = "Cart";
            // 
            // o_paymentBOX
            // 
            o_paymentBOX.BackColor = Color.White;
            o_paymentBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            o_paymentBOX.FlatStyle = FlatStyle.Flat;
            o_paymentBOX.Font = new Font("Verdana", 9F);
            o_paymentBOX.FormattingEnabled = true;
            o_paymentBOX.Items.AddRange(new object[] { "cash", "card", "bank" });
            o_paymentBOX.Location = new Point(268, 718);
            o_paymentBOX.Name = "o_paymentBOX";
            o_paymentBOX.Size = new Size(312, 22);
            o_paymentBOX.TabIndex = 6;
            // 
            // o_paymentLABEL
            // 
            o_paymentLABEL.AutoSize = true;
            o_paymentLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_paymentLABEL.Location = new Point(268, 697);
            o_paymentLABEL.Name = "o_paymentLABEL";
            o_paymentLABEL.Size = new Size(157, 18);
            o_paymentLABEL.TabIndex = 112;
            o_paymentLABEL.Text = "Payment Method";
            // 
            // o_searchorderBOX
            // 
            o_searchorderBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            o_searchorderBOX.BackColor = SystemColors.Window;
            o_searchorderBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            o_searchorderBOX.ForeColor = Color.Black;
            o_searchorderBOX.Location = new Point(996, 774);
            o_searchorderBOX.Name = "o_searchorderBOX";
            o_searchorderBOX.PlaceholderText = "Search";
            o_searchorderBOX.Size = new Size(186, 22);
            o_searchorderBOX.TabIndex = 13;
            o_searchorderBOX.TextChanged += o_searchorderBOX_TextChanged;
            // 
            // o_transactionLABEL
            // 
            o_transactionLABEL.AutoSize = true;
            o_transactionLABEL.Font = new Font("Verdana", 12F, FontStyle.Bold);
            o_transactionLABEL.Location = new Point(268, 393);
            o_transactionLABEL.Name = "o_transactionLABEL";
            o_transactionLABEL.Size = new Size(173, 18);
            o_transactionLABEL.TabIndex = 113;
            o_transactionLABEL.Text = "Transaction Status";
            // 
            // o_transactionstatusBOX
            // 
            o_transactionstatusBOX.BackColor = Color.White;
            o_transactionstatusBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            o_transactionstatusBOX.FlatStyle = FlatStyle.Flat;
            o_transactionstatusBOX.Font = new Font("Verdana", 9F);
            o_transactionstatusBOX.FormattingEnabled = true;
            o_transactionstatusBOX.Items.AddRange(new object[] { "pending", "success", "failed" });
            o_transactionstatusBOX.Location = new Point(268, 414);
            o_transactionstatusBOX.Name = "o_transactionstatusBOX";
            o_transactionstatusBOX.Size = new Size(312, 22);
            o_transactionstatusBOX.TabIndex = 4;
            // 
            // o_searchproductBOX
            // 
            o_searchproductBOX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            o_searchproductBOX.BackColor = SystemColors.Window;
            o_searchproductBOX.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            o_searchproductBOX.ForeColor = Color.Black;
            o_searchproductBOX.Location = new Point(866, 774);
            o_searchproductBOX.Name = "o_searchproductBOX";
            o_searchproductBOX.PlaceholderText = "Search";
            o_searchproductBOX.Size = new Size(188, 22);
            o_searchproductBOX.TabIndex = 12;
            o_searchproductBOX.TextChanged += o_searchproductBOX_TextChanged;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 860);
            Controls.Add(o_searchproductBOX);
            Controls.Add(o_transactionstatusBOX);
            Controls.Add(o_transactionLABEL);
            Controls.Add(o_searchorderBOX);
            Controls.Add(o_deleteBUTTON);
            Controls.Add(o_addproductBUTTON);
            Controls.Add(o_paymentLABEL);
            Controls.Add(o_paymentBOX);
            Controls.Add(o_cartLABEL);
            Controls.Add(o_productLABEL);
            Controls.Add(o_cartLIST);
            Controls.Add(o_productLIST);
            Controls.Add(o_createBUTTON);
            Controls.Add(o_clearBUTTON);
            Controls.Add(o_refreshBUTTON);
            Controls.Add(o_orderstatusLABEL);
            Controls.Add(o_orderstatusBOX);
            Controls.Add(o_dateLABEL);
            Controls.Add(o_dateBOX);
            Controls.Add(o_customerBOX);
            Controls.Add(o_customerLABEL);
            Controls.Add(o_updateBUTTON);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(o_LIST);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)o_LIST).EndInit();
            ((System.ComponentModel.ISupportInitialize)o_productLIST).EndInit();
            ((System.ComponentModel.ISupportInitialize)o_cartLIST).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button o_deleteBUTTON;
        private Button o_updateBUTTON;
        private Label label7;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button o_productBUTTON;
        private Button o_orderBUTTON;
        private Button o_supplierBUTTON;
        private Button o_customerBUTTON;
        private Button o_staffBUTTON;
        private Button o_logoutBUTTON;
        private Panel panel1;
        private ComboBox o_customerBOX;
        private DateTimePicker o_dateBOX;
        private Label label3;
        private ComboBox o_orderstatusBOX;
        private DataGridView o_LIST;
        private Button o_refreshBUTTON;
        private Button o_addproductBUTTON;
        private Button o_clearBUTTON;
        private Button o_createBUTTON;
        private DataGridView o_productLIST;
        private DataGridView o_cartLIST;
        private Label o_productLABEL;
        private Label o_cartLABEL;
        private ComboBox o_modeBOX;
        private ComboBox o_paymentBOX;
        private DataGridViewImageColumn p_image;
        private DataGridViewTextBoxColumn p_id;
        private DataGridViewTextBoxColumn p_name;
        private DataGridViewTextBoxColumn p_price;
        private DataGridViewTextBoxColumn p_image_link;
        private DataGridViewTextBoxColumn c_id;
        private DataGridViewTextBoxColumn c_name;
        private DataGridViewTextBoxColumn c_unit_price;
        private DataGridViewTextBoxColumn c_quantity;
        private Label o_dateLABEL;
        private Label o_orderstatusLABEL;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn products;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn payment_method;
        private DataGridViewTextBoxColumn transaction_status;
        private DataGridViewTextBoxColumn order_status;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn transaction_id;
        private TextBox o_searchorderBOX;
        private ComboBox o_transactionstatusBOX;
        private TextBox o_searchproductBOX;
        private Label o_customerLABEL;
        private Label o_transactionLABEL;
        private Label o_paymentLABEL;
        private Label o_userLABEL;
    }
}