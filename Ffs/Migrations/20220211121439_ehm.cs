using Microsoft.EntityFrameworkCore.Migrations;

namespace Ffs.Migrations
{
    public partial class ehm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "15.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    InstallationDemand = table.Column<string>(name: "Installation Demand", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "15.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    AcceptanceCriteriaVerifyallfilesarepresent = table.Column<string>(name: "Acceptance Criteria - Verify all files are present#", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "15.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Row_id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Testinput = table.Column<string>(name: "Test input", type: "nchar(999)", fixedLength: true, maxLength: 999, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nchar(999)", fixedLength: true, maxLength: 999, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "15.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "15.5",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "15.6",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    No = table.Column<double>(type: "float", nullable: true),
                    Subfolder = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Files = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Size = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.10",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.11",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.12",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.13",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.14",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.15",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    F5 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.5",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.6",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.7",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.8",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "16.9",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "17.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "17.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.10",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.11",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.12",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.13",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.14",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.15",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.16",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.17",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.18",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.19",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.20",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.21",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.22",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.5",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.6",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.7",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.8",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "18.9",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.10",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.11",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.12",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.5",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.6",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.7",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.8",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "19.9",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.10",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.11",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.12",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.13",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.14",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.15",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.16",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.17",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.18",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.19",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.20",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.21",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.22",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.23",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.24",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.5",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.6",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.7",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.8",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "20.9",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "21.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.10",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.11",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.12",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.13",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.14",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.15",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.16",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.17",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.5",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.6",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.7",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.8",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "22.9",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "23.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "23.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "23.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "23.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.10",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.5",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.6",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.7",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.8",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "24.9",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "25.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AccpetanceCriteria = table.Column<string>(name: "Accpetance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "26.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AccpetanceCriteria = table.Column<string>(name: "Accpetance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "27.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AccpetanceCriteria = table.Column<string>(name: "Accpetance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.1",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.10",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.11",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.12",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.13",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.14",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.15",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.16",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.2",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.3",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.4",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.5",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.6",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.7",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.8",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "28.9",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(max)", nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "All_tables",
                columns: table => new
                {
                    Key_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Row_id = table.Column<double>(type: "float", nullable: true),
                    TestInput = table.Column<string>(name: "Test Input", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceCriteria = table.Column<string>(name: "Acceptance Criteria", type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Table Sheet",
                columns: table => new
                {
                    Table_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Table_xd",
                columns: table => new
                {
                    Key_id = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Table_id = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Row_id = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Test_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acceptance_criteria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_final", x => x.Key_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "15.1");

            migrationBuilder.DropTable(
                name: "15.2");

            migrationBuilder.DropTable(
                name: "15.3");

            migrationBuilder.DropTable(
                name: "15.4");

            migrationBuilder.DropTable(
                name: "15.5");

            migrationBuilder.DropTable(
                name: "15.6");

            migrationBuilder.DropTable(
                name: "16.1");

            migrationBuilder.DropTable(
                name: "16.10");

            migrationBuilder.DropTable(
                name: "16.11");

            migrationBuilder.DropTable(
                name: "16.12");

            migrationBuilder.DropTable(
                name: "16.13");

            migrationBuilder.DropTable(
                name: "16.14");

            migrationBuilder.DropTable(
                name: "16.15");

            migrationBuilder.DropTable(
                name: "16.2");

            migrationBuilder.DropTable(
                name: "16.3");

            migrationBuilder.DropTable(
                name: "16.4");

            migrationBuilder.DropTable(
                name: "16.5");

            migrationBuilder.DropTable(
                name: "16.6");

            migrationBuilder.DropTable(
                name: "16.7");

            migrationBuilder.DropTable(
                name: "16.8");

            migrationBuilder.DropTable(
                name: "16.9");

            migrationBuilder.DropTable(
                name: "17.1");

            migrationBuilder.DropTable(
                name: "17.2");

            migrationBuilder.DropTable(
                name: "18.1");

            migrationBuilder.DropTable(
                name: "18.10");

            migrationBuilder.DropTable(
                name: "18.11");

            migrationBuilder.DropTable(
                name: "18.12");

            migrationBuilder.DropTable(
                name: "18.13");

            migrationBuilder.DropTable(
                name: "18.14");

            migrationBuilder.DropTable(
                name: "18.15");

            migrationBuilder.DropTable(
                name: "18.16");

            migrationBuilder.DropTable(
                name: "18.17");

            migrationBuilder.DropTable(
                name: "18.18");

            migrationBuilder.DropTable(
                name: "18.19");

            migrationBuilder.DropTable(
                name: "18.2");

            migrationBuilder.DropTable(
                name: "18.20");

            migrationBuilder.DropTable(
                name: "18.21");

            migrationBuilder.DropTable(
                name: "18.22");

            migrationBuilder.DropTable(
                name: "18.3");

            migrationBuilder.DropTable(
                name: "18.4");

            migrationBuilder.DropTable(
                name: "18.5");

            migrationBuilder.DropTable(
                name: "18.6");

            migrationBuilder.DropTable(
                name: "18.7");

            migrationBuilder.DropTable(
                name: "18.8");

            migrationBuilder.DropTable(
                name: "18.9");

            migrationBuilder.DropTable(
                name: "19.1");

            migrationBuilder.DropTable(
                name: "19.10");

            migrationBuilder.DropTable(
                name: "19.11");

            migrationBuilder.DropTable(
                name: "19.12");

            migrationBuilder.DropTable(
                name: "19.2");

            migrationBuilder.DropTable(
                name: "19.3");

            migrationBuilder.DropTable(
                name: "19.4");

            migrationBuilder.DropTable(
                name: "19.5");

            migrationBuilder.DropTable(
                name: "19.6");

            migrationBuilder.DropTable(
                name: "19.7");

            migrationBuilder.DropTable(
                name: "19.8");

            migrationBuilder.DropTable(
                name: "19.9");

            migrationBuilder.DropTable(
                name: "20.1");

            migrationBuilder.DropTable(
                name: "20.10");

            migrationBuilder.DropTable(
                name: "20.11");

            migrationBuilder.DropTable(
                name: "20.12");

            migrationBuilder.DropTable(
                name: "20.13");

            migrationBuilder.DropTable(
                name: "20.14");

            migrationBuilder.DropTable(
                name: "20.15");

            migrationBuilder.DropTable(
                name: "20.16");

            migrationBuilder.DropTable(
                name: "20.17");

            migrationBuilder.DropTable(
                name: "20.18");

            migrationBuilder.DropTable(
                name: "20.19");

            migrationBuilder.DropTable(
                name: "20.2");

            migrationBuilder.DropTable(
                name: "20.20");

            migrationBuilder.DropTable(
                name: "20.21");

            migrationBuilder.DropTable(
                name: "20.22");

            migrationBuilder.DropTable(
                name: "20.23");

            migrationBuilder.DropTable(
                name: "20.24");

            migrationBuilder.DropTable(
                name: "20.3");

            migrationBuilder.DropTable(
                name: "20.4");

            migrationBuilder.DropTable(
                name: "20.5");

            migrationBuilder.DropTable(
                name: "20.6");

            migrationBuilder.DropTable(
                name: "20.7");

            migrationBuilder.DropTable(
                name: "20.8");

            migrationBuilder.DropTable(
                name: "20.9");

            migrationBuilder.DropTable(
                name: "21.1");

            migrationBuilder.DropTable(
                name: "22.1");

            migrationBuilder.DropTable(
                name: "22.10");

            migrationBuilder.DropTable(
                name: "22.11");

            migrationBuilder.DropTable(
                name: "22.12");

            migrationBuilder.DropTable(
                name: "22.13");

            migrationBuilder.DropTable(
                name: "22.14");

            migrationBuilder.DropTable(
                name: "22.15");

            migrationBuilder.DropTable(
                name: "22.16");

            migrationBuilder.DropTable(
                name: "22.17");

            migrationBuilder.DropTable(
                name: "22.2");

            migrationBuilder.DropTable(
                name: "22.3");

            migrationBuilder.DropTable(
                name: "22.4");

            migrationBuilder.DropTable(
                name: "22.5");

            migrationBuilder.DropTable(
                name: "22.6");

            migrationBuilder.DropTable(
                name: "22.7");

            migrationBuilder.DropTable(
                name: "22.8");

            migrationBuilder.DropTable(
                name: "22.9");

            migrationBuilder.DropTable(
                name: "23.1");

            migrationBuilder.DropTable(
                name: "23.2");

            migrationBuilder.DropTable(
                name: "23.3");

            migrationBuilder.DropTable(
                name: "23.4");

            migrationBuilder.DropTable(
                name: "24.1");

            migrationBuilder.DropTable(
                name: "24.10");

            migrationBuilder.DropTable(
                name: "24.2");

            migrationBuilder.DropTable(
                name: "24.3");

            migrationBuilder.DropTable(
                name: "24.4");

            migrationBuilder.DropTable(
                name: "24.5");

            migrationBuilder.DropTable(
                name: "24.6");

            migrationBuilder.DropTable(
                name: "24.7");

            migrationBuilder.DropTable(
                name: "24.8");

            migrationBuilder.DropTable(
                name: "24.9");

            migrationBuilder.DropTable(
                name: "25.1");

            migrationBuilder.DropTable(
                name: "26.1");

            migrationBuilder.DropTable(
                name: "27.1");

            migrationBuilder.DropTable(
                name: "28.1");

            migrationBuilder.DropTable(
                name: "28.10");

            migrationBuilder.DropTable(
                name: "28.11");

            migrationBuilder.DropTable(
                name: "28.12");

            migrationBuilder.DropTable(
                name: "28.13");

            migrationBuilder.DropTable(
                name: "28.14");

            migrationBuilder.DropTable(
                name: "28.15");

            migrationBuilder.DropTable(
                name: "28.16");

            migrationBuilder.DropTable(
                name: "28.2");

            migrationBuilder.DropTable(
                name: "28.3");

            migrationBuilder.DropTable(
                name: "28.4");

            migrationBuilder.DropTable(
                name: "28.5");

            migrationBuilder.DropTable(
                name: "28.6");

            migrationBuilder.DropTable(
                name: "28.7");

            migrationBuilder.DropTable(
                name: "28.8");

            migrationBuilder.DropTable(
                name: "28.9");

            migrationBuilder.DropTable(
                name: "All_tables");

            migrationBuilder.DropTable(
                name: "Table Sheet");

            migrationBuilder.DropTable(
                name: "Table_xd");
        }
    }
}
