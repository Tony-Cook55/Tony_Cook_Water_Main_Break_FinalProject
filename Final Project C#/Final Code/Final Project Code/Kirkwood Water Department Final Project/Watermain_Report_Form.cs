using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Kirkwood_Water_Department_Final_Project
{
    public partial class Watermain_Report_Form : Form
    {
        // Code magic to allow the 2nd form to open
        Thread th;


        ReportsContext reportsDatabase;

        List<Reports> reportsList;



        public Watermain_Report_Form()
        {
            reportsDatabase= new ReportsContext();  // lets us access the class for the table


            InitializeComponent();


            //LINQ
            // FROM    ORDERBY     WHERE    SELECT


            //r represents our reports     select our reports and select what you want from r
            reportsList = reportsDatabase.ReportedBreaks.Select(r => r).ToList(); //<-- converts data into a list


            // Ensures all fields are the color White 
            txtName.BackColor = Color.White;
            txtPhoneNumber.BackColor = Color.White;
            cbWhoIsReportingBreak.BackColor = Color.White;
            cbVisableProblem.BackColor = Color.White;
            lblPleaseSelectARoad.ForeColor = Color.DarkBlue;


        }

        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! SHOWREPORTS METHOD !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Method that allows you to loop through the reports
        private void ShowMessageBox()
        {
            // MAKES A MESSAGE BOX APPEAR TO ALLOW YOU TO GO TO MAIN SCREEN
            DialogResult sumbittedForm = MessageBox.Show("Thank You For Submitting This Form!\n        Returning To Main Menu", "Form Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (sumbittedForm == DialogResult.OK)
            {
                //Hides the current form 
                this.Close();

                //Does code magic to allow the new form to open upon this form closing
                th = new Thread(Open_Main_Form);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

        }
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ CHANGES TEXTBOX COLOR UPON ENTERING AND LEAVING $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        
        // NAME TEXT BOX 
        private void txtName_Enter(object sender, EventArgs e)
        {
            //THIS IS WHAT US TO make the things turn the color HotTrack to match combo boxs
            var convertColors = new System.Drawing.ColorConverter();
            var HotTrackBlueColor = (System.Drawing.Color)convertColors.ConvertFromString("#0066CC");

            txtName.BackColor = HotTrackBlueColor;

            txtName.ForeColor = Color.White;
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;

            txtName.ForeColor = Color.Black;
        }


        // PHONE NUMBER TEXTBOX
        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            //THIS IS WHAT US TO make the things turn the color HotTrack to match combo boxs
            var convertColors = new System.Drawing.ColorConverter();
            var HotTrackBlueColor = (System.Drawing.Color)convertColors.ConvertFromString("#0066CC");

            txtPhoneNumber.BackColor = HotTrackBlueColor;

            txtPhoneNumber.ForeColor = Color.White;
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            txtPhoneNumber.BackColor = Color.White;

            txtPhoneNumber.ForeColor = Color.Black;
        }

        // COMBOBOX OF WHO IS REPORING
        private void cbWhoIsReportingBreak_Enter(object sender, EventArgs e)
        {
            //THIS IS WHAT US TO make the things turn the color HotTrack to match combo boxs
            var convertColors = new System.Drawing.ColorConverter();
            var HotTrackBlueColor = (System.Drawing.Color)convertColors.ConvertFromString("#0066CC");

            cbWhoIsReportingBreak.BackColor = HotTrackBlueColor;

            cbWhoIsReportingBreak.ForeColor = Color.White;
        }

        private void cbWhoIsReportingBreak_Leave(object sender, EventArgs e)
        {
            cbWhoIsReportingBreak.BackColor = Color.White;

            cbWhoIsReportingBreak.ForeColor = Color.Black;
        }





        // COMBOBOX VISABLE PROBLEM
        private void cbVisableProblem_Enter(object sender, EventArgs e)
        {
            //THIS IS WHAT US TO make the things turn the color HotTrack to match combo boxs
            var convertColors = new System.Drawing.ColorConverter();
            var HotTrackBlueColor = (System.Drawing.Color)convertColors.ConvertFromString("#0066CC");

            cbVisableProblem.BackColor = HotTrackBlueColor;

            cbVisableProblem.ForeColor = Color.White;
        }

        private void cbVisableProblem_Leave(object sender, EventArgs e)
        {
            cbVisableProblem.BackColor = Color.White;

            cbVisableProblem.ForeColor = Color.Black;
        }


        //FOR BOTH THE SUBMIT AND RETURN HOME BUTTON
        private void Buttons_Enter_Focus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.White;
        }

        private void Buttons_Leave_Focus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.LightSkyBlue;
        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$






        // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ SUBMIT / ADD NEW REPORT @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //SUBMIT FORM BUTTON
        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
            try
            {
                // If all the textboxs have been filled out then it will submit to the database if not will produce error
                if (txtName.Text != null && txtPhoneNumber.Text != null && cbWhoIsReportingBreak.SelectedItem != null
                    /*&& txtDateInput.Text != null*/ && cbVisableProblem.SelectedItem != null
                    || rbMcCullough_Ave.Checked == true || rbWoodbine_Ave.Checked == true || rbRose_Ln.Checked == true
                    || rbLee_Ave.Checked == true || rbRose_Hill_Ave.Checked == true || rbMidway_Ave.Checked == true
                    || rbMonroe_Ave.Checked == true || rbScott_Ave.Checked == true || rbClinton_Pl.Checked == true
                    || rbElliott_Ave.Checked == true || rbLillian_Ave.Checked == true)
                {

                    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ McCullough Ave ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                    if (rbMcCullough_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbMcCullough_Ave.Text,
                        };

                        //lblYouChoseROAD.Text = "You Have Choosen | McCullough Ave |";

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();


                        ShowMessageBox();// once clicked this shows the MESSAGE BOX 

                    }
                    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


                    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Woodbine Ave !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    if (rbWoodbine_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbWoodbine_Ave.Text,
                        };


                        //lblYouChoseROAD.Text = "You Have Choosen | Woodbine Ave |";


                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX 

                    }
                    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


                    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Rose Ln @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    if (rbRose_Ln.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbRose_Ln.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


                    //############################################ Lee Ave ##########################################################
                    if (rbLee_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbLee_Ave.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //#########################################################################################################


                    //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ Rose Hill Ave $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                    if (rbRose_Hill_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbRose_Hill_Ave.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$


                    //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Midway Ave %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                    if (rbMidway_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbMidway_Ave.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


                    //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ Monroe Ave ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                    if (rbMonroe_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbMonroe_Ave.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


                    //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& Scott Ave &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                    if (rbScott_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbScott_Ave.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&


                    //************************************************** Clinton Pl ********************************************************
                    if (rbClinton_Pl.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbClinton_Pl.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //*************************************************************************************************************************


                    //(((((((((((((((((((((((((((((((((((((((( Elliott Ave ((((((((((((((((((((((((((((((((((((((((((((((((((((((
                    if (rbElliott_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbElliott_Ave.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //(((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((


                    //))))))))))))))))))))))))))))))))))))))))) Lillian Ave ))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
                    if (rbLillian_Ave.Checked)
                    {
                        //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                        Reports addNewReport = new Reports
                        {
                            Name = txtName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            TypeWhosReporting = cbWhoIsReportingBreak.SelectedItem.ToString(),
                            VisableProblem = cbVisableProblem.SelectedItem.ToString(),
                            BreakLocation = rbLillian_Ave.Text,
                        };

                        reportsDatabase.ReportedBreaks.Add(addNewReport);
                        reportsDatabase.SaveChanges();

                        ShowMessageBox();// once clicked this shows the MESSAGE BOX

                    }
                    //)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))



                }// end of if statement to see if boxs are full if not do the following 

                //Creates the error message 
                //if (txtName.Text == string.Empty && txtPhoneNumber.Text == string.Empty && cbWhoIsReportingBreak.SelectedItem == null
                //    /*&& txtDateInput.Text == null*/ && cbVisableProblem.SelectedItem == null
                //    && rbMcCullough_Ave.Checked == false && rbWoodbine_Ave.Checked == false && rbRose_Ln.Checked == false
                //    && rbLee_Ave.Checked == false && rbRose_Hill_Ave.Checked == false && rbMidway_Ave.Checked == false
                //    && rbMonroe_Ave.Checked == false && rbScott_Ave.Checked == false && rbClinton_Pl.Checked == false
                //    && rbElliott_Ave.Checked == false && rbLillian_Ave.Checked == false)
                //{
                //    lblErrorFillInfo.ForeColor = Color.Red;
                //    lblErrorFillInfo.Text = "Please Fill In All Fields";
                //    lblPleaseSelectARoad.ForeColor = Color.Red;
                //}
                else
                {
                    lblErrorFillInfo.ForeColor = Color.Red;
                    lblErrorFillInfo.Text = "Please Fill In All Fields";
                    lblPleaseSelectARoad.ForeColor = Color.Red;
                }



                // ~~~~~~~~~~~~~~~~~~~~~~ If the Text boxs are empty it will change their color to red ~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                if (txtName.Text == string.Empty)
                {
                    txtName.BackColor = Color.Red;
                }
                if (txtPhoneNumber.Text == string.Empty)
                {
                    txtPhoneNumber.BackColor = Color.Red;
                }
                if (cbWhoIsReportingBreak.SelectedItem == null)
                {
                    cbWhoIsReportingBreak.BackColor = Color.Red;
                }
                //if (txtDateInput.Text == string.Empty)
                //{
                //    txtDateInput.BackColor = Color.Red;
                //}
                if (cbVisableProblem.SelectedItem == null)
                {
                    cbVisableProblem.BackColor = Color.Red;
                }

                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~




            }
            catch (NullReferenceException ex) // DISPLAYS A MESSAGE IF A MAP BUTTON IS CLICKED THEN THE SUBMIT BUTTON 
            {
                MessageBox.Show("Please Select A Location On The Map", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
            

        }// end of SUBMIT FORM BUTTON
// @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


        






//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! RETURN TO MAIN FORM !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //RETURN TO MAIN FORM BUTTON
        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {



            //Hides the current form 
            this.Close();

            //Does code magic to allow the new form to open upon this form closing
            th = new Thread(Open_Main_Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();





        }// end of RETURN TO MAIN FORM BUTTON


        private void Open_Main_Form(object obj)
        {
            Application.Run(new Login_Report());
        }

        
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!







    }// end of form
}
