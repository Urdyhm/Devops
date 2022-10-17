using Microsoft.EntityFrameworkCore.Migrations;

namespace Devops.Tp1.Domain.Migrations
{
    public partial class GameDbModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthday = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Birthday", "LastName", "Name" },
                values: new object[] { 1, 27111989, "Obregon", "German" });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "Birthday", "LastName", "Name" },
                values: new object[] { 2, 23061996, "Galvan", "Sebastian" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
