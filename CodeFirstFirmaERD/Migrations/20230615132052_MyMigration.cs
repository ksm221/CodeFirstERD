using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstFirmaERD.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ametinimetused",
                columns: table => new
                {
                    AmetinimetuseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    Ametinimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmetisAl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmetisKuni = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Osakond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtseseÜlemuseEesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtseseÜlemusePerenimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtseseÜlemuseKontakttel = table.Column<int>(type: "int", nullable: true),
                    OtseseÜlemuseEpost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetused", x => x.AmetinimetuseId);
                });

            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    FirmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaRegNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lühinimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Koduleht = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KontaktTel = table.Column<int>(type: "int", nullable: true),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.FirmaId);
                });

            migrationBuilder.CreateTable(
                name: "Harukontor",
                columns: table => new
                {
                    HarukontoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    HarukontoriRegNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lühinimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Koduleht = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KontaktTel = table.Column<int>(type: "int", nullable: true),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontor", x => x.HarukontoriId);
                    table.ForeignKey(
                        name: "FK_Harukontor_Firmas_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmas",
                        principalColumn: "FirmaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Töötaja",
                columns: table => new
                {
                    TöötajaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isikukood = table.Column<int>(type: "int", nullable: true),
                    Kontaktaadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöölAl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TöölKuni = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmetinimetuseId = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    HarukontoriId = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötaja", x => x.TöötajaId);
                    table.ForeignKey(
                        name: "FK_Töötaja_Ametinimetused_AmetinimetuseId",
                        column: x => x.AmetinimetuseId,
                        principalTable: "Ametinimetused",
                        principalColumn: "AmetinimetuseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Töötaja_Firmas_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmas",
                        principalColumn: "FirmaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Töötaja_Harukontor_HarukontoriId",
                        column: x => x.HarukontoriId,
                        principalTable: "Harukontor",
                        principalColumn: "HarukontoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Haiguslehed",
                columns: table => new
                {
                    HaigusleheId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    ÕigusHaiguslehele = table.Column<bool>(type: "bit", nullable: true),
                    HaiguspäeviKokku = table.Column<int>(type: "int", nullable: true),
                    HaigusleheAlgus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HaigusleheLõpp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KasutatudHaigusepäevi = table.Column<int>(type: "int", nullable: true),
                    AllesolevaidHaigusepäevi = table.Column<int>(type: "int", nullable: true),
                    AegunudHaigusepäevi = table.Column<int>(type: "int", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haiguslehed", x => x.HaigusleheId);
                    table.ForeignKey(
                        name: "FK_Haiguslehed_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Laenutu",
                columns: table => new
                {
                    LaenutuseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LaenutatavaKaubaNimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LaenutuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LaenutuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutu", x => x.LaenutuseId);
                    table.ForeignKey(
                        name: "FK_Laenutu_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lapsed",
                columns: table => new
                {
                    LapseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LapseEesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LapsePerenimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LapseSünniaeg = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LapseVanus = table.Column<int>(type: "int", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lapsed", x => x.LapseId);
                    table.ForeignKey(
                        name: "FK_Lapsed_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääsuload",
                columns: table => new
                {
                    LigipääsuloaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LigipääsuÕigus = table.Column<bool>(type: "bit", nullable: true),
                    LigipääsuTase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LigipääsuAlgus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LigipääsuLõpp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääsuload", x => x.LigipääsuloaId);
                    table.ForeignKey(
                        name: "FK_Ligipääsuload_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Puhkused",
                columns: table => new
                {
                    PuhkuseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    PuhkusePäevi = table.Column<int>(type: "int", nullable: true),
                    PuhkuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PuhkuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KasutatudPäevad = table.Column<int>(type: "int", nullable: true),
                    AllesolevadPäevad = table.Column<int>(type: "int", nullable: true),
                    AegunudPuhkusepäevad = table.Column<int>(type: "int", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkused", x => x.PuhkuseId);
                    table.ForeignKey(
                        name: "FK_Puhkused_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontroll",
                columns: table => new
                {
                    TervisekontrolliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    TervisekontrolliVajadus = table.Column<bool>(type: "bit", nullable: true),
                    EelmiseTervisekontrolliKp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UueTervisekontrolliKp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontroll", x => x.TervisekontrolliId);
                    table.ForeignKey(
                        name: "FK_Tervisekontroll_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Haiguslehed_TöötajaId",
                table: "Haiguslehed",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Harukontor_FirmaId",
                table: "Harukontor",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutu_TöötajaId",
                table: "Laenutu",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lapsed_TöötajaId",
                table: "Lapsed",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääsuload_TöötajaId",
                table: "Ligipääsuload",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkused_TöötajaId",
                table: "Puhkused",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontroll_TöötajaId",
                table: "Tervisekontroll",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_AmetinimetuseId",
                table: "Töötaja",
                column: "AmetinimetuseId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_FirmaId",
                table: "Töötaja",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_HarukontoriId",
                table: "Töötaja",
                column: "HarukontoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Haiguslehed");

            migrationBuilder.DropTable(
                name: "Laenutu");

            migrationBuilder.DropTable(
                name: "Lapsed");

            migrationBuilder.DropTable(
                name: "Ligipääsuload");

            migrationBuilder.DropTable(
                name: "Puhkused");

            migrationBuilder.DropTable(
                name: "Tervisekontroll");

            migrationBuilder.DropTable(
                name: "Töötaja");

            migrationBuilder.DropTable(
                name: "Ametinimetused");

            migrationBuilder.DropTable(
                name: "Harukontor");

            migrationBuilder.DropTable(
                name: "Firmas");
        }
    }
}
