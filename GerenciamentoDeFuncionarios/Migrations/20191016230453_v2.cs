using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciamentoDeFuncionarios.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LotacaoId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pessoa",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_LotacaoId",
                table: "Pessoa",
                column: "LotacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Departamento_LotacaoId",
                table: "Pessoa",
                column: "LotacaoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Departamento_LotacaoId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_LotacaoId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "LotacaoId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pessoa");
        }
    }
}
