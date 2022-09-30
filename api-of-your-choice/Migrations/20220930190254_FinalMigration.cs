using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_of_your_choice.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flyrods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakerId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LengthFeet = table.Column<double>(type: "float", nullable: false),
                    Sections = table.Column<int>(type: "int", nullable: false),
                    LineWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearMade = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Construction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flyrods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearFounded = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Flyrods",
                columns: new[] { "Id", "Construction", "LengthFeet", "LineWeight", "MakerId", "Model", "Sections", "Type", "YearMade" },
                values: new object[,]
                {
                    { 1, "Hex", 6.0, "WF4", 1, "37H", 2, "Bamboo", 1959 },
                    { 2, "Hex", 7.0, "DT4", 2, "98", 2, "Bamboo", 1962 },
                    { 3, "Hex", 7.5, "DT5", 3, "Far and Fine", 2, "Bamboo", 1972 },
                    { 4, "Hex", 8.5, "DT7", 9, "SF8672", 2, "Bamboo", 1962 },
                    { 5, "Penta", 7.5, "DT5", 4, "7513", 2, "Bamboo", 1955 },
                    { 6, "Hex", 8.5, "WF6", 5, "B9", 2, "Bamboo", 1946 },
                    { 7, "Quad", 7.5, "WF6", 6, "37", 2, "Bamboo", 1950 },
                    { 8, "Hex", 8.5, "DT7", 7, "Medallion", 2, "Bamboo", 1975 },
                    { 9, "Tubular", 8.0, "WF6", 8, "FF80", 2, "Fiberglass", 1977 },
                    { 10, "Tubular", 7.5, "WF6", 3, "Fullflex A", 2, "Fiberglass", 1977 },
                    { 11, "Tubular", 8.0, "WF4", 9, "Stalker", 2, "Fiberglass", 1979 }
                });

            migrationBuilder.InsertData(
                table: "Makers",
                columns: new[] { "Id", "Name", "Type", "YearFounded" },
                values: new object[,]
                {
                    { 1, "Leonard", "Company", 1933 },
                    { 2, "Payne", "Company", 1929 },
                    { 3, "Orvis", "Company", 1889 },
                    { 4, "Uslan", "Individual", 1933 },
                    { 5, "EC Powell", "Company", 1919 },
                    { 6, "WE Edwards", "Individual", 1940 },
                    { 7, "Browning Silaflex", "Company", 1970 },
                    { 8, "Fenwick", "Company", 1972 },
                    { 9, "Winston", "Company", 1933 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flyrods");

            migrationBuilder.DropTable(
                name: "Makers");
        }
    }
}
