using System.Data;
using System.Data.SqlClient;

namespace e_commerce_management_system
{
    public partial class Customer : Form
    {
        Function functions = new Function();

        // assigns connection string from program.cs
        string ConnectionString = Function.ConnectionString;
        



        public Customer()
        {
            InitializeComponent();

            loadForm(); // load elements onto form

            showCustomers(); // load customer table

            clearAll(); // clear all fields
        }



        // create method
        private void createCustomer(CustomerDetails details)
        {
            // creates a customer record wth user-defined values from textboxes and inserts it into customer table

            string query = "INSERT INTO Customer VALUES(@name, @email_address, @password, @phone_number, @address_id);";

            try
            {
                // creates new connection and opens that connection
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                // execute create address method to create address details and return address id
                int address_id = functions.createAddress(connection, details.street, details.city, details.postal_code, details.country);

                // insert user-defined values with respective query values
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", details.name);
                command.Parameters.AddWithValue("@email_address", details.email_address);
                command.Parameters.AddWithValue("@password", details.password);
                command.Parameters.AddWithValue("@phone_number", details.phone_number);
                command.Parameters.AddWithValue("@address_id", address_id);

                // executes query and closes the connection
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record added!");
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showCustomers();
        }




        // read method
        private void readCustomer()
        {
            // scans the customer details and put those details on the text boxes

            if (c_LIST.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = c_LIST.SelectedRows[0];

                c_nameBOX.Text = selectedRow.Cells["name"].Value.ToString();
                c_emailBOX.Text = selectedRow.Cells["email_address"].Value.ToString();
                c_passwordBOX.Text = selectedRow.Cells["password"].Value.ToString();
                c_phoneBOX.Text = selectedRow.Cells["phone_number"].Value.ToString();
                c_streetBOX.Text = selectedRow.Cells["street"].Value.ToString();
                c_cityBOX.Text = selectedRow.Cells["city"].Value.ToString();
                c_postalBOX.Text = selectedRow.Cells["postal_code"].Value.ToString();
                c_countryBOX.Text = selectedRow.Cells["country"].Value.ToString();
            }
        }



        // update method
        private void updateCustomer(int customer_id, int address_id, CustomerDetails details)
        {
            string query = "UPDATE Customer SET name = @name, email_address = @email_address, password = @password, phone_number = @phone_number WHERE id = @customer_id";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                functions.updateAddress(connection, details.street, details.city, details.postal_code, details.country, address_id);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", details.name);
                command.Parameters.AddWithValue("@email_address", details.email_address);
                command.Parameters.AddWithValue("@password", details.password);
                command.Parameters.AddWithValue("@phone_number", details.phone_number);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record updated!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showCustomers();
        }



        // delete method
        private void deleteCustomer(int customer_id, int address_id)
        {
            // deletes customer record and also the address record that is inked to customer

            string query = "DELETE FROM Customer WHERE id = @customer_id; DELETE FROM Address WHERE id = @address_id";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.Parameters.AddWithValue("@address_id", address_id);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record deleted!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showCustomers();
        }



        // create button
        private void c_createBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it creates a new customer record
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "field" || checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: record details are missing!");
            }
            else
            {
                var details = new CustomerDetails
                {
                    name = c_nameBOX.Text,
                    email_address = c_emailBOX.Text,
                    password = c_passwordBOX.Text,
                    phone_number = c_phoneBOX.Text,
                    street = c_streetBOX.Text,
                    city = c_cityBOX.Text,
                    postal_code = c_postalBOX.Text,
                    country = c_countryBOX.Text
                };

                createCustomer(details);
            }
            showCustomers();
        }



        // read trigger
        private void c_LIST_SelectionChanged(object sender, EventArgs e)
        {
            // when there is selection in the table, it executes read customer

            readCustomer();
        }



        // update button
        private void c_updateBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it updates the selected product record with user-defined values
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
                var details = new CustomerDetails
                {
                    name = c_nameBOX.Text,
                    email_address = c_emailBOX.Text,
                    password = c_passwordBOX.Text,
                    phone_number = c_phoneBOX.Text,
                    street = c_streetBOX.Text,
                    city = c_cityBOX.Text,
                    postal_code = c_postalBOX.Text,
                    country = c_countryBOX.Text
                };

                DataGridViewRow selectedRow = c_LIST.SelectedRows[0];

                int customer_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int address_id = Convert.ToInt32(selectedRow.Cells["address_id"].Value);

                updateCustomer(customer_id, address_id, details);
            }
            showCustomers();
        }



        // delete button
        private void c_deleteBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it deletes the selected product record
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "selection" || checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: no record is selected!");
            }
            else
            {
                DataGridViewRow selectedRow = c_LIST.SelectedRows[0];

                int customer_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int address_id = Convert.ToInt32(selectedRow.Cells["address_id"].Value);

                deleteCustomer(customer_id, address_id);
            }
            showCustomers();
        }



        // load form method
        private void loadForm()
        {
            // when form loads, it detects whether user is customer or admin

            if (functions.getUserType() == "customer")
            {
                int id = functions.extractInt(functions.getCustomerInfo());
                string name = functions.extractString(functions.getCustomerInfo());
                string info = $"Logged in as: {name} ({id})";

                c_userLABEL.Text = info;
            }
            else if (functions.getUserType() == "admin")
            {
                c_userLABEL.Text = "Logged in as: Admin (0)";
            }
        }



        // display method
        private void showCustomers()
        {
            // displays customer details via SQL

            c_LIST.DataSource = functions.getData("SELECT c.id AS id, c.name AS name, c.email_address AS email_address, c.password AS password, c.phone_number AS phone_number, a.id AS address_id, a.street AS street, a.city AS city, a.postal_code AS postal_code, a.country AS country FROM Customer c INNER JOIN Address a ON c.address_id = a.id");
        }



        // clear method
        private void clearAll()
        {
            // makes every field blank

            showCustomers();

            c_LIST.ClearSelection();

            c_nameBOX.Text = "";
            c_emailBOX.Text = "";
            c_passwordBOX.Text = "";
            c_phoneBOX.Text = "";
            c_streetBOX.Text = "";
            c_cityBOX.Text = "";
            c_postalBOX.Text = "";
            c_countryBOX.Text = "";
            c_searchBOX.Text = "";
        }



        // check method
        private string checkAll()
        {
            bool empty_field = c_nameBOX.Text == "" || c_emailBOX.Text == "" || c_passwordBOX.Text == "" || c_phoneBOX.Text == "" || c_streetBOX.Text == "" || c_cityBOX.Text == "" || c_postalBOX.Text == "" || c_countryBOX.Text == "";

            bool empty_selection = c_LIST.SelectedRows.Count <= 0;

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
        private void searchCustomer(string word)
        {
            // searches through the customer table with keywords in searchbox and SQL

            string query = "SELECT c.id AS id, c.name AS name, c.email_address AS email_address, c.password AS password, c.phone_number AS phone_number, a.id AS address_id ,a.street AS street, a.city AS city, a.postal_code AS postal_code, a.country AS country FROM Customer c INNER JOIN Address a ON c.address_id = a.id WHERE c.id LIKE @word OR c.name LIKE @word OR c.email_address LIKE @word OR c.phone_number LIKE @word OR a.country LIKE @word";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@word", "%" + word + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                c_LIST.DataSource = datatable;

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }



        // search trigger
        private void c_searchBOX_TextChanged(object sender, EventArgs e)
        {
            // when there is changes in text of search box, it executes search customer

            searchCustomer(c_searchBOX.Text);
        }

        // clear button
        private void c_clearBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it makes all fields blank

            clearAll();
        }



        // refresh button
        private void c_refreshBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it refreshes the table

            showCustomers();
        }



        // order button
        private void c_orderBUTTON_Click(object sender, EventArgs e)
        {
            functions.orderForm(this);
        }



        // product button
        private void c_productBUTTON_Click(object sender, EventArgs e)
        {
            functions.productForm(this);
        }



        // staff button
        private void c_staffBUTTON_Click(object sender, EventArgs e)
        {
            functions.staffForm(this);
        }



        // supplier button
        private void c_supplierBUTTON_Click(object sender, EventArgs e)
        {
            functions.supplierForm(this);
        }



        // logout button
        private void c_logoutBUTTON_Click(object sender, EventArgs e)
        {
            functions.loginForm(this);
        }
    }
}
