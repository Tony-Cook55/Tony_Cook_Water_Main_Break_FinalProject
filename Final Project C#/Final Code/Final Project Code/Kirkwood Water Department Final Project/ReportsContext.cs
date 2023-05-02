// MUST INSTALL THE PACKAGE AND NEED THIS using FOR THE : DbContext to work
using Microsoft.EntityFrameworkCore;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirkwood_Water_Department_Final_Project
{
    public class ReportsContext : DbContext
    {

        //what is the name of the table? This is creating our customers table in the Data BAse
        public DbSet<Reports> ReportedBreaks { get; set; } // name of the table 



        // Connection Stirng    connecting the application to the database 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB;Database=ReportedWaterMainBreaks;Trusted_Connection=True;MultipleActiveResultSets=True");
        }



        // Give application SEED DATA - start the database with this inital data (Not manditory) 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Putting some customers into our database so they will be there on the start 
            modelBuilder.Entity<Reports>().HasData(
                //  int ReportNumber, string Name, string PhoneNumber, string TypeWhosReporting, string VisableProblem, string BreakLocation
                new Reports { ReportNumberId = 1, Name = "Tony Cook", PhoneNumber = "(314) 737-9285", TypeWhosReporting = "Citizen", VisableProblem = "Water leaking from fire hydrant", BreakLocation = "Rose Hill Ave"},
                new Reports { ReportNumberId = 2, Name = "Owen Garrett", PhoneNumber = "(314) 412-8142", TypeWhosReporting = "Citizen", VisableProblem = "Pipe Outburst", BreakLocation = "Lee Ave" },
                new Reports { ReportNumberId = 3, Name = "Matt Pelich", PhoneNumber = "(314) 182-2784", TypeWhosReporting = "Kirkwood Resident", VisableProblem = "No running water is in my house", BreakLocation = "Lilian Ave" }
                );
        }



        // Then under Package Manager Console you Type      Add-Migration DBCreation   then     Update-Database









    }// end of class
}
