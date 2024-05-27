using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cw6.Migrations
{
    /// <inheritdoc />
    public partial class MedikamentTableMakePublicPropertis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Medikaments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Medikaments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Medikaments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Medikaments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Medikaments");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Medikaments");
        }
    }
}
