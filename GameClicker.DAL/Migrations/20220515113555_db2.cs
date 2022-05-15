using Microsoft.EntityFrameworkCore.Migrations;

namespace GameClicker.DAL.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecreaseHpRegen = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PetId",
                table: "Users",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Pets_PetId",
                table: "Users",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Pets_PetId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Users_PetId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "Users");
        }
    }
}
