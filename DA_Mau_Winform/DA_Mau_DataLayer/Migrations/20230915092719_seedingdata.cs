using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA_Mau_DataLayer.Migrations
{
    public partial class seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Email", "Name", "Password", "Role", "Status" },
                values: new object[] { 1, "Hà Nội", "admin@gmail.com", "admin", "admin", 0, 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "PhoneNumber", "Address", "EmployeeId", "Gender", "Name" },
                values: new object[] { "0987654321", "HN", 1, 0, "Hoàng" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "EmployeeId", "InputPrice", "Name", "Note", "PhotoPath", "Quantity", "SellPrice" },
                values: new object[] { 1, 1, 10m, "Test", "ALo", null, 15, 20m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "PhoneNumber",
                keyValue: "0987654321");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
