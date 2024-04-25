using System.Data.SqlClient;
using System.Net.Mail;

namespace e_commerce_management_system
{
    public partial class Login : Form
    {
        Function functions = new Function();

        // assigns connection string from program.cs
        string ConnectionString = Function.ConnectionString;

        // assigns admin details from program.cs
        string adminEmail = Function.adminEmail;
        string adminPassword = Function.adminPassword;


        
        public Login()
        {
            InitializeComponent();

            clearAll(); // clears all fields
        }



        // login method
        private void loginUser(string email_address, string password)
        {
            // user attemps to login with inserted credentials
 
            try
            {
                // create new connection and open that connection
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                int result = checkUser(connection, email_address, password);

                if (email_address == adminEmail && password == adminPassword)
                {
                    Constant.user_id = 0;
                    functions.customerForm(this);
                }
                else
                {
                    // if customer details are correct, assign user id as customer id and proceed to product management
                    // note that user id is project-wide and is used on every forms especially when creating orders

                    Constant.user_id = result;
                    functions.productForm(this);

                    
                }
                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }



       // check user
       private int checkUser(SqlConnection connection, string email_address, string password)
        {
            string query = "SELECT id FROM Customer WHERE email_address = @email_address AND password = @password";

            // insert user-defined values with respective query vaulues
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@email_address", email_address);
            command.Parameters.AddWithValue("@password", password);

            // execute scalar to get customer id of customer and assign it to a variable
            int result = Convert.ToInt32(command.ExecuteScalar());

            return result;
        }



        // clear method
        private void clearAll()
        {
            // makes all fields blank

            l_emailBOX.Text = "";
            l_passwordBOX.Text = "";
        }



        // check method
        private string checkAll()
        {
            // checks every field and return what is the error

            if (l_emailBOX.Text == "" || l_passwordBOX.Text == "")
            {
                return "no details";
            }
            return "its ok :)";
        }



        // login button
        private void l_loginBUTTON_Click(object sender, EventArgs e)
        {
            // when this button is clicked, it executes login user
            // before execution, error handling occurs where it checks for possible errors and prints it in MessageBox
            if (checkAll() == "no details")
            {
                MessageBox.Show("ERROR: login details are missing!");
            }
            else
            {
                loginUser(l_emailBOX.Text, l_passwordBOX.Text);
            }
        }



        // register button
        private void l_registerBUTTON_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            functions.registerForm(this);
        }
    }
}
