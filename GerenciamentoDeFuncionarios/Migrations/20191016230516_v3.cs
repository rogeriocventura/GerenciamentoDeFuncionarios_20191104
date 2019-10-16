using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciamentoDeFuncionarios.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Departamento_LotacaoId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Departamento_DepartamentoId",
                table: "Pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_DepartamentoId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Funcionario");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoa_LotacaoId",
                table: "Funcionario",
                newName: "IX_Funcionario_LotacaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Departamento_LotacaoId",
                table: "Funcionario",
                column: "LotacaoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Departamento_LotacaoId",
                table: "Funcionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario");

            migrationBuilder.RenameTable(
                name: "Funcionario",
                newName: "Pessoa");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionario_LotacaoId",
                table: "Pessoa",
                newName: "IX_Pessoa_LotacaoId");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pessoa",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_DepartamentoId",
                table: "Pessoa",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Departamento_LotacaoId",
                table: "Pessoa",
                column: "LotacaoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Departamento_DepartamentoId",
                table: "Pessoa",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
