using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProdCate.Migrations
{
    public partial class FirstProdCateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prods",
                columns: table => new
                {
                    ProdId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdName = table.Column<string>(nullable: false),
                    ProdDescribe = table.Column<string>(nullable: false),
                    ProdPrice = table.Column<float>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prods", x => x.ProdId);
                });

            migrationBuilder.CreateTable(
                name: "Cates",
                columns: table => new
                {
                    Cateid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CateName = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    ProdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cates", x => x.Cateid);
                    table.ForeignKey(
                        name: "FK_Cates_Prods_ProdId",
                        column: x => x.ProdId,
                        principalTable: "Prods",
                        principalColumn: "ProdId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assos",
                columns: table => new
                {
                    AssoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdId = table.Column<int>(nullable: false),
                    CateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assos", x => x.AssoId);
                    table.ForeignKey(
                        name: "FK_Assos_Cates_CateId",
                        column: x => x.CateId,
                        principalTable: "Cates",
                        principalColumn: "Cateid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assos_Prods_ProdId",
                        column: x => x.ProdId,
                        principalTable: "Prods",
                        principalColumn: "ProdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assos_CateId",
                table: "Assos",
                column: "CateId");

            migrationBuilder.CreateIndex(
                name: "IX_Assos_ProdId",
                table: "Assos",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_Cates_ProdId",
                table: "Cates",
                column: "ProdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assos");

            migrationBuilder.DropTable(
                name: "Cates");

            migrationBuilder.DropTable(
                name: "Prods");
        }
    }
}
