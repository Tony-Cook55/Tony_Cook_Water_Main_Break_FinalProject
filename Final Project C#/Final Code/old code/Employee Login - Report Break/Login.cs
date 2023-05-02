namespace Employee_Login___Report_Break
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        //Employee List info
        List<Employee> employeesList = new List<Employee>()
        {
            //string employeeFirstName , string employeeLastName, string phoneNumber, string username, string password, int employeeID
            new Employee("Tony", "Cook", "(314) 423-7231", "1", "1", 1234),
            new Employee("Owen", "Garrett", "(314) 917-7363", "2", "2", 1234),
            new Employee("Jackson", "Fendler", "(314) 675-9165", "3", "3", 1234),
            new Employee("Matt", "Pelich", "(513) 526-1297", "4", "4", 1234),
            new Employee("Julio", "Flores", "(318) 762-1872", "5", "5", 1234),
            new Employee("David", "Jolly", "(314) 143-1092", "6", "6", 1234),
            new Employee("Logan", "Michell", "(314) 893-2934", "7", "7", 1234),
            new Employee("Franklin", "Londell", "(314) 597-4703", "8", "8", 1234),
        };





        //LOGIN BUTTON
        private void btnLogin_Click(object sender, EventArgs e)
        {

            //User input
            string username = txtUsername.Text;
            string password = txtPassword.Text;



            for (int i = 0; i < employeesList.Count; i++)
            {

                if (employeesList[i].Username == username && employeesList[i].Password == password)
                {
                    // resets the error label
                    lblError.Text = "";

                    //Hides this form
                    this.Hide();

                    //Makes a new instance of the SuccsessFull login form
                    Succsessful_LoginForm succsess = new Succsessful_LoginForm();

                    //shows the second form 
                    succsess.Show();





                    // changes what the title bar of the form says were making it welcome user upon succsessful login
                    Succsessful_LoginForm.ActiveForm.Text = $"Welcome {employeesList[i].EmployeeFirstName}"; ;


                    break;
                }
                else
                {
                    lblError.Text = "Invalid Username or Password";
                }

            }

        }// end of login BUTTON


        //REPORT WATER MAIN BREAK BUTTON    once clicked will take us to form to report a break
        private void btnReportBreak_Click(object sender, EventArgs e)
        {



            //Hides this form
            this.Hide();

            //Makes a new instance of the SuccsessFull login form
            Watermain_Report_Page report = new Watermain_Report_Page();

            //shows the second form 
            report.Show();



        }//end of REPORT WATER MAIN BREAK BUTTON

















    }// end of form
}