using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class comment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Place",
                table: "Comments",
                newName: "Places");

            migrationBuilder.AddColumn<int>(
                name: "PlaceID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PlaceID",
                table: "Comments",
                column: "PlaceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Places_PlaceID",
                table: "Comments",
                column: "PlaceID",
                principalTable: "Places",
                principalColumn: "PlaceID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Places_PlaceID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PlaceID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PlaceID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Places",
                table: "Comments",
                newName: "Place");
        }
    }
}
