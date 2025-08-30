using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Version3OfERP21_8System.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreateNo1N : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Collectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectors", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MainRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MainRegionName = table.Column<string>(type: "longtext", nullable: false),
                    start_Number = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainRegions", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false),
                    Percentage_Representative = table.Column<double>(type: "double", nullable: false),
                    Main_purchase_price = table.Column<double>(type: "double", nullable: false),
                    Sale_purchase_price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Representatives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    user_Number = table.Column<int>(type: "int", nullable: false),
                    user_Password = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Representatives", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RuinInvoices",
                columns: table => new
                {
                    ruinInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ruinInvoiceDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuinInvoices", x => x.ruinInvoiceId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Storekeepers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    user_Number = table.Column<int>(type: "int", nullable: false),
                    user_Password = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storekeepers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    subRegionName = table.Column<string>(type: "longtext", nullable: false),
                    MainRegionName = table.Column<string>(type: "longtext", nullable: false),
                    MainRegionId = table.Column<int>(type: "int", nullable: false),
                    mainRegionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRegions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubRegions_MainRegions_mainRegionsId",
                        column: x => x.mainRegionsId,
                        principalTable: "MainRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CashInvoices",
                columns: table => new
                {
                    CashInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    InvoiceDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Total_price = table.Column<double>(type: "double", nullable: false),
                    SuppliersName = table.Column<string>(type: "longtext", nullable: false),
                    suppliersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashInvoices", x => x.CashInvoiceId);
                    table.ForeignKey(
                        name: "FK_CashInvoices_Suppliers_suppliersId",
                        column: x => x.suppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Due_BillsInvoices",
                columns: table => new
                {
                    Due_billsInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    InvoiceDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Total_price = table.Column<double>(type: "double", nullable: false),
                    Duepercentage = table.Column<double>(type: "double", nullable: false),
                    SuppliersName = table.Column<string>(type: "longtext", nullable: false),
                    suppliersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Due_BillsInvoices", x => x.Due_billsInvoiceId);
                    table.ForeignKey(
                        name: "FK_Due_BillsInvoices_Suppliers_suppliersId",
                        column: x => x.suppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Return_To_Suppliers",
                columns: table => new
                {
                    Return_to_SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    InvoiceDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Total_price = table.Column<double>(type: "double", nullable: false),
                    SuppliersName = table.Column<string>(type: "longtext", nullable: false),
                    suppliersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return_To_Suppliers", x => x.Return_to_SupplierId);
                    table.ForeignKey(
                        name: "FK_Return_To_Suppliers_Suppliers_suppliersId",
                        column: x => x.suppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Suppliers_Cashes",
                columns: table => new
                {
                    Suppliers_cashId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SupplyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SuppliersName = table.Column<string>(type: "longtext", nullable: false),
                    Supplly_Price = table.Column<double>(type: "double", nullable: false),
                    Supplly_Notes = table.Column<string>(type: "longtext", nullable: false),
                    suppliersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers_Cashes", x => x.Suppliers_cashId);
                    table.ForeignKey(
                        name: "FK_Suppliers_Cashes_Suppliers_suppliersId",
                        column: x => x.suppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CashInvoices_suppliersId",
                table: "CashInvoices",
                column: "suppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_Due_BillsInvoices_suppliersId",
                table: "Due_BillsInvoices",
                column: "suppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_Return_To_Suppliers_suppliersId",
                table: "Return_To_Suppliers",
                column: "suppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_SubRegions_mainRegionsId",
                table: "SubRegions",
                column: "mainRegionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Cashes_suppliersId",
                table: "Suppliers_Cashes",
                column: "suppliersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashInvoices");

            migrationBuilder.DropTable(
                name: "Collectors");

            migrationBuilder.DropTable(
                name: "Due_BillsInvoices");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Representatives");

            migrationBuilder.DropTable(
                name: "Return_To_Suppliers");

            migrationBuilder.DropTable(
                name: "RuinInvoices");

            migrationBuilder.DropTable(
                name: "Storekeepers");

            migrationBuilder.DropTable(
                name: "SubRegions");

            migrationBuilder.DropTable(
                name: "Suppliers_Cashes");

            migrationBuilder.DropTable(
                name: "MainRegions");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
