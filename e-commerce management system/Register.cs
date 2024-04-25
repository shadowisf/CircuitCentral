using System.Data.SqlClient;
using System.Numerics;

namespace e_commerce_management_system
{
    public partial class Register : Form
    {
        Function functions = new Function();

        // assigns connection string from program.cs
        string ConnectionString = Function.ConnectionString;



        public Register()
        {
            InitializeComponent();

            clearAll(); // clears all fields
        }



        // register method
        private void registerCustomer(CustomerDetails details)
        {
            // create new customer record with user-defined values

            string query = "INSERT INTO Customer VALUES(@name, @email_address, @password, @phone_number, @address_id);";

            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox


                try
                {
                    // create new connection and open that connection
                    SqlConnection connection = new SqlConnection(ConnectionString);

                    connection.Open();

                    // execute create address method to get id of newly added address details and assigns it to a variable
                    int address_id = functions.createAddress(connection, details.street, details.city, details.postal_code, details.country);

                    SqlCommand c_command = new SqlCommand(query, connection);
                    c_command.Parameters.AddWithValue("@name", details.name);
                    c_command.Parameters.AddWithValue("@email_address", details.email_address);
                    c_command.Parameters.AddWithValue("@password", details.password);
                    c_command.Parameters.AddWithValue("@phone_number", details.phone_number);
                    c_command.Parameters.AddWithValue("@address_id", address_id);

                    c_command.ExecuteNonQuery();

                    // executes query and closes the connection
                    connection.Close();

                    MessageBox.Show("SUCCESS: registration completed!");
                    functions.loginForm(this);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }



        // clear method
        private void clearAll()
        {
            // makes all fields blank

            r_nameBOX.Text = "";
            r_emailBOX.Text = "";
            r_passwordBOX.Text = "";
            r_phoneBOX.Text = "";
            r_lineBOX.Text = "";
            r_cityBOX.Text = "";
            r_postalBOX.Text = "";
            r_countryBOX.Text = "";
        }



        // check method
        private string checkAll()
        {
            // checks every field and return what is the error

            if (r_nameBOX.Text == "" || r_emailBOX.Text == "" || r_passwordBOX.Text == "" || r_phoneBOX.Text == "" || r_lineBOX.Text == "" || r_cityBOX.Text == "" || r_postalBOX.Text == "" || r_countryBOX.Text == "")
            {
                return "no details";
            }
            return "its ok :)";
        }


        
        // clear button
        private void r_clearBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it clears all fields

            clearAll();
        }



        // register button
        private void r_registerBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it executes register customer
            if (checkAll() == "no details")
            {
                MessageBox.Show("ERROR: registration details are missing!");
            }
            else
            {
                var details = new CustomerDetails
                {
                    name = r_nameBOX.Text,
                    email_address = r_emailBOX.Text,
                    password = r_passwordBOX.Text,
                    phone_number = r_phoneBOX.Text,
                    street = r_lineBOX.Text,
                    city = r_cityBOX.Text,
                    postal_code = r_postalBOX.Text,
                    country = r_countryBOX.Text
                };

                registerCustomer(details);
            }
            clearAll();
        }



        // login button
        private void r_linkBUTTON_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            functions.loginForm(this);
        }
    }
}
