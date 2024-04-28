using System.Data;
using System.Data.SqlClient;

namespace e_commerce_management_system
{
    public partial class Supplier : Form
    {
        Function functions = new Function();

        // assigns connection string from program.cs
        string ConnectionString = Function.ConnectionString;



        public Supplier()
        {
            InitializeComponent();

            loadForm(); // load elements onto form

            showSupplier(); // load supplier table

            clearAll(); // clear all fields
        }



        // create method
        private void createSupplier(SupplierDetails details)
        {
            // creates new supplier record with user-defined values via SQL

            string su_query = "INSERT INTO Supplier VALUES(@name, @email_address, @phone_number, @address_id);";

            try
            {
                // creates new connection and opens that connection
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                // execute scalar to get id of newly added address record and assigns it to a variable
                int address_id = functions.createAddress(connection, details.street, details.city, details.postal_code, details.country);

                // insert user-defined values with respective query values
                SqlCommand command = new SqlCommand(su_query, connection);
                command.Parameters.AddWithValue("@name", details.name);
                command.Parameters.AddWithValue("@email_address", details.email_address);
                command.Parameters.AddWithValue("@phone_number", details.phone_number);
                command.Parameters.AddWithValue("@address_id", address_id);

                // execute the query and closes the connection
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record added!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showSupplier();
        }



        // read method
        private void readSupplier()
        {
            // reads the current selected supplier details and assigns the details to user fields

            if (su_LIST.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = su_LIST.SelectedRows[0];

                su_nameBOX.Text = selectedRow.Cells["name"].Value.ToString();
                su_emailBOX.Text = selectedRow.Cells["email_address"].Value.ToString();
                su_phoneBOX.Text = selectedRow.Cells["phone_number"].Value.ToString();
                su_streetBOX.Text = selectedRow.Cells["street"].Value.ToString();
                su_cityBOX.Text = selectedRow.Cells["city"].Value.ToString();
                su_postalBOX.Text = selectedRow.Cells["postal_code"].Value.ToString();
                su_countryBOX.Text = selectedRow.Cells["country"].Value.ToString();
            }
        }



        // update method
        private void updateSupplier(int supplier_id, int address_id, SupplierDetails details)
        {
            // edits the details of supplier record with user-defined values via SQL

            string c_query = "UPDATE Supplier SET name = @name, email_address = @email_address, phone_number = @phone_number WHERE id = @supplier_id";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                functions.updateAddress(connection, details.street, details.city, details.postal_code, details.country, address_id);

                SqlCommand command = new SqlCommand(c_query, connection);
                command.Parameters.AddWithValue("@name", details.name);
                command.Parameters.AddWithValue("@email_address", details.email_address);
                command.Parameters.AddWithValue("@phone_number", details.phone_number);
                command.Parameters.AddWithValue("@supplier_id", supplier_id);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record updated!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showSupplier();
        }



        // delete method
        private void deleteSupplier(int supplier_id, int address_id)
        {
            // deletes the selected supplier record via SQL

            string query = "DELETE FROM Supplier WHERE id = @supplier_id; DELETE FROM Address WHERE id = @address_id";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@supplier_id", supplier_id);
                command.Parameters.AddWithValue("@address_id", address_id);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record deleted!");
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR: supplier has existing products!");
            }
            showSupplier();
        }



        // create button
        private void su_createBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it creates a new supplier record
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "field" || checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: record details are missing!");
            }
            else
            {
                var details = new SupplierDetails
                {
                    name = su_nameBOX.Text,
                    email_address = su_emailBOX.Text,
                    phone_number = su_phoneBOX.Text,
                    street = su_streetBOX.Text,
                    city = su_cityBOX.Text,
                    postal_code = su_postalBOX.Text,
                    country = su_countryBOX.Text
                };

                createSupplier(details);
            }
            showSupplier();
        }



        // read trigger
        private void su_LIST_SelectionChanged(object sender, EventArgs e)
        {
            // if there is changes in selection of supplier table, it executes read supplier

            readSupplier();
        }



        // update button
        private void su_updateBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it updates the selected supplier record with user-defined values
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
                DataGridViewRow selectedRow = su_LIST.SelectedRows[0];

                int supplier_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int address_id = Convert.ToInt32(selectedRow.Cells["address_id"].Value);

                var details = new SupplierDetails
                {
                    name = su_nameBOX.Text,
                    email_address = su_emailBOX.Text,
                    phone_number = su_phoneBOX.Text,
                    street = su_streetBOX.Text,
                    city = su_cityBOX.Text,
                    postal_code = su_postalBOX.Text,
                    country = su_countryBOX.Text
                };

                updateSupplier(supplier_id, address_id, details);
            }
            showSupplier();
        }



        // delete button
        private void su_deleteBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, selected supplier record is deleted
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "selection" || checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: no record is selected!");
            }
            else
            {
                DataGridViewRow selectedRow = su_LIST.SelectedRows[0];

                int supplier_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int address_id = Convert.ToInt32(selectedRow.Cells["address_id"].Value);

                deleteSupplier(supplier_id, address_id);
            }
            showSupplier();
        }



        // load form method
        private void loadForm()
        {
            // detects if user is customer or admin

            if (functions.getUserType() == "customer")
            {
                int id = functions.extractInt(functions.getCustomerInfo());
                string name = functions.extractString(functions.getCustomerInfo());
                string info = $"Logged in as: {name} ({id})";

                su_userLABEL.Text = info;
            }
            else if (functions.getUserType() == "admin")
            {
                su_userLABEL.Text = "Logged in as: Admin (0)";
            }
        }



        // display method
        private void showSupplier()
        {
            // shows supplier table on form

            su_LIST.DataSource = functions.getData("SELECT su.id AS id, su.name AS name, su.email_address AS email_address, su.phone_number AS phone_number, a.id AS address_id, a.street AS street, a.city AS city, a.postal_code AS postal_code, a.country AS country FROM Supplier su INNER JOIN Address a ON su.address_id = a.id");
        }



        // clear method
        private void clearAll()
        {
            // makes all fields blank

            showSupplier();

            su_LIST.ClearSelection();

            su_nameBOX.Text = "";
            su_emailBOX.Text = "";
            su_phoneBOX.Text = "";
            su_streetBOX.Text = "";
            su_cityBOX.Text = "";
            su_postalBOX.Text = "";
            su_countryBOX.Text = "";
            su_searchBOX.Text = "";
        }



        // check method
        private string checkAll()
        {
            bool empty_field = su_nameBOX.Text == "" || su_emailBOX.Text == "" || su_phoneBOX.Text == "" || su_streetBOX.Text == "" || su_cityBOX.Text == "" || su_postalBOX.Text == "" || su_countryBOX.Text == "";

            bool empty_selection = su_LIST.SelectedRows.Count <= 0;

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
        private void searchSupplier(string word)
        {
            // searches through supplier table via keyword of search box and SQL

            string query = "SELECT su.id AS id, su.name AS name, su.email_address AS email_address, su.phone_number AS phone_number, a.id AS address_id ,a.street AS street, a.city AS city, a.postal_code AS postal_code, a.country AS country FROM Supplier su INNER JOIN Address a ON su.address_id = a.id WHERE su.id LIKE @word OR su.name LIKE @word OR su.email_address LIKE @word OR su.phone_number LIKE @word OR a.country LIKE @word";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@word", "%" + word + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                su_LIST.DataSource = datatable;

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }







        // search trigger
        private void su_searchBOX_TextChanged(object sender, EventArgs e)
        {
            // if there is changes in text of search box, it executes search supplier

            searchSupplier(su_searchBOX.Text);
        }



        // clear button
        private void su_clearBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it makes all fields blank

            clearAll();
        }



        // refresh button
        private void su_refreshBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it refreshes the supplier table

            showSupplier();
        }



        // order button
        private void su_orderBUTTON_Click(object sender, EventArgs e)
        {
            functions.orderForm(this);
        }



        // product button
        private void su_productBUTTON_Click(object sender, EventArgs e)
        {
            functions.productForm(this);
        }



        // customer button
        private void su_customerBUTTON_Click(object sender, EventArgs e)
        {
            functions.customerForm(this);
        }



        // staff button
        private void su_staffBUTTON_Click(object sender, EventArgs e)
        {
            functions.staffForm(this);
        }



        // logout button
        private void su_logoutBUTTON_Click(object sender, EventArgs e)
        {
            functions.loginForm(this);
        }
    }
}
