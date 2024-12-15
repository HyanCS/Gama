using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gama.API.Migrations
{
    /// <inheritdoc />
    public partial class CustomerInclusion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerAddress", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main St", "John Doe" },
                    { 2, "456 Elm St", "Jane Smith" },
                    { 3, "789 Oak St", "Bob Johnson" },
                    { 4, "101 Maple St", "Alice Brown" },
                    { 5, "202 Pine St", "Charlie Davis" },
                    { 6, "303 Cedar St", "Emily Evans" },
                    { 7, "404 Birch St", "Frank Harris" },
                    { 8, "505 Walnut St", "Grace Kelly" },
                    { 9, "606 Chestnut St", "Hank Lee" },
                    { 10, "707 Spruce St", "Isabel Moore" },
                    { 11, "808 Fir St", "Jack Nelson" },
                    { 12, "909 Redwood St", "Kathy Owens" },
                    { 13, "100 Ash St", "Leo Parker" },
                    { 14, "111 Cypress St", "Mona Queen" },
                    { 15, "222 Dogwood St", "Nancy Robinson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
