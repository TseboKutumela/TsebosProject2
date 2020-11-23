using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CMPG323project2dataset",
                table: "CMPG323project2dataset");

            migrationBuilder.RenameTable(
                name: "CMPG323project2dataset",
                newName: "dimedata");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dimedata",
                table: "dimedata",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_dimedata",
                table: "dimedata");

            migrationBuilder.RenameTable(
                name: "dimedata",
                newName: "CMPG323project2dataset");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CMPG323project2dataset",
                table: "CMPG323project2dataset",
                column: "Id");
        }
    }
}
