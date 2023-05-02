using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Login___Report_Break
{
    public partial class Succsessful_LoginForm : Form
    {
        public Succsessful_LoginForm()
        {
            InitializeComponent();
        }


        //LOGOUT BUTTON
        private void btnLogoutUser_Click(object sender, EventArgs e)
        {

            //Hides this form
            this.Hide();

            //Makes a new instance of the SuccsessFull login form
            LoginForm returnToLogin = new LoginForm();

            //shows the second form 
            returnToLogin.Show();

            

        }// end of LOGOUT BUTTON

        

        // FORM LOAD
        private void Succsessful_LoginForm_Load(object sender, EventArgs e)
        {
            lblWelcomeNAME.Text = $"Welcome To Work ";
        } // end of FORM LOAD
    }// end of form
}
