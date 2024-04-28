using System.Data;
using System.Data.SqlClient;

namespace e_commerce_management_system
{
    public partial class Product : Form
    {
        Function functions = new Function();

        // assigns connection string from program.cs
        string ConnectionString = Function.ConnectionString;



        public Product()
        {
            InitializeComponent();

            loadForm(); // loads elements on form

            showProducts(); // displays product table

            clearAll(); // clears all fields
        }



        // create method
        private void createProduct(int supplier_id, ProductDetails details)
        {
            // creates product record with user-defined values from text boxes via SQL

            string query = "INSERT INTO Product VALUES(@supplier_id, @name, @description, @category, @price, @stock, @image_link);";

            try
            {
                // creates new SQL connection and opens that connection
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                // assigns user-defined values to respective query values
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", details.name);
                command.Parameters.AddWithValue("@description", details.description);
                command.Parameters.AddWithValue("@category", details.category);
                command.Parameters.AddWithValue("@price", details.price);
                command.Parameters.AddWithValue("@stock", details.stock);
                command.Parameters.AddWithValue("@image_link", details.image_link);
                command.Parameters.AddWithValue("@supplier_id", supplier_id);

                // executes query, updates the product table and closes the SQL connection
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record added!");

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showProducts();
        }



        // read method
        private void readProduct()
        {
            // reads the product details and puts values on the fields

            if (p_LIST.SelectedRows.Count > 0 && functions.getUserType() == "admin")
            {
                DataGridViewRow selectedRow = p_LIST.SelectedRows[0];

                string supplier_id = selectedRow.Cells["supplier_id"].Value.ToString();
                string supplier_name = selectedRow.Cells["supplier_name"].Value.ToString();
                string supplier = $"{supplier_id} - {supplier_name}";

                p_nameBOX.Text = selectedRow.Cells["name"].Value.ToString();
                p_descriptionBOX.Text = selectedRow.Cells["description"].Value.ToString();
                p_categoryBOX.Text = selectedRow.Cells["category"].Value.ToString();
                p_priceBOX.Text = selectedRow.Cells["price"].Value.ToString();
                p_stockBOX.Text = selectedRow.Cells["stock"].Value.ToString();
                p_imageBOX.Text = selectedRow.Cells["image_link"].Value.ToString();
                p_supplierBOX.Text = supplier;
            }
        }



        // update method
        private void updateProduct(int product_id, int supplier_id, ProductDetails details)
        {
            // edits product details with user-defined values via SQL

            string query = "UPDATE Product SET supplier_id = @supplier_id, name = @name, description = @description, category = @category, price = @price, stock = @stock, image_link = @image_link WHERE id = @product_id";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@product_id", product_id);
                command.Parameters.AddWithValue("@supplier_id", supplier_id);
                command.Parameters.AddWithValue("@name", details.name);
                command.Parameters.AddWithValue("@description", details.description);
                command.Parameters.AddWithValue("@category", details.category);
                command.Parameters.AddWithValue("@price", details.price);
                command.Parameters.AddWithValue("@stock", details.stock);
                command.Parameters.AddWithValue("@image_link", details.image_link);

                command.ExecuteNonQuery();

                MessageBox.Show("SUCCESS: record updated!");
                showProducts();

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                showProducts();
            }
        }



        // delete method
        private void deleteProduct(int product_id)
        {
            // delete a product record via SQL

            string query = "DELETE FROM Product WHERE id = @product_id;";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@product_id", product_id);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record deleted!");
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR: product exists in an order!");
            }
            showProducts();
        }



        // create button
        private void p_addBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it creates a new product record
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "field" || checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: record details are missing!");
            }
            else
            {
                try
                {
                    decimal price = decimal.Parse(p_priceBOX.Text);
                    int stock = int.Parse(p_stockBOX.Text);

                    int supplier_id = functions.extractInt(p_supplierBOX.Text);

                    var details = new ProductDetails
                    {
                        name = p_nameBOX.Text,
                        category = p_categoryBOX.Text,
                        description = p_descriptionBOX.Text,
                        price = price,
                        stock = stock,
                        image_link = p_imageBOX.Text
                    };

                    createProduct(supplier_id, details);
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR: incorrect value for price or stock!");
                }
            }
            showProducts();
        }



        // read trigger
        private void p_LIST_SelectionChanged(object sender, EventArgs e)
        {
            // when there is selection on product table, executes read product

            readProduct();
        }



        // update button
        private void p_updateBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it updates the selected product record
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: record details are missing and no record is selected!");
            }
            else if (checkAll() == "selection")
            {
                MessageBox.Show("ERROR: no record is selected!");
            }
            else if (checkAll() == "field")
            {
                MessageBox.Show("ERROR: record details are missing!");
            }
            else
            {
                DataGridViewRow selectedRow = p_LIST.SelectedRows[0];

                int product_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int supplier_id = functions.extractInt(p_supplierBOX.Text);
                decimal price = decimal.Parse(p_priceBOX.Text);
                int stock = int.Parse(p_stockBOX.Text);

                var details = new ProductDetails
                {
                    name = p_nameBOX.Text,
                    category = p_categoryBOX.Text,
                    description = p_descriptionBOX.Text,
                    price = price,
                    stock = stock,
                    image_link = p_imageBOX.Text
                };

                updateProduct(product_id, supplier_id, details);
            }
            showProducts();
        }



        // delete button
        private void p_deleteBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it deletes the selected product record
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "selection" || checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: no record is selected!");
            }
            else
            {
                DataGridViewRow selectedRow = p_LIST.SelectedRows[0];

                int product_id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                deleteProduct(product_id);
            }
            showProducts();
        }



        // load form method
        private void loadForm()
        {
            // checks if user is customer or admin and loads appropriate forms via user type

            p_supplierBOX.SelectedIndex = -1;
            p_categoryBOX.SelectedIndex = -1;

            if (functions.getUserType() == "customer")
            {
                user_customer();
            }
            else if (functions.getUserType() == "admin")
            {
                user_admin();
            }
        }



        // products display method
        private void showProducts()
        {
            // displays products table on form via SQL

            p_LIST.DataSource = functions.getDataWithImage("SELECT p.id AS id, p.name AS name, p.description AS description, p.category AS category, p.price AS price, p.stock AS stock, p.image_link AS image_link, s.id AS supplier_id, s.name as supplier_name FROM Product p INNER JOIN Supplier s ON p.supplier_id = s.id");

            if (functions.getUserType() == "customer")
            {
                p_LIST.Columns["supplier_name"].Visible = false;
                p_LIST.Columns["stock"].Visible = false;
            }

            showSuppliers();
        }



        // suppliers display method
        private void showSuppliers()
        {
            // scans supplier table and inserts them into the combo box

            p_supplierBOX.Items.Clear();

            string s_query = "SELECT DISTINCT id, name FROM Supplier";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(s_query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int supplier_id = reader.GetInt32(0);
                        string supplier_name = reader.GetString(1);

                        string supplier = $"{supplier_id} - {supplier_name}";

                        p_supplierBOX.Items.Add(supplier);
                    }

                    connection.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            readProduct();
        }



        // clear method
        private void clearAll()
        {
            // makes all fields blank

            //showProducts();

            p_LIST.ClearSelection();

            p_searchBOX.Text = "";
            p_nameBOX.Text = "";
            p_imageBOX.Text = "";
            p_descriptionBOX.Text = "";
            p_categoryBOX.SelectedIndex = -1;
            p_priceBOX.Text = "";
            p_stockBOX.Text = "";
            p_supplierBOX.SelectedIndex = -1;
        }



        // check method
        private string checkAll()
        {
            bool empty_field = p_nameBOX.Text == "" || p_descriptionBOX.Text == "" || p_categoryBOX.Text == "" || p_priceBOX.Text == "" || p_stockBOX.Text == "" || p_supplierBOX.Text == "" || p_categoryBOX.SelectedIndex == -1 || p_supplierBOX.SelectedIndex == -1;

            bool empty_selection = p_LIST.SelectedRows.Count <= 0;

            // checks every field and return what is the error

            if (empty_field && empty_selection)
            {
                return "field and selection";
            }
            else if (empty_field)
            {
                return "field";
            }
            else if (empty_selection)
            {
                return "selection";
            }
            return "ok";
        }



        // search method
        private void searchProduct(string word)
        {
            // searches through product table via keywords of search box and SQL

            p_LIST.BindingContext[p_LIST.DataSource].SuspendBinding();

            foreach (DataGridViewRow row in p_LIST.Rows)
            {
                bool rowContainsText = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(word.ToLower()))
                    {
                        rowContainsText = true;
                        break;
                    }
                }

                row.Visible = rowContainsText;
            }

            p_LIST.BindingContext[p_LIST.DataSource].ResumeBinding();
        }



        



        // search trigger
        private void p_searchBOX_TextChanged(object sender, EventArgs e)
        {
            // when there is change of text in search box, execute search products

            searchProduct(p_searchBOX.Text);
        }



        // upload button
        private void p_uploadBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it will prompt the user to upload an image into the system
            // it only uploads the directory of the image, NOT THE IMAGE ITSELF (i.e.: C:/User/image.jpg)

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog.Title = "Select an image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                p_imageBOX.Text = openFileDialog.FileName;
            }
        }


        // clear button
        private void p_clearBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it will make all fields blank

            clearAll();
        }



        // refresh button
        private void p_refreshBUTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it refreshes the form

            showProducts();
        }



        // order button
        private void p_orderBUTTON_Click(object sender, EventArgs e)
        {
            functions.orderForm(this);
        }



        // customer button
        private void p_customerBUTTON_Click(object sender, EventArgs e)
        {
            functions.customerForm(this);
        }



        // staff button
        private void p_staffBUTTON_Click(object sender, EventArgs e)
        {
            functions.staffForm(this);
        }



        // supplier button
        private void p_supplierBUTTON_Click(object sender, EventArgs e)
        {
            functions.supplierForm(this);
        }



        // logout button
        private void p_logoutBUTTON_Click(object sender, EventArgs e)
        {
            functions.loginForm(this);
        }



        // user is customer method
        private void user_customer()
        {
            // executes necessary elements when user is customer

            int id = functions.extractInt(functions.getCustomerInfo());
            string name = functions.extractString(functions.getCustomerInfo());
            string info = $"Logged in as: {name} ({id})";

            p_userLABEL.Text = info;
            p_customerBUTTON.Visible = false;
            p_staffBUTTON.Visible = false;
            p_supplierBUTTON.Visible = false;

            p_nameBOX.Visible = false;
            p_nameLABEL.Visible = false;
            p_imageBOX.Visible = false;
            p_imageLABEL.Visible = false;
            p_uploadBUTTON.Visible = false;
            p_categoryBOX.Visible = false;
            p_categoryLABEL.Visible = false;
            p_descriptionBOX.Visible = false;
            p_descriptionLABEL.Visible = false;
            p_priceBOX.Visible = false;
            p_priceLABEL.Visible = false;
            p_stockBOX.Visible = false;
            p_stockLABEL.Visible = false;
            p_supplierBOX.Visible = false;
            p_supplierLABEL.Visible = false;

            p_clearBUTTON.Visible = false;
            p_addBUTTON.Visible = false;
            p_updateBUTTON.Visible = false;
            p_deleteBUTTON.Visible = false;

            p_LIST.Size = new Size(1160, 664);
            p_LIST.Location = new Point(268, 104);
        }


        // user is admin method
        private void user_admin()
        {
            // executes necessary elements when user is admin

            p_userLABEL.Text = "Logged in as: Admin (0)";

            p_customerBUTTON.Visible = true;
            p_staffBUTTON.Visible = true;
            p_supplierBUTTON.Visible = true;

            p_nameBOX.Visible = true;
            p_nameLABEL.Visible = true;
            p_imageBOX.Visible = true;
            p_imageLABEL.Visible = true;
            p_uploadBUTTON.Visible = true;
            p_categoryBOX.Visible = true;
            p_categoryLABEL.Visible = true;
            p_descriptionBOX.Visible = true;
            p_descriptionLABEL.Visible = true;
            p_priceBOX.Visible = true;
            p_priceLABEL.Visible = true;
            p_stockBOX.Visible = true;
            p_stockLABEL.Visible = true;
            p_supplierBOX.Visible = true;
            p_supplierLABEL.Visible = true;

            p_clearBUTTON.Visible = true;
            p_addBUTTON.Visible = true;
            p_updateBUTTON.Visible = true;
            p_deleteBUTTON.Visible = true;

            p_LIST.Size = new Size(792, 664);
            p_LIST.Location = new Point(636, 104);
        }
    }
}
