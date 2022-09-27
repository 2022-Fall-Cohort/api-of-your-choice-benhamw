using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_of_your_choice.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flyrod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Flyrod", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Flyrod",
                columns: new[] { "Id", "Construction", "LengthFeet", "LineWeight", "Maker", "Model", "Sections", "Type", "YearMade" },
                values: new object[,]
                {
                    { 1, "Hex", 6.0, "WF4", "Leonard", "37H", 2, "Bamboo", 1959 },
                    { 2, "Hex", 7.0, "DT4", "Payne", "98", 2, "Bamboo", 1962 },
                    { 3, "Hex", 7.5, "DT5", "Orvis", "Far and Fine", 2, "Bamboo", 1972 },
                    { 4, "Penta", 7.5, "DT5", "Uslan", "7513", 2, "Bamboo", 1955 },
                    { 5, "Hex", 8.5, "WF6", "EC Powell", "B9", 2, "Bamboo", 1946 },
                    { 6, "Quad", 7.5, "WF6", "WE Edwards", "37", 2, "Bamboo", 1950 },
                    { 7, "Hex", 8.5, "DT7", "Browning", "Silaflex", 2, "Bamboo", 1975 },
                    { 8, "Tubular", 8.0, "WF6", "Fenwick", "FF80", 2, "Fiberglass", 1977 },
                    { 9, "Tubular", 8.0, "WF4", "Winston", "Stalker", 2, "Fiberglass", 1979 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flyrod");
        }
    }
}
