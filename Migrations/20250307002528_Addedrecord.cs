using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace firstone.Migrations
{
    /// <inheritdoc />
    public partial class Addedrecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phone",
                value: "816 203 9740");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phone",
                value: "8916 203 9740");
        }
    }
}
