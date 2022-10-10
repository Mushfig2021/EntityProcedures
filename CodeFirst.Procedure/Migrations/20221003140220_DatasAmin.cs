using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Procedure.Migrations
{
    public partial class DatasAmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UspResults",
                columns: table => new
                {
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UspResults");
        }
    }
}
