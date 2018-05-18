using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ClockInMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dob = table.Column<DateTime>(nullable: false),
                    DotCompliant = table.Column<bool>(nullable: false),
                    EmployeeStatus = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LicExpire = table.Column<DateTime>(nullable: false),
                    LicIssue = table.Column<DateTime>(nullable: false),
                    LicNumber = table.Column<string>(nullable: true),
                    MedExpire = table.Column<DateTime>(nullable: false),
                    MedIssue = table.Column<DateTime>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    OnClock = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    PasswordConf = table.Column<string>(nullable: true),
                    SSN = table.Column<string>(nullable: true),
                    SsnConfirm = table.Column<string>(nullable: true),
                    Title = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Tractors",
                columns: table => new
                {
                    TractorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DotInp = table.Column<DateTime>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Plate = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false),
                    TruckNumber = table.Column<string>(nullable: true),
                    VinNumber = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tractors", x => x.TractorID);
                });

            migrationBuilder.CreateTable(
                name: "Trailers",
                columns: table => new
                {
                    TrailerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DotInsp = table.Column<DateTime>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Plate = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TrailerNumber = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailers", x => x.TrailerID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    DateDue = table.Column<DateTime>(nullable: false),
                    EmployeeNameEmployeeID = table.Column<int>(nullable: true),
                    LoadPlan = table.Column<string>(nullable: true),
                    OrderNumber = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<string>(nullable: true),
                    TimeDue = table.Column<DateTime>(nullable: false),
                    TrailerForLoadTrailerID = table.Column<int>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_EmployeeNameEmployeeID",
                        column: x => x.EmployeeNameEmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Trailers_TrailerForLoadTrailerID",
                        column: x => x.TrailerForLoadTrailerID,
                        principalTable: "Trailers",
                        principalColumn: "TrailerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DriverTractorLoad",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    TractorID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverTractorLoad", x => new { x.EmployeeID, x.TractorID, x.OrderID });
                    table.ForeignKey(
                        name: "FK_DriverTractorLoad_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverTractorLoad_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverTractorLoad_Tractors_TractorID",
                        column: x => x.TractorID,
                        principalTable: "Tractors",
                        principalColumn: "TractorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DriverTractorLoad_EmployeeID",
                table: "DriverTractorLoad",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverTractorLoad_OrderID",
                table: "DriverTractorLoad",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverTractorLoad_TractorID",
                table: "DriverTractorLoad",
                column: "TractorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeNameEmployeeID",
                table: "Orders",
                column: "EmployeeNameEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TrailerForLoadTrailerID",
                table: "Orders",
                column: "TrailerForLoadTrailerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DriverTractorLoad");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Tractors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Trailers");
        }
    }
}
