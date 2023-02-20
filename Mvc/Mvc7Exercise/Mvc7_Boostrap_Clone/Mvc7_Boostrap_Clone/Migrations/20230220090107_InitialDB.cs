using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mvc7_Boostrap_Clone.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "總經理室", "david@gmail.com", "0933-152667", "David", "CEO" },
                    { 2, "人事部", "mary@gmail.com", "0938-456889", "Mary", "管理師" },
                    { 3, "財務部", "joe@gmail.com", "0925-331225", "Joe", "經理" },
                    { 4, "業務部", "mark@gmail.com", "0935-863991", "Mark", "業務員" },
                    { 5, "資訊部", "rose@gmail.com", "0987-335668", "Rose", "工程師" },
                    { 6, "資訊部", "may@gmail.com", "0955-259885", "May", "工程師" },
                    { 7, "業務部", "john@gmail.com", "0921-123456", "John", "業務員" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
