using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AlbumSingerGroup = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AlbumReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlbumPrice = table.Column<decimal>(type: "money", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false),
                    IsItOnSale = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManagerLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.ManagerId);
                });

            migrationBuilder.CreateTable(
                name: "AlbumManagers",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumManagers", x => new { x.AlbumId, x.ManagerId });
                    table.ForeignKey(
                        name: "FK_AlbumManagers_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumManagers_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "ManagerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumName", "AlbumPrice", "AlbumReleaseDate", "AlbumSingerGroup", "CreationDate", "DeletedDate", "DiscountRate", "IsItOnSale", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Tamirci Çıragı", 200m, new DateTime(1997, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cem Karaca", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3582), null, 15.0, false, null, 1 },
                    { 2, "Thriller", 200m, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Jackson", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3604), null, 10.0, true, null, 1 },
                    { 3, "Thriller", 200m, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Jackson", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3605), null, 10.0, true, null, 1 },
                    { 4, "Dark Side of the Moon", 250m, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pink Floyd", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3607), null, 15.0, false, null, 1 },
                    { 5, "The Wall", 300m, new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pink Floyd", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3633), null, 20.0, true, null, 1 },
                    { 6, "Back in Black", 220m, new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AC/DC", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3635), null, 12.0, true, null, 1 },
                    { 7, "Abbey Road", 280m, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Beatles", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3637), null, 18.0, false, null, 1 },
                    { 8, "The Eminem Show", 210m, new DateTime(2002, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eminem", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3639), null, 14.0, true, null, 1 },
                    { 9, "Hotel California", 260m, new DateTime(1976, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eagles", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3641), null, 17.0, false, null, 1 },
                    { 10, "Led Zeppelin IV", 240m, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Led Zeppelin", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3643), null, 16.0, true, null, 1 },
                    { 11, "The Queen Is Dead", 290m, new DateTime(1986, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Smiths", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3644), null, 19.0, false, null, 1 },
                    { 12, "Nevermind", 270m, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nirvana", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3645), null, 20.0, true, null, 1 },
                    { 13, "Future Nostalgia", 25m, new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dua Lipa", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3647), null, 10.0, true, null, 1 },
                    { 14, "Positions", 28m, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ariana Grande", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3649), null, 15.0, false, null, 1 },
                    { 15, "evermore", 30m, new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor Swift", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3650), null, 20.0, true, null, 1 },
                    { 16, "After Hours", 22m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Weeknd", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3652), null, 12.0, true, null, 1 },
                    { 17, "Fine Line", 28m, new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Styles", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3653), null, 18.0, false, null, 1 },
                    { 18, "30", 25m, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adele", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3655), null, 10.0, true, null, 1 },
                    { 19, "Justice", 28m, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justin Bieber", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3656), null, 0.0, false, null, 1 },
                    { 20, "Happier Than Ever", 30m, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billie Eilish", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3657), null, 20.0, true, null, 1 },
                    { 21, "Montero", 22m, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lil Nas X", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3659), null, 12.0, true, null, 1 },
                    { 22, "Red (Taylor's Version)", 28m, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor Swift", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3660), null, 0.0, false, null, 1 },
                    { 23, "Karanlıkta", 25m, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duman", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3661), null, 15.0, true, null, 1 },
                    { 24, "Düşler Ülkesinin Gelgit Akşamları", 28m, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müslüm Gürses", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3663), null, 0.0, false, null, 1 },
                    { 25, "Aşk Masalı", 30m, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sezen Aksu", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3664), null, 20.0, true, null, 1 },
                    { 26, "Yaş Hikayesi", 22m, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cem Adrian", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3665), null, 18.0, true, null, 1 },
                    { 27, "Senin İçin Değer", 28m, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenan Doğulu", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3667), null, 12.0, true, null, 1 },
                    { 28, "Gel Yeter", 26m, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajda Pekkan", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3668), null, 15.0, false, null, 1 },
                    { 29, "Sorma Neden", 32m, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tarkan", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3669), null, 10.0, true, null, 1 },
                    { 30, "Düşler Sokağı", 24m, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gülşen", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3671), null, 18.0, false, null, 1 },
                    { 31, "Son Şarkılarım", 29m, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teoman", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3672), null, 10.0, true, null, 1 },
                    { 32, "Bir Zamanlar Türkiye'de", 27m, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "MFÖ", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3674), null, 15.0, false, null, 1 },
                    { 33, "İstanbul Hatırası", 25m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müzeyyen Senar", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3675), null, 0.0, true, null, 1 },
                    { 34, "Köprüaltı Çocukları", 28m, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barış Manço", new DateTime(2024, 6, 20, 23, 8, 44, 552, DateTimeKind.Local).AddTicks(3676), null, 0.0, true, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumManagers_ManagerId",
                table: "AlbumManagers",
                column: "ManagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumManagers");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
