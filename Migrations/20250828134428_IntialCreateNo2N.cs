using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Version3OfERP21_8System.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreateNo2N : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainRegionId",
                table: "SubRegions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainRegionId",
                table: "SubRegions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
