using Microsoft.EntityFrameworkCore.Migrations;

namespace ProdCate.Migrations
{
    public partial class HopefullyLastUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assos_Cates_CateId",
                table: "Assos");

            migrationBuilder.RenameColumn(
                name: "CateId",
                table: "Assos",
                newName: "Cateid");

            migrationBuilder.RenameIndex(
                name: "IX_Assos_CateId",
                table: "Assos",
                newName: "IX_Assos_Cateid");

            migrationBuilder.AddForeignKey(
                name: "FK_Assos_Cates_Cateid",
                table: "Assos",
                column: "Cateid",
                principalTable: "Cates",
                principalColumn: "Cateid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assos_Cates_Cateid",
                table: "Assos");

            migrationBuilder.RenameColumn(
                name: "Cateid",
                table: "Assos",
                newName: "CateId");

            migrationBuilder.RenameIndex(
                name: "IX_Assos_Cateid",
                table: "Assos",
                newName: "IX_Assos_CateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assos_Cates_CateId",
                table: "Assos",
                column: "CateId",
                principalTable: "Cates",
                principalColumn: "Cateid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
