using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shadow_PUDGE.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Products",
                newName: "Shtatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Shtatus",
                table: "Products",
                newName: "Status");
        }
    }
}
