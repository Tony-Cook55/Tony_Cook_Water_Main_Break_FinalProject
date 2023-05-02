using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kirkwood_Water_Department_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class DBCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportedBreaks",
                columns: table => new
                {
                    ReportNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeWhosReporting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisableProblem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreakLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedBreaks", x => x.ReportNumberId);
                });

            migrationBuilder.InsertData(
                table: "ReportedBreaks",
                columns: new[] { "ReportNumberId", "BreakLocation", "Name", "PhoneNumber", "TypeWhosReporting", "VisableProblem" },
                values: new object[,]
                {
                    { 1, "Rose Hill Ave", "Tony Cook", "(314) 737-9285", "Citizen", "Water leaking from fire hydrant" },
                    { 2, "Lee Ave", "Owen Garrett", "(314) 412-8142", "Citizen", "Pipe Outburst on Street" },
                    { 3, "Lilian Ave", "Matt Pelich", "(314) 182-2784", "Kirkwood Resident", "No running water is in my house" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportedBreaks");
        }
    }
}
