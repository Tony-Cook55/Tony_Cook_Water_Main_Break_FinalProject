using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Kirkwood_Water_Department_Final_Project
{
    public partial class Successful_Login : Form
    {
        //FOR TAKING US TO NEW FORMS
        Thread th;


        ReportsContext reportsDatabase;

        List<Reports> reportsList;


        //~~~~~~~~~~~~~~~~~~~~~~~~~~ This is for SEARCHING ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //SEARCHING BY ID
        private int _searchByID;
        private Reports? searchUpdatedByID;
        //END OF SEARCHING BY ID

        //SEARCH BY NAME 
        private string _searchByName;
        private Reports? searchUpdatedByName;
        //END OF SEARCHING BY NAME

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        //!!!!!!!!!!!!!!!!!!!!!!!!! This is for the UPDATE REPORT COMBOBOX AND BUTTON !!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private int _submissionFormID;
        private Reports? updateReportInfo;
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!




        //Employee List info
        List<Employee> employeesList = new List<Employee>()
        {
            //string employeeFirstName , string employeeLastName, string phoneNumber, string username, string password, int employeeID
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



        public Successful_Login()
        {

           


            reportsDatabase = new ReportsContext();  // lets us access the class for the table

            

            InitializeComponent();


            //This adds this text to the title of this form it adds the current day of the week
            DayOfWeek dayOfWeek = DateTime.Today.DayOfWeek;
            this.Text += $" Today Is {dayOfWeek}";



            //r represents our reports     select our reports and select what you want from r
            reportsList = reportsDatabase.ReportedBreaks.Select(r => r).ToList(); //<-- converts data into a list


            //lopping through our customer list using a method
            ShowReports();


            //Shows us the employees working based on the current day the user signs in
            ShowEmployees();


            //This changes the user reports to turn blue 
            rtbUserReports.ForeColor = Color.White;
            rtbEmployeesWorking.ForeColor = Color.White;

            



        }// end of  InitializeComponent();




        //LITTERALY THE HUGE BUTTON THAT ASKS IF YOU WANT TO SEARCH
        //This can be delete and nothign would change its here to make the form look less cluttered upon open 
        private void btnShowSearchOptions_Click(object sender, EventArgs e)
        {
            btnShowSearchOptions.Visible = false;
        }








        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! SHOWREPORTS METHOD !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Method that allows you to loop through the reports
        private void ShowReports()
        {
            //emptys rich textbox to be refreshed with new info
            rtbUserReports.Text = string.Empty;

            reportsList = reportsDatabase.ReportedBreaks.Select(r => r).ToList();

            //Clears all the combobox items so it can be refreshed with new items (Ensures items dont stack on each other)
            cboSearchByID.Items.Clear();
            cboSearchByName.Items.Clear();
            cboDeleteByID.Items.Clear();

            cboUpdateByID.Items.Clear();
            txtUpdateName.Text = string.Empty;
            txtUpdateVisableProblem.Text = string.Empty;
            txtUpdateBreakLocation.Text = string.Empty;



            foreach (Reports report in reportsList)
            {
                //Displays the database contents in the richtextbox
                rtbUserReports.Text += report.ToString();

                //This will populate the SEACH by Submission Form With the report ID
                cboSearchByID.Items.Add(report.ReportNumberId);

                //This will populate the SEARCH by name combobox with all the names
                cboSearchByName.Items.Add(report.Name);

                //This will populate the DELETE By ID comboBox 
                cboDeleteByID.Items.Add(report.ReportNumberId);

                //This will populate the UPDATE by ID combobox
                cboUpdateByID.Items.Add(report.ReportNumberId);
            }

        }
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!





        //###################################### SEARCHING IN THE DATABASE ##################################################


        //SEARCHS BY THE ID ONCE THE COMBOBOX ITEM HAS BEEN SELECTED
        private void cboSearchByID_SelectedIndexChanged(object sender, EventArgs e)
        {

            _searchByID = (int)cboSearchByID.SelectedItem;

            searchUpdatedByID = reportsDatabase.ReportedBreaks.Find(_searchByID);

            if (searchUpdatedByID != null)
            {
                rtbUserReports.Text = searchUpdatedByID.ToString();
            }


        }// end of SEARCH BY ID ON COMBOBOX CILCK 



        //          DISABLED               =======================================          DISABLED               
        //Search By ID BUTTON --- THIS HAS BEEN DISABLED BUT IF VISABLE WILL ALLOW USER TO SEARCH BY BUTTON CLICK
        private void btnSearchByProblem_Click(object sender, EventArgs e)
        {
            rtbUserReports.Text = string.Empty;

            int searchedID = (int)cboSearchByID.SelectedItem;

            //string serachedProblem = txtSearchByProblem.Text.ToLower();

            Reports? findID = reportsDatabase.ReportedBreaks.Where(r => r.ReportNumberId == searchedID).FirstOrDefault();

            if (findID != null)
            {
                rtbUserReports.Text = findID.ToString();
            }

        }// end of Search By ID BUTTON
         //          DISABLED               =======================================          DISABLED            






        //SEARCHS BY NAME ON COMBOBOX CHANGE 
        private void cboSearchByName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string searchedName = (string)cboSearchByName.SelectedItem;

            Reports? findName = reportsDatabase.ReportedBreaks.Where(r => r.Name == searchedName).FirstOrDefault();

            if (findName != null)
            {
                rtbUserReports.Text = findName.ToString();
            }



        }// end of SEARCH BY NAME ON COMBOBOX CHANGE 



        //          DISABLED               =======================================          DISABLED
        //Search by NAME BUTTON   --- THIS HAS BEEN DISABLED BUT IF VISABLE WILL ALLOW USER TO SEARCH BY BUTTON CLICK
        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            //rtbUserReports.Text = string.Empty;

            string searchedName = (string)cboSearchByName.SelectedItem;

            Reports? findName = reportsDatabase.ReportedBreaks.Where(r => r.Name == searchedName).FirstOrDefault();

            if (findName != null)
            {
                rtbUserReports.Text = findName.ToString();
            }

        }// end of Search by Name BUTTON
         //          DISABLED               =======================================          DISABLED            


         //######################################################################################################################



        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ DELETING FROM THE DATABASE $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        private void btnDeleteByID_Click(object sender, EventArgs e)
        {

            //int deleteByID = (int)cboDeleteByID.SelectedItem;

            //Reports? deleteID = reportsDatabase.ReportedBreaks.Find(deleteByID);

            //if (deleteID != null) 
            //{
                try
                {
                    int deleteByID = (int)cboDeleteByID.SelectedItem;

                    Reports? deleteID = reportsDatabase.ReportedBreaks.Find(deleteByID);


                    reportsDatabase.ReportedBreaks.Remove(deleteID);
                    reportsDatabase.SaveChanges();
                    ShowReports();
                }
                catch (NullReferenceException ex) // THIS IS SHOWN WHEN DELETE IS CLICKED BEFORE ANYTHIGN IN INPUTTED IN COMBOBOX
                {

                    MessageBox.Show("Please Input A ID To Delete It", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw ex;
                }
               
            //} 

        }// end of DELTE BY ID BUTTON

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$



        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ UPDATING TO THE DATABASE ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        private void cboUpdateByID_SelectedIndexChanged(object sender, EventArgs e)
        {
            _submissionFormID = (int)cboUpdateByID.SelectedItem;

            updateReportInfo = reportsDatabase.ReportedBreaks.Find(_submissionFormID);

            if (updateReportInfo != null) 
            { 
                txtUpdateName.Text = updateReportInfo.Name;
                txtUpdateVisableProblem.Text = updateReportInfo.VisableProblem;
                txtUpdateBreakLocation.Text = updateReportInfo.BreakLocation;
            }

        }// END OF UPDATE BY ID COMBOBOX 


        //UPDATE BY ID BUTTON
        private void btnUpdateByID_Click(object sender, EventArgs e)
        {
            if (updateReportInfo != null)
            {
                updateReportInfo.Name = txtUpdateName.Text;

                updateReportInfo.VisableProblem = txtUpdateVisableProblem.Text;

                updateReportInfo.BreakLocation = txtUpdateBreakLocation.Text;

                try
                {
                    reportsDatabase.ReportedBreaks.Update(updateReportInfo);
                    reportsDatabase.SaveChanges();
                    ShowReports();
                }
                catch (Exception)
                {

                    
                }
            }
        }// END OF UPDATE BY ID BUTTON

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% RESETS THE TEXTBOX AFTER A SEARCH %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        private void btnResetBreaks_Click(object sender, EventArgs e)
        {
            ShowReports();
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%












        //++++++++++++++++++++++++++++++++++++++++ CURRENTLY WORKING EMPLOYEES ++++++++++++++++++++++++++++++++++++++++++



        // THIS IS THE METHOD THAT ALLOWS US TO SHOW ALL THE INFO ABOUT THE EMPLOYYEES like Names, Current date and weekday
        private void ShowEmployees()
        {
            rtbEmployeesWorking.Text = string.Empty;

            //Shows the current date 
            var currentDate = DateOnly.FromDateTime(DateTime.Now);

            //Gets the current day of the week     {dayOfWeek}
            DayOfWeek dayOfWeek = DateTime.Today.DayOfWeek;

            // GETS THE CURRENT TIME
            //DateTime dateTime= DateTime.Now;


            //Displays the current date
            lblCurrentDate.Text = $"Todays Date Is: {currentDate.ToString()}";


            // Lets us pick and choose between all of our employees from the list by using thier first name
            Employee Tony = employeesList[0]; //9
            Employee Matt = employeesList[1]; //5
            Employee Mike = employeesList[2]; //6
            Employee Rich = employeesList[3]; //8
            Employee Randy = employeesList[4]; //7
            Employee John = employeesList[5]; //4
            Employee Aj = employeesList[6]; // 1
            Employee Don = employeesList[7]; // 2
            Employee Jason = employeesList[8]; // 3

            // Adds the current week day to the textbox saying employees Working
            lblCurrentDayOfWeek.Text = $"{dayOfWeek}";


            if (Convert.ToString(dayOfWeek) == "Monday")
            {
                rtbEmployeesWorking.Text = $"{Aj}{Don}{Jason}{Mike}{Randy}";
            }

            if (Convert.ToString(dayOfWeek) == "Tuesday")
            {
                rtbEmployeesWorking.Text = $"{Don}{Jason}{Matt}{Mike}{Randy}{Tony}";
            }

            if (Convert.ToString(dayOfWeek) == "Wednesday")
            {
                rtbEmployeesWorking.Text = $"{Aj}{Don}{Jason}{John}{Matt}{Randy}{Rich}{Tony}";
            }

            if (Convert.ToString(dayOfWeek) == "Thursday")
            {
                rtbEmployeesWorking.Text = $"{Jason}{John}{Mike}{Matt}{Randy}{Rich}{Tony}";
            }

            if (Convert.ToString(dayOfWeek) == "Friday")
            {
                rtbEmployeesWorking.Text = $"{Don}{Jason}{John}{Mike}{Randy}{Rich}";
            }

            if (Convert.ToString(dayOfWeek) == "Saturday")
            {
                rtbEmployeesWorking.Text = $"No Employees Are Scheduled Today";
            }

            if (Convert.ToString(dayOfWeek) == "Sunday")
            {
                rtbEmployeesWorking.Text = $"No Employees Are Scheduled Today";
            }

        }// end of ShowEmployees() method



        //BUTTON THAT SHOWS THE CURRENT EMPLOYEES FOR THAT DAY
        private void lblShowCurrentEmployees_Click(object sender, EventArgs e)
        {
            ShowEmployees();
        }// end of BUTTON THAT SHOWS THE CURRENT EMPLOYEES FOR THAT DAY



        // BUTTON THAT SHOWS YOU ALL WORKING EMPLOYEES NO MATTER THE DAY 
        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            // Lets us pick and choose between all of our employees from the list by using thier first name
            Employee Tony = employeesList[0]; //9
            Employee Matt = employeesList[1]; //5
            Employee Mike = employeesList[2]; //6
            Employee Rich = employeesList[3]; //8
            Employee Randy = employeesList[4]; //7
            Employee John = employeesList[5]; //4
            Employee Aj = employeesList[6]; // 1
            Employee Don = employeesList[7]; // 2
            Employee Jason = employeesList[8]; // 3

            rtbEmployeesWorking.Text = $"{Aj}{Don}{Jason}{John}{Matt}{Mike}{Randy}{Rich}{Tony}";
        }// end of BUTTON THAT SHOWS YOU ALL WORKING EMPLOYEES NO MATTER THE DAY 

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++














        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ OPENS THE MAIN FORM - LOGIN_REPORT ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // LOG OUT BUTTON
        private void btnLogout_Click(object sender, EventArgs e)
        {

            //Hides the current form 
            this.Close();

            //Does code magic to allow the new form to open upon this form closing
            th = new Thread(Open_Login_Report);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();



        }// end of LOG OUT BUTTON

        private void Open_Login_Report(object obj)
        {
            Application.Run(new Login_Report());
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~




        // FORM LOAD
        private void Successful_Login_Load(object sender, EventArgs e)
        {

        }// end of FORM LOAD

        
    }// end of form
}
