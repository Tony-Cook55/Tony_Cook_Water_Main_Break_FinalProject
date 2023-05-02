using System.Windows.Forms;
using System.Xml.Linq;

namespace Kirkwood_Water_Department_Final_Project
{
    public partial class Login_Report : Form
    {

        Thread th;

        public Login_Report()
        {
            InitializeComponent();



            //This allows the water flow image to be transparent over the pipeline picture idk why but it works
            pbPipeBreakBackground.Controls.Add(pbWaterFlowGIF);
            //                       (LEFT + RIGHT , UP + DOWN);
            pbWaterFlowGIF.Location = new Point(500, 530);
            pbWaterFlowGIF.BackColor = Color.Transparent;


            ////If i want a picture or gif behind the pipes this is how
            //pbHUGE.Controls.Add(pbPipeBreakBackground);
            //pbPipeBreakBackground.Location = new Point(0, 0);
            //pbPipeBreakBackground.BackColor = Color.Transparent;




        }




        //Employee List info
        List<Employee> employeesList = new List<Employee>()
        {
            //string employeeFirstName , string employeeLastName, string phoneNumber, string username, string password, int employeeID
            new Employee("Test", "Worker", "(000)-000-000", "123", "123", 0000),
            new Employee("Tony", "Cook", "(314) 423-7231", "1", "1", 1923),
            new Employee("Matt", "Maiden", "(314) 917-7363", "2", "2", 0183),
            new Employee("Mike", "Pitchford", "(314) 675-9165", "3", "3", 2087),
            new Employee("Rich", "French", "(513) 526-1297", "4", "4", 2574),
            new Employee("Randy", "Duvall", "(318) 762-1872", "5", "5", 6093),
            new Employee("John", "Reed", "(314) 143-1092", "6", "6", 7532),
            new Employee("Aj", "Basuert", "(314) 893-2934", "7", "7", 8513),
            new Employee("Don", "Holt", "(314) 597-4703", "8", "8", 8690),
            new Employee("Jason", "Schellhamer", "(314) 518-9235", "9", "9", 5387),
        };




        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! CHANGES COLOR BASED ON FOCUS OF TEXTBOX !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // USERNAME TEXTBOX
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            //txtUsername.BackColor = Color.LightBlue;

            var convertColors = new System.Drawing.ColorConverter();
            var HotTrackBlueColor = (System.Drawing.Color)convertColors.ConvertFromString("#0066CC");

            txtUsername.BackColor = HotTrackBlueColor;

            txtUsername.ForeColor = Color.White;

        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;

            txtUsername.ForeColor = Color.Black;
        }

        //PASSWORD TEXTBOX
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //txtPassword.BackColor = Color.LightBlue;
            var convertColors = new System.Drawing.ColorConverter();
            var HotTrackBlueColor = (System.Drawing.Color)convertColors.ConvertFromString("#0066CC");

            txtPassword.BackColor = HotTrackBlueColor;

            txtPassword.ForeColor = Color.White;

        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;

            txtPassword.ForeColor = Color.Black;

        }

        //FOR BOTH BUTTONS LEAVING AND ENTERING FOCUS
        private void Buttons_Enter_Focus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.White;

            // b.ForeColor= Color.White;
        }

        private void Buttons_Leave_Focus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.LightSkyBlue;
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~ OPENS THE SUCCSESSFUL EMPLOYEE LOGIN FORM ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // LOGIN IN BUTTON
        private void btnLogin_Click(object sender, EventArgs e)
        {

            lblError.Visible = false;

            
                string username = txtUsername.Text;
                string password = txtPassword.Text;


            for (int i = 0; i < employeesList.Count; i++)
            {
                //If users inputted text matches whats in the username and password list it will do the following
                if (employeesList[i].Username == username && employeesList[i].Password == password)
                {


                    //Hides the current form 
                    this.Close();

                    //Does code magic to allow the new form to open upon this form closing
                    th = new Thread(Open_Successful_Login);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();



                    //// Makes a new instance of the Successfull Employee Login, Shows it, Then Changes that forms name to Welcome (name the user put data in for)
                    //Successful_Login success = new Successful_Login();
                    //success.Show();
                    //Successful_Login.ActiveForm.Text = $"Welcome {employeesList[i].EmployeeFirstName}";



                }
                else
                {
                    lblError.Visible = true;
                }



            }// end of for loop


        }// end of LOGIN IN BUTTON




        //OPENS THE SUCCSESSFUL_LOGIN FORM
        private void Open_Successful_Login(object obj)
        {
            Application.Run(new Successful_Login());
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~








        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!! OPENS THE USER REPORT FORM !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


        // REPORT WATER MAIN BREAK BUTTON
        private void btnReportBreak_Click(object sender, EventArgs e)
        {

            //Hides the current form 
            this.Close();

            //Does code magic to allow the new form to open upon this form closing
            th = new Thread(Open_Water_Main_Report_Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();




            // Makes a new instance eof the Successfull Employee Login
            Watermain_Report_Form waterMainReport = new Watermain_Report_Form();

            waterMainReport.Show();




        }// end of REPORT WATER MAIN BREAK BUTTON





        //OPENS THE WATERMAIN_REPORT_FORM 
        private void Open_Water_Main_Report_Form(object obj)
        {
            Application.Run(new Watermain_Report_Form());
        }



        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



        //KIRKWOOD LOGO PICTURE CAN BE CLICKED TO DISPLAY INFO
        private void pbKirkwoodLogoInfo_Click(object sender, EventArgs e)
        {
            DialogResult sumbittedForm = MessageBox.Show
               ("This is a program that allows people to submit a report if there are any Water Main Breaks in the City of Kirkwood.\n\n" +
               "This also allows Employees of the City of Kirkwood Water Department to Log in and see the reports that people have submitted.\n" +
               "\nThere are a total of 9 Employees. But you may use this login to see all the information they can see:" +
               "\nUsername: 123" +
               "\nPassword:  123"


               , "Information About the Application"
               , MessageBoxButtons.OK
               , MessageBoxIcon.Information);
        }

        
    }// end of form
}