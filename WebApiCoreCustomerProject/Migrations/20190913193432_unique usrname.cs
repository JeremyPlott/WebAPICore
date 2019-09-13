using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCoreCustomerProject.Migrations
{
    public partial class uniqueusrname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IDX_Username",
                table: "Employee",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder) 
        {
            migrationBuilder.DropIndex(
                name: "IDX_Username",
                table: "Employee");
        }
    }
}
