namespace IT481U3
{
    public partial class Form1 : Form
    {
        //Creating a connection from Controller to form1 called controller.
        //Declaring variables for user, password, server, and database.
        Controller controller;
        private string user;
        private string password;
        private string server;
        private string database;

        //Event Handler for buttons and pre-filled text for server and database connection.
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "desktop-hp19nsb";
            textBox4.Text = "northwind";
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);
        }

        //Button 1 connection to the database
        private void button1_Click(object sender, EventArgs e)
        {
            //isValid to determine if text boxes are filled.
            bool isValid = true;

            //Declared variables getting the input text from the text boxes
            user = textBox1.Text;
            password = textBox2.Text;
            server = textBox3.Text;
            database = textBox4.Text;

            //Determining if the text boxes are filled in.
            if (user.Length == 0 || password.Length == 0 ||
                server.Length == 0 || database.Length == 0)
            {
                isValid = false;
                MessageBox.Show("You must enter user name, password, server, and database values");
            }

            //If fields are filled then connection to database is sent.
            if (isValid)
            {
                controller = new Controller("Server =" + server + "\\SQLEXPRESS;" +
                                        "Database =" + database + ";" +
                                        "User ID =" + user + ";" +
                                        "Password =" + password + ";"
                                        );

                MessageBox.Show("Connection Information Sent");
            }
        }

        //button2 getting customer count with query in Controller.
        private void button2_Click(object sender, EventArgs e)
        {
            string count = controller.getCustomerCount();
            MessageBox.Show(count, "Customer count");
        }

        //button3 getting company names with query in Controller.
        private void button3_Click(object sender, EventArgs e)
        {
            string names = controller.getCompanyNames();
            MessageBox.Show(names, "Company names");
        }

        //button4 getting order ship count with query in Controller.
        private void button4_Click(object sender, EventArgs e)
        {
            string count = controller.getOrderShipCount();
            MessageBox.Show(count, "Order ship count");
        }

        //button5 getting order ship names with query in Controller.
        private void button5_Click(object sender, EventArgs e)
        {
            string names = controller.getShipNames();
            MessageBox.Show(names, "Order Ship Names");
        }

        //button6 getting employee count with query in Controller.
        private void button6_Click(object sender, EventArgs e)
        {
            string count = controller.getEmployeeCount();
            MessageBox.Show(count, "Employee Count");
        }

        //button7 getting employee names with query in Controller.
        private void button7_Click(object sender, EventArgs e)
        {
            string names = controller.getEmployeeNames();
            MessageBox.Show(names, "Employee names");
        }

    }
}