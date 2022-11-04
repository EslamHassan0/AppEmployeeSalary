using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication14.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Departmentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departmentaddres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Departmentid);
                });

            migrationBuilder.CreateTable(
                name: "jops",
                columns: table => new
                {
                    jobid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jops", x => x.jobid);
                });

            migrationBuilder.CreateTable(
                name: "Salarys",
                columns: table => new
                {
                    itemsalaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemSalary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salarys", x => x.itemsalaryID);
                });

            migrationBuilder.CreateTable(
                name: "Emps",
                columns: table => new
                {
                    idEmp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salary = table.Column<double>(type: "float", nullable: false),
                    fristname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastnema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    Departmentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emps", x => x.idEmp);
                    table.ForeignKey(
                        name: "FK_Emps_Departments_Departmentid",
                        column: x => x.Departmentid,
                        principalTable: "Departments",
                        principalColumn: "Departmentid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee_Details",
                columns: table => new
                {
                    Employeedetailid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<double>(type: "float", nullable: false),
                    skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpididEmp = table.Column<int>(type: "int", nullable: true),
                    Jopidjobid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_Details", x => x.Employeedetailid);
                    table.ForeignKey(
                        name: "FK_employee_Details_Emps_EmpididEmp",
                        column: x => x.EmpididEmp,
                        principalTable: "Emps",
                        principalColumn: "idEmp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_Details_jops_Jopidjobid",
                        column: x => x.Jopidjobid,
                        principalTable: "jops",
                        principalColumn: "jobid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "empSalaries",
                columns: table => new
                {
                    EmpSalaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Values = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<double>(type: "float", nullable: false),
                    emploesidEmp = table.Column<int>(type: "int", nullable: true),
                    SalaryitemsalaryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empSalaries", x => x.EmpSalaryId);
                    table.ForeignKey(
                        name: "FK_empSalaries_Emps_emploesidEmp",
                        column: x => x.emploesidEmp,
                        principalTable: "Emps",
                        principalColumn: "idEmp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_empSalaries_Salarys_SalaryitemsalaryID",
                        column: x => x.SalaryitemsalaryID,
                        principalTable: "Salarys",
                        principalColumn: "itemsalaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employee_Details_EmpididEmp",
                table: "employee_Details",
                column: "EmpididEmp");

            migrationBuilder.CreateIndex(
                name: "IX_employee_Details_Jopidjobid",
                table: "employee_Details",
                column: "Jopidjobid");

            migrationBuilder.CreateIndex(
                name: "IX_Emps_Departmentid",
                table: "Emps",
                column: "Departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_empSalaries_emploesidEmp",
                table: "empSalaries",
                column: "emploesidEmp");

            migrationBuilder.CreateIndex(
                name: "IX_empSalaries_SalaryitemsalaryID",
                table: "empSalaries",
                column: "SalaryitemsalaryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee_Details");

            migrationBuilder.DropTable(
                name: "empSalaries");

            migrationBuilder.DropTable(
                name: "jops");

            migrationBuilder.DropTable(
                name: "Emps");

            migrationBuilder.DropTable(
                name: "Salarys");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
