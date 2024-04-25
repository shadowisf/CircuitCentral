using System.Data;
using System.Data.SqlClient;

namespace e_commerce_management_system
{
    public partial class Staff : Form
    {
        Function functions = new Function();

        // assigns connection string from program.cs
        string ConnectionString = Function.ConnectionString;



        public Staff()
        {
            InitializeComponent();

            loadForm(); // load elements onto form

            showStaff(); // load staff table

            clearAll(); // clear all fields
        }



        // create method
        private void createStaff(StaffDetails details)
        {
            // creates a staff record with user-defined values via SQL

            string query = "INSERT INTO Staff VALUES(@name, @email_address, @password, @phone_number, @department, @address_id);";

            try
            {
                // create connection and open that connection
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
                command.Parameters.AddWithValue("@department", details.department);
                command.Parameters.AddWithValue("@address_id", address_id);

                // execute query and close the connection
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record added!");
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showStaff();
        }



        // read method
        private void readStaff()
        {
            // reads staff details and assigns those details to fields

            if (s_LIST.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = s_LIST.SelectedRows[0];

                s_nameBOX.Text = selectedRow.Cells["name"].Value.ToString();
                s_emailBOX.Text = selectedRow.Cells["email_address"].Value.ToString();
                s_passwordBOX.Text = selectedRow.Cells["password"].Value.ToString();
                s_phoneBOX.Text = selectedRow.Cells["phone_number"].Value.ToString();
                s_departmentBOX.Text = selectedRow.Cells["department"].Value.ToString();
                s_streetBOX.Text = selectedRow.Cells["street"].Value.ToString();
                s_cityBOX.Text = selectedRow.Cells["city"].Value.ToString();
                s_postalBOX.Text = selectedRow.Cells["postal_code"].Value.ToString();
                s_countryBOX.Text = selectedRow.Cells["country"].Value.ToString();
            }
        }



        // update method
        private void updateStaff(int staff_id, int address_id, StaffDetails details)
        {
            // edits the staff and address details with user-defined values and SQL

            string query = "UPDATE Staff SET name = @name, email_address = @email_address, password = @password, phone_number = @phone_number, department = @department WHERE id = @staff_id";

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
                command.Parameters.AddWithValue("@department", details.department);
                command.Parameters.AddWithValue("@staff_id", staff_id);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record updated!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showStaff();
        }



        // delete method
        public void deleteStaff(int staff_id, int address_id)
        {
            // deletes the staff and address records via SQL

            string query = "DELETE FROM Staff WHERE id = @staff_id; DELETE FROM Address WHERE id = @address_id";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@staff_id", staff_id);
                command.Parameters.AddWithValue("@address_id", address_id);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("SUCCESS: record deleted!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            showStaff();
        }



        // create button
        private void s_addBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it creates a new staff record
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "field" || checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: record details are missing!");
            }
            else
            {
                var details = new StaffDetails
                {
                    name = s_nameBOX.Text,
                    email_address = s_emailBOX.Text,
                    password = s_passwordBOX.Text,
                    phone_number = s_phoneBOX.Text,
                    department = s_departmentBOX.Text,
                    street = s_streetBOX.Text,
                    city = s_cityBOX.Text,
                    postal_code = s_postalBOX.Text,
                    country = s_countryBOX.Text
                };

                createStaff(details);
            }
            showStaff();
        }



        // read trigger
        private void s_LIST_SelectionChanged(object sender, EventArgs e)
        {
            // when selection is changed in table, it executes read staff

            readStaff();
        }



        // update button
        private void s_updateBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it updates the staff record with user-defined values
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: record details are missing & no record is selected!");
                
            }
            else if (checkAll() == "field")
            {
                MessageBox.Show("ERROR: record details are missing!");
            }
            else if (checkAll() == "selection")
            {
                MessageBox.Show("ERROR: no record is selected!");
            }
            else
            {
                DataGridViewRow selectedRow = s_LIST.SelectedRows[0];

                int staff_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int address_id = Convert.ToInt32(selectedRow.Cells["address_id"].Value);

                var details = new StaffDetails
                {
                    name = s_nameBOX.Text,
                    email_address = s_emailBOX.Text,
                    password = s_passwordBOX.Text,
                    phone_number = s_phoneBOX.Text,
                    department = s_departmentBOX.Text,
                    street = s_streetBOX.Text,
                    city = s_cityBOX.Text,
                    postal_code = s_postalBOX.Text,
                    country = s_countryBOX.Text
                };

                updateStaff(staff_id, address_id, details);
            }
            showStaff();
        }



        // delete button
        private void s_deleteBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it deletes the selected staff record
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox

            if (checkAll() == "selection" || checkAll() == "field and selection")
            {
                MessageBox.Show("ERROR: no record is selected!");
            }
            else
            {
                DataGridViewRow selectedRow = s_LIST.SelectedRows[0];

                int staff_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int address_id = Convert.ToInt32(selectedRow.Cells["address_id"].Value);

                deleteStaff(staff_id, address_id);
            }
            showStaff();
        }



        // search trigger
        private void s_searchBOX_TextChanged(object sender, EventArgs e)
        {
            // when text is changed in search box, it executes search staff

            searchStaff(s_searchBOX.Text);
        }



        // load form method
        private void loadForm()
        {
            s_departmentBOX.SelectedIndex = -1;

            if (functions.getUserType() == "customer")
            {
                int id = functions.extractInt(functions.getCustomerInfo());
                string name = functions.extractString(functions.getCustomerInfo());
                string info = $"Logged in as: {name} ({id})";

                s_userLABEL.Text = info;
            }
            else if (functions.getUserType() == "admin")
            {
                s_userLABEL.Text = "Logged in as: Admin (0)";
            }
        }



        // display method
        private void showStaff()
        {
            s_LIST.DataSource = functions.getData("SELECT s.id AS id, s.name AS name, s.email_address AS email_address, s.password AS password, s.phone_number AS phone_number, s.department AS department, a.id AS address_id, a.street AS street, a.city AS city, a.postal_code AS postal_code, a.country AS country FROM Staff s INNER JOIN Address a ON s.address_id = a.id");
        }



        // clear method
        private void clearAll()
        {
            s_LIST.ClearSelection();

            s_nameBOX.Text = "";
            s_emailBOX.Text = "";
            s_passwordBOX.Text = "";
            s_phoneBOX.Text = "";
            s_departmentBOX.Text = "";
            s_streetBOX.Text = "";
            s_cityBOX.Text = "";
            s_postalBOX.Text = "";
            s_countryBOX.Text = "";
            s_searchBOX.Text = "";
        }



        // check method
        private string checkAll()
        {
            bool empty_field = s_nameBOX.Text == "" || s_emailBOX.Text == "" || s_passwordBOX.Text == "" || s_phoneBOX.Text == "" || s_departmentBOX.Text == "" || s_streetBOX.Text == "" || s_cityBOX.Text == "" || s_postalBOX.Text == "" || s_countryBOX.Text == "";

            bool empty_selection = s_LIST.SelectedRows.Count <= 0;

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
        private void searchStaff(string word)
        {
            // searches through the staff table via keywords in search box and SQL

            string query = "SELECT s.id AS id, s.name AS name, s.email_address AS email_address, s.password AS password, s.phone_number AS phone_number, s.department AS department, a.id AS address_id, a.street AS street, a.city AS city, a.postal_code AS postal_code, a.country AS country FROM Staff s INNER JOIN Address a ON s.address_id = a.id WHERE s.id LIKE @word OR s.name LIKE @word OR s.email_address LIKE @word OR s.phone_number LIKE @word OR s.department LIKE @word OR a.country LIKE @word";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@word", "%" + word + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable datatable = new DataTable();

                adapter.Fill(datatable);

                s_LIST.DataSource = datatable;

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }


        
        // clear button
        private void s_clearBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it makes all fields blank

            clearAll();
        }



        // refresh button
        private void s_refreshBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it refreshes the staff table

            showStaff();
        }



        // customer button
        private void s_customerBUTTON_Click(object sender, EventArgs e)
        {
            functions.customerForm(this);
        }


        // order button
        private void s_orderBUTTON_Click(object sender, EventArgs e)
        {
            functions.orderForm(this);
        }



        // product button
        private void s_productBUTTON_Click(object sender, EventArgs e)
        {
            functions.productForm(this);
        }



        // supplier button
        private void s_supplierBUTTON_Click(object sender, EventArgs e)
        {
            functions.supplierForm(this);
        }



        // logout button
        private void s_logoutBUTTON_Click(object sender, EventArgs e)
        {
            functions.loginForm(this);
        }
    }
}
