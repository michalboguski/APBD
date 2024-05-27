using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cw6.Migrations
{
    /// <inheritdoc />
    public partial class AddedMedikamentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medikaments",
                columns: table => new
                {
                    IdMedikament = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medikaments", x => x.IdMedikament);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medikaments");
        }
    }
}
