using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcEfCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangVes",
                columns: table => new
                {
                    HangID = table.Column<string>(maxLength: 5, nullable: false),
                    TenHang = table.Column<string>(nullable: true),
                    TiLeGia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangVes", x => x.HangID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    KhachHangID = table.Column<string>(maxLength: 30, nullable: false),
                    TenKhachHang = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    CMND = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.KhachHangID);
                });

            migrationBuilder.CreateTable(
                name: "LichChuyenBays",
                columns: table => new
                {
                    ChuyenBayID = table.Column<string>(maxLength: 10, nullable: false),
                    NgayGioBay = table.Column<DateTime>(nullable: false),
                    GiaVe = table.Column<int>(nullable: false),
                    ThoiGianBay = table.Column<int>(nullable: false),
                    SoGheHang1 = table.Column<int>(nullable: false),
                    SoGheHang2 = table.Column<int>(nullable: false),
                    Trangthai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChuyenBays", x => x.ChuyenBayID);
                });

            migrationBuilder.CreateTable(
                name: "SanBays",
                columns: table => new
                {
                    SanBayId = table.Column<string>(maxLength: 6, nullable: false),
                    TenSanBay = table.Column<string>(nullable: false),
                    ThanhPho = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanBays", x => x.SanBayId);
                });

            migrationBuilder.CreateTable(
                name: "ThamSos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    GiaTri = table.Column<int>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThamSos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatChos",
                columns: table => new
                {
                    PhieuDatChoID = table.Column<string>(nullable: false),
                    GiaTien = table.Column<double>(nullable: false),
                    HangID = table.Column<string>(nullable: true),
                    KhachHangID = table.Column<string>(nullable: true),
                    ChuyenBayID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatChos", x => x.PhieuDatChoID);
                    table.ForeignKey(
                        name: "FK_PhieuDatChos_LichChuyenBays_ChuyenBayID",
                        column: x => x.ChuyenBayID,
                        principalTable: "LichChuyenBays",
                        principalColumn: "ChuyenBayID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDatChos_HangVes_HangID",
                        column: x => x.HangID,
                        principalTable: "HangVes",
                        principalColumn: "HangID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDatChos_KhachHangs_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHangs",
                        principalColumn: "KhachHangID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatVes",
                columns: table => new
                {
                    PhieuDatVeID = table.Column<string>(nullable: false),
                    GiaTien = table.Column<int>(nullable: false),
                    HangID = table.Column<string>(nullable: true),
                    KhachHangID = table.Column<string>(nullable: true),
                    ChuyenBayID = table.Column<string>(nullable: true),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatVes", x => x.PhieuDatVeID);
                    table.ForeignKey(
                        name: "FK_PhieuDatVes_LichChuyenBays_ChuyenBayID",
                        column: x => x.ChuyenBayID,
                        principalTable: "LichChuyenBays",
                        principalColumn: "ChuyenBayID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDatVes_HangVes_HangID",
                        column: x => x.HangID,
                        principalTable: "HangVes",
                        principalColumn: "HangID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDatVes_KhachHangs_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHangs",
                        principalColumn: "KhachHangID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTrungGians",
                columns: table => new
                {
                    ChiTietID = table.Column<string>(maxLength: 10, nullable: false),
                    ThoiGian = table.Column<int>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    SanBayDen = table.Column<string>(nullable: true),
                    SanBayId = table.Column<string>(nullable: true),
                    ChuyenBayID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTrungGians", x => x.ChiTietID);
                    table.ForeignKey(
                        name: "FK_ChiTietTrungGians_LichChuyenBays_ChuyenBayID",
                        column: x => x.ChuyenBayID,
                        principalTable: "LichChuyenBays",
                        principalColumn: "ChuyenBayID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietTrungGians_SanBays_SanBayId",
                        column: x => x.SanBayId,
                        principalTable: "SanBays",
                        principalColumn: "SanBayId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTrungGians_ChuyenBayID",
                table: "ChiTietTrungGians",
                column: "ChuyenBayID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTrungGians_SanBayId",
                table: "ChiTietTrungGians",
                column: "SanBayId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatChos_ChuyenBayID",
                table: "PhieuDatChos",
                column: "ChuyenBayID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatChos_HangID",
                table: "PhieuDatChos",
                column: "HangID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatChos_KhachHangID",
                table: "PhieuDatChos",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatVes_ChuyenBayID",
                table: "PhieuDatVes",
                column: "ChuyenBayID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatVes_HangID",
                table: "PhieuDatVes",
                column: "HangID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatVes_KhachHangID",
                table: "PhieuDatVes",
                column: "KhachHangID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChiTietTrungGians");

            migrationBuilder.DropTable(
                name: "PhieuDatChos");

            migrationBuilder.DropTable(
                name: "PhieuDatVes");

            migrationBuilder.DropTable(
                name: "ThamSos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SanBays");

            migrationBuilder.DropTable(
                name: "LichChuyenBays");

            migrationBuilder.DropTable(
                name: "HangVes");

            migrationBuilder.DropTable(
                name: "KhachHangs");
        }
    }
}
