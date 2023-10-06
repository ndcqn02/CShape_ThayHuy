using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _222LTC02_2050531200110_NguyenDucCuong.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguoiMua",
                columns: table => new
                {
                    NguoiMuaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiMua", x => x.NguoiMuaId);
                });

            migrationBuilder.CreateTable(
                name: "ThucPham",
                columns: table => new
                {
                    ThucPhamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucPham", x => x.ThucPhamId);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    GioHangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThucPhamId = table.Column<int>(type: "int", nullable: false),
                    NguoiMuaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.GioHangId);
                    table.ForeignKey(
                        name: "FK_GioHang_NguoiMua_NguoiMuaId",
                        column: x => x.NguoiMuaId,
                        principalTable: "NguoiMua",
                        principalColumn: "NguoiMuaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHang_ThucPham_ThucPhamId",
                        column: x => x.ThucPhamId,
                        principalTable: "ThucPham",
                        principalColumn: "ThucPhamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_NguoiMuaId",
                table: "GioHang",
                column: "NguoiMuaId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_ThucPhamId",
                table: "GioHang",
                column: "ThucPhamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "NguoiMua");

            migrationBuilder.DropTable(
                name: "ThucPham");
        }
    }
}
