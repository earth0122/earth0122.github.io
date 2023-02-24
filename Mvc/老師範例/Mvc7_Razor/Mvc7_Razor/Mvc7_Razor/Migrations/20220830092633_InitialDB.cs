using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mvc7_Razor.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WikiUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chinese = table.Column<int>(type: "int", nullable: false),
                    English = table.Column<int>(type: "int", nullable: false),
                    Math = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "Brief", "Name", "Photo", "WikiUrl" },
                values: new object[,]
                {
                    { 1, "特斯拉創辦人 伊隆·馬斯克", "Elon Musk", "ElonMusk.jpg", "https://goo.gl/46xeXx" },
                    { 2, "Facebook創辦人 馬克·祖伯克", "Mark Zuckerberg", "MarkZuckerberg.jpg", "https://goo.gl/BktGGA" },
                    { 3, "蘋果創辦人 史提夫·賈伯斯", "Steve Jobs", "SteveJobs.jpg", "https://goo.gl/nAiX0y" },
                    { 4, "帝國元帥  維達", "Vader", "Vader.jpg", "https://en.wikipedia.org/wiki/Darth_Vader" },
                    { 5, "星際大戰 達斯摩", "Darth Mual", "DarthMual.jpg", "https://goo.gl/5obLhX" },
                    { 6, "星際大戰 女絕地武士Twilek", "White Twilek", "WhiteTwilek.jpg", "https://goo.gl/reKzAu" },
                    { 7, "星際大戰 歐比旺Obiwan", "Obiwan", "Obiwan.jpg", "http://bit.ly/33gxdgt" },
                    { 8, "德國總理 梅克爾", "Merkel", "Merkel.jpg", "http://bit.ly/33huSlv" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
