using System.Data;
using System.Data.SqlClient;

namespace e_commerce_management_system
{
    public partial class Order : Form
    {
        Function functions = new Function();

        // assigns connection string from program.cs
        string ConnectionString = Function.ConnectionString;



        public Order()
        {
            InitializeComponent();

            loadForm(); // load elements onto form

            changeMode(); // enable and disable elements based on mode

            showOrders(); // load order table

            clearAll(); // clear all fields
        }



        // create method
        private void createOrder(int customer_id, string payment_method)
        {
            // creates an order, transaction, and orderdetail record via SQL that are all connected with foreign keys
            // order links with transaction details while orderdetail links with product details

            // total amount temporarily defaults to 0
            decimal total_amount = 0;

            try
            {
                // creates new SqlConnection and opens that connection
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                // execute scalar to get transaction id of the newly created record and assign it to a variable
                int transaction_id = functions.createTransaction(connection, payment_method);

                // execute scalar to get order id id of the newly created record and assign it to a variable
                int order_id = functions.createOrder(connection, customer_id, transaction_id);

                foreach (DataGridViewRow cartRow in o_cartLIST.Rows)
                {
                    // for each row in cart, it scans values for product id, unit price, and quantity in cart
                    int product_id = Convert.ToInt32(cartRow.Cells["c_id"].Value);
                    decimal unit_price = Convert.ToDecimal(cartRow.Cells["c_unit_price"].Value);
                    int quantity = Convert.ToInt32(cartRow.Cells["c_quantity"].Value);

                    // calculate total amount based on unit price of product and quantity in cart
                    decimal product_total_amount = unit_price * quantity;
                    total_amount += product_total_amount;

                    // execute scalar to get transaction id of the newly created record and assign it to a variable
                    functions.createOrderDetail(connection, order_id, product_id, transaction_id, unit_price, quantity, total_amount);
                }

                // closes connection and updates the table
                connection.Close();

                MessageBox.Show("SUCCESS: order placed!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showOrders();
        }



        // read method
        private void readOrder()
        {
            // puts every value of a record into the fields

            if (o_LIST.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = o_LIST.SelectedRows[0];

                string customer_id = selectedRow.Cells["customer_id"].Value.ToString();
                string customer_name = selectedRow.Cells["customer"].Value.ToString();
                string customer = $"{customer_id} - {customer_name}";

                o_customerBOX.Text = customer;
                o_dateBOX.Text = selectedRow.Cells["date"].Value.ToString();
                o_orderstatusBOX.Text = selectedRow.Cells["order_status"].Value.ToString();
                o_transactionstatusBOX.Text = selectedRow.Cells["transaction_status"].Value.ToString();
                o_paymentBOX.Text = selectedRow.Cells["payment_method"].Value.ToString();
            }
        }



        // update method
        private void updateOrder(int order_id, int transaction_id, int customer_id, TransactionDetails details)
        {
            // edits the details of order and transaction
            // note that product details in orderdetail CANNOT be edited

            string query = "UPDATE [Order] SET customer_id = @customer_id, date = @date, status = @order_status WHERE id = @order_id";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.Parameters.AddWithValue("@order_id", order_id);
                command.Parameters.AddWithValue("@order_status", details.order_status);
                command.Parameters.AddWithValue("@date", details.date);
                command.ExecuteNonQuery();

                functions.updateTransaction(connection, transaction_id, details);

                MessageBox.Show("SUCCESS: order updated!");
                showOrders();

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showOrders();
        }



        // delete method
        private void deleteOrder(int order_id, int transaction_id)
        {
            // deletes the specified order, transaction, and orderdetail records

            string query = "DELETE FROM OrderDetail WHERE order_id = @order_id; DELETE FROM [Order] WHERE id = @order_id; DELETE FROM [Transaction] WHERE id = @transaction_id; ";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@transaction_id", transaction_id);
                command.Parameters.AddWithValue("@order_id", order_id);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: order deleted!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showOrders();
        }



        // create button
        private void o_createBUTTON_Click(object sender, EventArgs e)
        {
            // button for creating orders
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "field, cart")
            {
                MessageBox.Show("ERROR: order details are missing and cart is empty!");
                showOrders();
            }
            else if (checkAll() == "field")
            {
                MessageBox.Show("ERROR: order details are missing!");
                showOrders();
            }
            else if (checkAll() == "cart")
            {
                MessageBox.Show("ERROR: cart is empty!");
                showOrders();
            }
            else
            {
        int customer_id = functions.extractInt(o_customerBOX.Text);
                createOrder(customer_id, o_paymentBOX.Text);
            }
        }


        // read trigger
        private void o_LIST_SelectionChanged(object sender, EventArgs e)
        {
            // when selection is changed in order table, it reads order detail

            readOrder();
        }



        // update button
        private void o_updateBUTTON_Click(object sender, EventArgs e)
        {
            // button for updating orders
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: record details are missing and no record is selected!");
                showOrders();
            }
            else if (checkAll() == "selection")
            {
                MessageBox.Show("ERROR: no record is selected!");
                showOrders();
            }
            else if (checkAll() == "field")
            {
                MessageBox.Show("ERROR: record details are missing!");
                showOrders();
            }
            else
            {
                DataGridViewRow selectedRow = o_LIST.SelectedRows[0];

                int order_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int transaction_id = Convert.ToInt32(selectedRow.Cells["transaction_id"].Value);
                DateTime date = Convert.ToDateTime(o_dateBOX.Text);
                int customer_id = functions.extractInt(o_customerBOX.Text);

                var details = new TransactionDetails
                {
                    transaction_status = o_transactionstatusBOX.Text,
                    order_status = o_orderstatusBOX.Text,
                    payment_method = o_paymentBOX.Text,
                    date = date
                };

                updateOrder(order_id, transaction_id, customer_id, details);
            }
        }



        // delete button
        private void o_deleteBUTTON_Click(object sender, EventArgs e)
        {
            // button for deleting orders
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkMode() == 1)
            {
                if (o_cartLIST.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("ERROR: no item in cart is selected!");
                    showOrders();
                }
                else
                {
                    DataGridViewRow selectedRow = o_cartLIST.SelectedRows[0];

                    int product_id = Convert.ToInt32(selectedRow.Cells["c_id"].Value);

                    removeProductFromCart(product_id);
                }
            }
            else if (checkMode() == 2)
            {
                if (checkAll() == "selection" || checkAll() == "field and selection")
                {
                    MessageBox.Show("ERROR: no record is selected!");
                    showOrders();
                }
                else
                {
                    DataGridViewRow selectedRow = o_LIST.SelectedRows[0];

                    int order_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    int transaction_id = Convert.ToInt32(selectedRow.Cells["transaction_id"].Value);

                    deleteOrder(order_id, transaction_id);
                }

            }
        }



        // load form method
        private void loadForm()
        {
            o_modeBOX.SelectedIndex = 0;

            // check if user is user or admin
            if (functions.getUserType() == "customer")
            {
                userCustomer();
            }
            else if (functions.getUserType() == "admin")
            {
                userAdmin();
            }
        }



        // check all method
        private string checkAll()
        {
            bool empty_field = o_customerBOX.SelectedIndex == -1 || o_orderstatusBOX.SelectedIndex == -1 || o_transactionstatusBOX.SelectedIndex == -1 || o_paymentBOX.SelectedIndex == -1;

            bool empty_cart = o_cartLIST.Rows.Count <= 0;

            bool empty_order_selection = o_LIST.SelectedRows.Count <= 0;

            // checks every field and return what is the error
            if (checkMode() == 1)
            {
                if (empty_field && empty_cart)
                {
                    return "field, cart";
                }
                else if (empty_field)
                {
                    return "field";
                }
                else if (empty_cart)
                {
                    return "cart";
                }
            }
            else if (checkMode() == 2)
            {
                if (empty_field && empty_order_selection)
                {
                    return "field and selection";
                }
                else if (empty_field)
                {
                    return "field";
                }
                else if (empty_order_selection)
                {
                    return "selection";
                }
            }
            return "ok :)";
        }



        // check mode method
        private int checkMode()
        {
            // checks what mode user is on
            if (o_modeBOX.Text == "create orders")
            {
                return 1;
            }
            else if (o_modeBOX.Text == "manage orders")
            {
                return 2;
            }
            return 0;
        }



        // change mode method
        private void changeMode()
        {
            // changes mode based on mode and user type
            if (checkMode() == 1)
            {
                if (functions.getUserType() == "customer")
                {
                    userCustomer();
                }
                defaultLoadMode1();
            }
            else if (checkMode() == 2)
            {
                if (functions.getUserType() == "customer")
                {
                    userCustomer();

                }
                else if (functions.getUserType() == "admin")
                {
                    userAdmin();
                }
                defaultLoadMode2();
            }
            showOrders();
        }



        // orders display method
        private void showOrders()
        {
            // shows order table on a datagridview table via SQL
            if (functions.getUserType() == "customer")
            {
                int customer_id = functions.extractInt(functions.getCustomerInfo());

                o_LIST.DataSource = functions.getData($"SELECT o.id AS id, c.name AS customer, STRING_AGG(CONCAT(CAST(od.quantity AS varchar), 'pc. ', p.name), ', ') AS products, o.date AS date,  c.id AS customer_id,  t.id AS transaction_id, t.total_amount AS total_amount, t.payment_method AS payment_method, t.status AS transaction_status, o.status AS order_status FROM [Order] o INNER JOIN Customer c ON o.customer_id = c.id INNER JOIN [Transaction] t ON o.transaction_id = t.id INNER JOIN OrderDetail od ON o.id = od.order_id INNER JOIN Product p ON od.product_id = p.id WHERE c.id = '{customer_id}'  GROUP BY o.id, o.date, o.status, c.id, c.name, t.id, t.total_amount, t.payment_method, t.status;");
            }
            else if (functions.getUserType() == "admin")
            {
                o_LIST.DataSource = functions.getData("SELECT o.id AS id, c.name AS customer, STRING_AGG(CONCAT(CAST(od.quantity AS varchar), 'pc. ', p.name), ', ') AS products, o.date AS date,  c.id AS customer_id,  t.id AS transaction_id, t.total_amount AS total_amount, t.payment_method AS payment_method, t.status AS transaction_status, o.status AS order_status FROM [Order] o INNER JOIN Customer c ON o.customer_id = c.id INNER JOIN [Transaction] t ON o.transaction_id = t.id INNER JOIN OrderDetail od ON o.id = od.order_id INNER JOIN Product p ON od.product_id = p.id GROUP BY o.id, o.date, o.status, c.id, c.name, t.id, t.total_amount, t.payment_method, t.status;");
            }
            showProducts();
        }



        // products display method
        private void showProducts()
        {
            // shows product table on a datagridview table via SQL
            o_productLIST.DataSource = functions.getDataWithImage("SELECT id, name, price, image_link FROM Product");

            showCustomers();
        }



        // customers display method
        private void showCustomers()
        {
            //shows customer list on a combo box via SQL
            o_customerBOX.Items.Clear();

            string query = "SELECT DISTINCT id, name FROM Customer";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int customer_id = reader.GetInt32(0);
                        string customer_name = reader.GetString(1);

                        string customer_result = $"{customer_id} - {customer_name}";

                        o_customerBOX.Items.Add(customer_result);


                    }
                    if (functions.getUserType() == "customer")
                    {
                        string customer = functions.getCustomerInfo();

                        o_customerBOX.SelectedItem = customer;
                        o_customerBOX.Enabled = false;
                    }

                    connection.Close();
                    clearAll();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                showOrders();
            }
        }



        // clear method
        private void clearAll()
        {
            // makes every field blank

            o_LIST.ClearSelection();
            o_productLIST.ClearSelection();
            o_cartLIST.ClearSelection();
            o_cartLIST.Rows.Clear();

            o_paymentBOX.SelectedIndex = -1;

            if (checkMode() == 2)
            {
                o_orderstatusBOX.SelectedIndex = -1;
                o_transactionstatusBOX.SelectedIndex = -1;
            }
        }



        // add to cart method
        private void addProductToCart(int product_id, string name, decimal price)
        {
            // adds selected product from product catalog to a datagridview table named cart
            // note that product catalog is product table

            bool productExist = false;

            try
            {
                foreach (DataGridViewRow cartRow in o_cartLIST.Rows)
                {
                    int cart_product_id = Convert.ToInt32(cartRow.Cells["c_id"].Value);

                    if (cart_product_id == product_id)
                    {
                        int current_quantity = Convert.ToInt32(cartRow.Cells["c_quantity"].Value);

                        cartRow.Cells["c_quantity"].Value = current_quantity + 1;

                        productExist = true;

                        break;
                    }
                }
                if (!productExist)
                {
                    o_cartLIST.Rows.Add(product_id, name, price, 1);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }



        // remove from cart method
        private void removeProductFromCart(int product_id)
        {
            // removes an item inside the cart

            try
            {
                foreach (DataGridViewRow cartRow in o_cartLIST.Rows)
                {
                    int cart_product_id = Convert.ToInt32(cartRow.Cells["c_id"].Value);

                    if (cart_product_id == product_id)
                    {
                        o_cartLIST.Rows.Remove(cartRow);
                        break;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }







        // search order method
        private void searchOrder(string word)
        {
            // searches the order table via keywords in search box and SQL

            string query = "SELECT o.id AS id, c.name AS customer, STRING_AGG(p.name, ', ') AS products, o.date AS date,  c.id AS customer_id,  t.id AS transaction_id, t.total_amount AS total_amount, t.payment_method AS payment_method, t.status AS transaction_status, o.status AS order_status FROM [Order] o INNER JOIN Customer c ON o.customer_id = c.id INNER JOIN [Transaction] t ON o.transaction_id = t.id INNER JOIN OrderDetail od ON o.id = od.order_id INNER JOIN Product p ON od.product_id = p.id WHERE o.id LIKE @word OR c.name LIKE @word OR t.payment_method LIKE @word OR p.name LIKE @word OR o.status LIKE @word GROUP BY o.id, o.date, o.status, c.id, c.name, t.id, t.total_amount, t.payment_method, t.status;";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@word", "%" + word + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                o_LIST.DataSource = datatable;

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                showOrders();
            }
        }



        // search product method
        private void searchProduct(string word)
        {
            // searches the product table via keywords in search box and SQL

            o_productLIST.BindingContext[o_productLIST.DataSource].SuspendBinding();

            foreach (DataGridViewRow row in o_productLIST.Rows)
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

            o_productLIST.BindingContext[o_productLIST.DataSource].ResumeBinding();
        }





        // search order trigger
        private void o_searchorderBOX_TextChanged(object sender, EventArgs e)
        {
            // if theres words in searchbox, execute search order

            searchOrder(o_searchorderBOX.Text);
        }



        // search product trigger
        private void o_searchproductBOX_TextChanged(object sender, EventArgs e)
        {
            // if theres words in searchox, execute product search

            searchProduct(o_searchproductBOX.Text);
        }



        // add to cart button
        private void o_addproductBUTTON_Click(object sender, EventArgs e)
        {
            // button for adding products to cart
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (o_productLIST.SelectedRows.Count <= 0)
            {
                MessageBox.Show("ERROR: no product is selected!");
                showOrders();
            }
            else
            {
                DataGridViewRow selectedRow = o_productLIST.SelectedRows[0];

                int product_id = Convert.ToInt32(selectedRow.Cells["p_id"].Value);
                string product_name = Convert.ToString(selectedRow.Cells["p_name"].Value);
                decimal product_price = Convert.ToDecimal(selectedRow.Cells["p_price"].Value);

                addProductToCart(product_id, product_name, product_price);
            }
        }



        // refresh button
        private void o_refreshBUTTON_Click(object sender, EventArgs e)
        {
            // button for refreshing order table

            showOrders();
        }



        // clear button
        private void o_clearBUTTON_Click(object sender, EventArgs e)
        {
            // button for clearing all fields

            clearAll();
        }



        // mode trigger
        private void o_modeBOX_SelectionIndexChanged(object sender, EventArgs e)
        {
            // if mode changed, it executes change mode

            changeMode();
        }



        // products button
        private void o_productBUTTON_Click(object sender, EventArgs e)
        {
            functions.productForm(this);
        }



        // customers button
        private void o_customerBUTTON_Click(object sender, EventArgs e)
        {
            functions.customerForm(this);
        }



        // staff button
        private void o_staffBUTTON_Click(object sender, EventArgs e)
        {
            functions.staffForm(this);
        }



        // supplier button
        private void o_supplierBUTTON_Click(object sender, EventArgs e)
        {
            functions.supplierForm(this);
        }



        // logout button
        private void o_logoutBUTTON_Click(object sender, EventArgs e)
        {
            functions.loginForm(this);
        }



        // user is customer
        private void userCustomer()
        {
            // all necessary fields are shown if user is customer

            int id = functions.extractInt(functions.getCustomerInfo());
            string name = functions.extractString(functions.getCustomerInfo());
            string info = $"Logged in as: {name} ({id})";
            o_userLABEL.Text = info;

            if (checkMode() == 1)
            {
                o_customerLABEL.Visible = true;
                o_customerBOX.Visible = true;

                o_dateLABEL.Visible = true;
                o_dateBOX.Visible = true;

                o_transactionstatusBOX.Visible = true;
                o_transactionLABEL.Visible = true;

                o_orderstatusBOX.Visible = true;
                o_orderstatusLABEL.Visible = true;

                o_paymentBOX.Visible = true;
                o_paymentLABEL.Visible = true;
            }
            else if (checkMode() == 2)
            {
                o_customerLABEL.Visible = false;
                o_dateLABEL.Visible = false;
                o_transactionLABEL.Visible = false;
                o_orderstatusLABEL.Visible = false;
                o_paymentLABEL.Visible = false;

                o_customerBOX.Visible = false;
                o_dateBOX.Visible = false;
                o_transactionstatusBOX.Visible = false;
                o_orderstatusBOX.Visible = false;
                o_paymentBOX.Visible = false;

                o_clearBUTTON.Visible = false;
                o_updateBUTTON.Visible = false;
                o_deleteBUTTON.Visible = false;
                o_searchorderBOX.Visible = false;

                o_LIST.Size = new Size(1160, 664);
                o_LIST.Location = new Point(268, 104);
            }

            o_customerBUTTON.Visible = false;
            o_staffBUTTON.Visible = false;
            o_supplierBUTTON.Visible = false;
        }



        // user is admin
        private void userAdmin()
        {
            // all necessary fields are shown if user is admin

            o_userLABEL.Text = "Logged in as: Admin (0)";

            o_dateBOX.Enabled = true;
            o_dateLABEL.Visible = true;
            o_updateBUTTON.Visible = true;
            o_searchorderBOX.Visible = true;
            o_orderstatusLABEL.Visible = true;
            o_orderstatusBOX.Visible = true;


            o_customerBUTTON.Visible = true;
            o_staffBUTTON.Visible = true;
            o_supplierBUTTON.Visible = true;
        }



        // load elements on mode 1 method
        private void defaultLoadMode1()
        {
            // regardless of user type, it loads the default elements when mode is 1

            o_productLIST.Visible = true;
            o_cartLIST.Visible = true;
            o_productLABEL.Visible = true;
            o_cartLABEL.Visible = true;
            o_LIST.Visible = false;
            o_dateBOX.Enabled = false;
            o_orderstatusBOX.Enabled = false;
            o_transactionstatusBOX.Enabled = false;
            o_updateBUTTON.Visible = false;
            o_addproductBUTTON.Visible = true;
            o_createBUTTON.Visible = true;
            o_searchorderBOX.Visible = false;
            o_searchproductBOX.Visible = true;
            o_clearBUTTON.Visible = true;

            o_deleteBUTTON.Visible = true;

            o_customerBOX.SelectedIndex = -1;
            o_dateBOX.Value = DateTime.Today;
            o_orderstatusBOX.SelectedItem = "pending";
            o_transactionstatusBOX.SelectedItem = "pending";
            o_paymentBOX.SelectedIndex = -1;
        }


        // load elements on mode 2 method
        private void defaultLoadMode2()
        {
            // regardless of user type, it loads the default elements when mode is 2

            o_productLIST.Visible = false;
            o_cartLIST.Visible = false;
            o_productLABEL.Visible = false;
            o_cartLABEL.Visible = false;
            o_LIST.Visible = true;

            o_transactionstatusBOX.Enabled = true;

            o_addproductBUTTON.Visible = false;
            o_createBUTTON.Visible = false;

            o_orderstatusBOX.Enabled = true;

            o_searchproductBOX.Visible = false;

            o_dateBOX.Value = DateTime.Today;
            o_orderstatusBOX.SelectedIndex = -1;
        }
    }
}
