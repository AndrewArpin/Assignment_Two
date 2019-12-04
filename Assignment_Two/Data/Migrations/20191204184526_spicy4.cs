using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_Two.Data.Migrations
{
    public partial class spicy4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Teams_TeamID",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Owners",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Teams_TeamID",
                table: "Owners",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Teams_TeamID",
                table: "Owners");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Owners",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Teams_TeamID",
                table: "Owners",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
