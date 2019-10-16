﻿// <auto-generated />
using GerenciamentoDeFuncionarios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GerenciamentoDeFuncionarios.Migrations
{
    [DbContext(typeof(FuncionariosContext))]
    partial class FuncionariosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciamentoDeFuncionarios.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("GerenciamentoDeFuncionarios.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LotacaoId");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("LotacaoId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("GerenciamentoDeFuncionarios.Models.Funcionario", b =>
                {
                    b.HasOne("GerenciamentoDeFuncionarios.Models.Departamento", "Lotacao")
                        .WithMany("Funcionarios")
                        .HasForeignKey("LotacaoId");
                });
#pragma warning restore 612, 618
        }
    }
}
