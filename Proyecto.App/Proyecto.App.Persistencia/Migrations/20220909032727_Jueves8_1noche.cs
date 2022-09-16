using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.App.Persistencia.Migrations
{
    public partial class Jueves8_1noche : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_ClientePersonaId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_TecnicoPersonaId",
                table: "Citas");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Personas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TecnicoPersonaId",
                table: "Citas",
                newName: "TecnicoId");

            migrationBuilder.RenameColumn(
                name: "ClientePersonaId",
                table: "Citas",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_TecnicoPersonaId",
                table: "Citas",
                newName: "IX_Citas_TecnicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_ClientePersonaId",
                table: "Citas",
                newName: "IX_Citas_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_ClienteId",
                table: "Citas",
                column: "ClienteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_TecnicoId",
                table: "Citas",
                column: "TecnicoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_ClienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_TecnicoId",
                table: "Citas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Personas",
                newName: "PersonaId");

            migrationBuilder.RenameColumn(
                name: "TecnicoId",
                table: "Citas",
                newName: "TecnicoPersonaId");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Citas",
                newName: "ClientePersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_TecnicoId",
                table: "Citas",
                newName: "IX_Citas_TecnicoPersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_ClienteId",
                table: "Citas",
                newName: "IX_Citas_ClientePersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_ClientePersonaId",
                table: "Citas",
                column: "ClientePersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_TecnicoPersonaId",
                table: "Citas",
                column: "TecnicoPersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
