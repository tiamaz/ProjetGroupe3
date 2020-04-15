using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetGroupe3.Migrations
{
    public partial class AddTableToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classe",
                columns: table => new
                {
                    IdClasse = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomClasse = table.Column<string>(nullable: false),
                    Filiere = table.Column<string>(nullable: false),
                    Niveau = table.Column<string>(nullable: false),
                    NombreEtudiant = table.Column<int>(nullable: false),
                    IdProf = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classe", x => x.IdClasse);
                    table.ForeignKey(
                        name: "FK_classe_AspNetUsers_IdProf",
                        column: x => x.IdProf,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etudiantClasse",
                columns: table => new
                {
                    IdEtudiantClasse = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEtudiant = table.Column<string>(nullable: false),
                    IdClasse = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etudiantClasse", x => x.IdEtudiantClasse);
                    table.ForeignKey(
                        name: "FK_etudiantClasse_classe_IdClasse",
                        column: x => x.IdClasse,
                        principalTable: "classe",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etudiantClasse_AspNetUsers_IdEtudiant",
                        column: x => x.IdEtudiant,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "publication",
                columns: table => new
                {
                    IdPublication = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Contenu = table.Column<string>(nullable: false),
                    DatePublication = table.Column<string>(nullable: false),
                    IdClasse = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publication", x => x.IdPublication);
                    table.ForeignKey(
                        name: "FK_publication_classe_IdClasse",
                        column: x => x.IdClasse,
                        principalTable: "classe",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classe_IdProf",
                table: "classe",
                column: "IdProf");

            migrationBuilder.CreateIndex(
                name: "IX_etudiantClasse_IdClasse",
                table: "etudiantClasse",
                column: "IdClasse");

            migrationBuilder.CreateIndex(
                name: "IX_etudiantClasse_IdEtudiant",
                table: "etudiantClasse",
                column: "IdEtudiant");

            migrationBuilder.CreateIndex(
                name: "IX_publication_IdClasse",
                table: "publication",
                column: "IdClasse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "etudiantClasse");

            migrationBuilder.DropTable(
                name: "publication");

            migrationBuilder.DropTable(
                name: "classe");
        }
    }
}
