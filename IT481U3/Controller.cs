using System;
using System.Data.SqlClient;

namespace IT481U3
{
    internal class Controller
    {
        string connectionString;
        SqlConnection cnn = null;

        //Creating connection to SQL Database
        public Controller()
        {
            connectionString = "";
        }

        public Controller(string conn)
        {
            connectionString = conn;
        }


        //Get the customer count from the SQL database
        public string getCustomerCount()
        {
            Int32 count = 0;

            //Create new SQL connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Create Query
            string countQuery = "select count(*) from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }

        //Get the company names from the SQL database
        public string getCompanyNames()
        {
            string names = "";
            SqlDataReader dataReader;

            //Create new SQL connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Create query
            string countQuery = "select companyname from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return names;
        }

        //Get the Order ship count from the SQL database
        public string getOrderShipCount()
        {
            Int32 count = 0;

            //Create new SQL connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Create Query
            string countQuery = "select count(*) from orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }
        //Get the Order Ship names from the SQL database
        public string getShipNames()
        {
            string names = "";
            SqlDataReader dataReader;

            //Create new SQL connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Create query
            string countQuery = "select shipname from orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            try
            {
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return names;
        }

        //Get the Employee count from the SQL database
        public string getEmployeeCount()
        {
            Int32 count = 0;

            //Create new SQL connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Create Query
            string countQuery = "select count(*) from employees;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }

        //Get the Employee names from the SQL database
        public string getEmployeeNames()
        {
            string names = "";
            SqlDataReader dataReader;

            //Create new SQL connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Create query
            string countQuery = "select FirstName + '' + LastName from employees;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            try
            {
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return names;
        }
    }
}
