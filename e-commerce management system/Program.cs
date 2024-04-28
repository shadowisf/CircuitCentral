using System.Data;
using System.Data.SqlClient;

namespace e_commerce_management_system
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }



    public class Function
    {
        // INSERT CONNECTION STRING INSDE CONSTANT VARIABLE BELOW
        public const string ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=CircuitCentral;Integrated Security=True;Encrypt=False";

        // CHANGE ADMIN CREDENTIALS IF NEEDED
        public const string adminEmail = "admin";
        public const string adminPassword = "admin";



        // insert address method
        public int createAddress(SqlConnection connection, string street, string city, string postal_code, string country)
        {
            string query = "INSERT INTO Address VALUES(@street, @city, @postal_code, @country); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@street", street);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@postal_code", postal_code);
            command.Parameters.AddWithValue("@country", country);

            return Convert.ToInt32(command.ExecuteScalar());
        }



        // update address method
        public void updateAddress(SqlConnection connection, string street, string city, string postal_code, string country, int address_id)
        {
            string query = "UPDATE Address SET street = @street, city = @city, postal_code = @postal_code, country = @country WHERE id = @address_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@street", street);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@postal_code", postal_code);
            command.Parameters.AddWithValue("@country", country);
            command.Parameters.AddWithValue("@address_id", address_id);

            command.ExecuteNonQuery();
        }



        // create transaction method
        public int createTransaction(SqlConnection connection, string payment_method)
        {
            string query = "INSERT INTO [Transaction] VALUES (@total_amount, @payment_method, @date, @status); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@total_amount", 0M);
            command.Parameters.AddWithValue("@payment_method", payment_method);
            command.Parameters.AddWithValue("@date", DateTime.Today);
            command.Parameters.AddWithValue("@status", "pending");

            return Convert.ToInt32(command.ExecuteScalar());
        }



        // create order method
        public int createOrder(SqlConnection connection, int customer_id, int transaction_id)
        {
            string query = "INSERT INTO [Order] VALUES (@customer_id, @transaction_id, @date, @status); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@customer_id", customer_id);
            command.Parameters.AddWithValue("@transaction_id", transaction_id);
            command.Parameters.AddWithValue("@date", DateTime.Today);
            command.Parameters.AddWithValue("@status", "pending");

            return Convert.ToInt32(command.ExecuteScalar());
        }



        // create orderdetail method
        public void createOrderDetail(SqlConnection connection, int order_id, int product_id, int transaction_id, decimal unit_price, int quantity, decimal total_amount)
        {
            string query = "INSERT INTO OrderDetail VALUES (@order_id, @product_id, @unit_price, @quantity); UPDATE [Transaction] SET total_amount = @total_amount WHERE id = @transaction_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@order_id", order_id);
            command.Parameters.AddWithValue("@product_id", product_id);
            command.Parameters.AddWithValue("@transaction_id", transaction_id);
            command.Parameters.AddWithValue("@unit_price", unit_price);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@total_amount", total_amount);

            command.ExecuteNonQuery();
        }



        // update transaction method
        public void updateTransaction(SqlConnection connection, int transaction_id, TransactionDetails details)
        {
            string query = "UPDATE [Transaction] SET date = @date, payment_method = @payment_method, status = @transaction_status WHERE id = @transaction_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@date", details.date);
            command.Parameters.AddWithValue("@payment_method", details.payment_method);
            command.Parameters.AddWithValue("@transaction_status", details.transaction_status);
            command.Parameters.AddWithValue("@transaction_id", transaction_id);

            command.ExecuteNonQuery();
        }



        // get data method
        public DataTable getData(string query)
        {
            DataTable datatable = new DataTable();

            using SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            datatable.Load(reader);

            return datatable;
        }



        // get data with image method
        public DataTable getDataWithImage(string query)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);

            datatable.Columns.Add("image", Type.GetType("System.Byte[]"));
            foreach (DataRow row in datatable.Rows)
            {
                row["image"] = File.ReadAllBytes(row["image_link"].ToString());
            }
            return datatable;
        }



        // extract integer method
        public int extractInt(string text)
        {
            string[] parts = text.Split('-');
            if (parts.Length == 2 && int.TryParse(parts[0].Trim(), out int value))
            {
                return value;
            }
            else
            {
                return 0;
            }
        }



        // extract string method
        public string extractString(string text)
        {
            string[] parts = text.Split('-');
            if (parts.Length == 2)
            {
                return parts[1].Trim();
            }
            else
            {
                // If the format is not as expected, you may want to handle this case differently
                return "";
            }
        }



        // get customer info
        public string getCustomerInfo()
        {
            string query = "SELECT CONCAT(id, ' - ', name) AS id_name FROM Customer WHERE id = @user_id";

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user_id", Constant.user_id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string customer = reader["id_name"].ToString();
                    return customer;
                }
            }
            return "";
        }



        // get user type method
        public string getUserType()
        {
            int id = Constant.user_id;

            if (id == 0)
            {
                return "admin";
            }
            else
            {
                return "customer";
            }
        }



        // go to customer form method
        public void customerForm(Form currentForm)
        {
            Customer newForm = new Customer();
            newForm.Show();
            currentForm.Hide();
        }



        // go to order form method
        public void orderForm(Form currentForm)
        {
            Order newForm = new Order();
            newForm.Show();
            currentForm.Hide();
        }



        // go to product form method
        public void productForm(Form currentForm)
        {
            Product newForm = new Product();
            newForm.Show();
            currentForm.Hide();
        }



        // go to staff form method
        public void staffForm(Form currentForm)
        {
            Staff newForm = new Staff();
            newForm.Show();
            currentForm.Hide();
        }



        // go to supplier form method
        public void supplierForm(Form currentForm)
        {
            Supplier newForm = new Supplier();
            newForm.Show();
            currentForm.Hide();
        }



        // go to login form method
        public void loginForm(Form currentForm)
        {
            Login newForm = new Login();
            newForm.Show();
            currentForm.Hide();
        }



        // go to register form method
        public void registerForm(Form currentForm)
        {
            Register newForm = new Register();
            newForm.Show();
            currentForm.Hide();
        }
    }



    // user id class
    public static class Constant
    {
        public static int user_id
        {
            get;
            set;

        } = 0;
    }



    // customer details class
    public class CustomerDetails
    {
        public string name { get; set; }
        public string email_address { get; set; }
        public string password { get; set; }
        public string phone_number { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }




    // staff details class
    public class StaffDetails
    {
        public string name { get; set; }
        public string email_address { get; set; }
        public string password { get; set; }
        public string phone_number { get; set; }
        public string department { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }



    // supplier details class
    public class SupplierDetails
    {
        public string name { get; set; }
        public string email_address { get; set; }
        public string phone_number { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }



    // product details class
    public class ProductDetails
    {
        public string name { get; set; }
        public string image_link { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int supplier_id { get; set; }
    }



    // order details class
    public class TransactionDetails
    {
        public DateTime date { get; set; }
        public string transaction_status { get; set; }
        public string order_status { get; set; }
        public string payment_method { get; set; }
    }
}