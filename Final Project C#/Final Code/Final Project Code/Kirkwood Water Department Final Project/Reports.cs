using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirkwood_Water_Department_Final_Project
{
    [PrimaryKey("ReportNumberId")] // needed to add this to make that the primary key 

    public class Reports
    {
        
        public int ReportNumberId { get; set; } // this is so we can see the number the report is autoincrements upwards

        public string Name { get; set; } = string.Empty; // for user inputted name

        public string PhoneNumber { get; set; } = string.Empty; // for user inputted Phone Number

        public string TypeWhosReporting { get; set; } = string.Empty; // for the type of person that is reporting 



        public string VisableProblem { get; set; } = string.Empty; // for user inputted problem of the break

        public string BreakLocation { get; set; } = string.Empty; // for user inputted location of the break



        public override string ToString()
        {
            return $"\n🩸 Watermain Report Submission Number: {ReportNumberId}\nA {TypeWhosReporting} named {Name} has reported that there was a visible problem of a {VisableProblem} at {BreakLocation}\n";
        }






    }// end of form 
}
