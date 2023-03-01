using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExaminationApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PagesCount = table.Column<int>(type: "int", nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoldBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoldAmount = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoldBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "PagesCount", "Price", "PublishYear", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Джоан Роулинг", 1, 600, 500m, 2000, "Росмэн", "Гарри Поттер и философский камень" },
                    { 2, "Станислав Лем", 5, 640, 500m, 2018, "АСТ", "Сумма технологий" },
                    { 3, "Лю Цысинь", 2, 440, 500m, 2017, "Fanzon", "Задача трех тел" },
                    { 4, "Лю Цысинь", 2, 650, 500m, 2018, "Fanzon", "Темный лес" },
                    { 5, "Умберто Эко", 3, 710, 500m, 1980, "Corpus", "Имя розы" },
                    { 6, "Габриэль Гарсия Маркес", 3, 330, 500m, 2022, "Corpus", "Скандал столетия" },
                    { 7, "Мона Кастен", 6, 400, 500m, 2023, "Like Book", "Снова мечтай" },
                    { 8, "Джон Скальци", 2, 380, 500m, 2022, "Fanzon", "Бригады призраков" }
                });

            migrationBuilder.InsertData(
                table: "SoldBooks",
                columns: new[] { "Id", "BookId", "SellingDate", "SoldAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000 },
                    { 2, 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 },
                    { 3, 3, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000 },
                    { 4, 4, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000 },
                    { 5, 5, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100000 },
                    { 6, 6, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000 },
                    { 7, 7, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 8, 8, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoldBooks_BookId",
                table: "SoldBooks",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoldBooks");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
