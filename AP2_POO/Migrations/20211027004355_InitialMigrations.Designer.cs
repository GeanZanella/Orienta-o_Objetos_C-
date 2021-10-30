﻿// <auto-generated />
using System;
using AP2_POO.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AP2_POO.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211027004355_InitialMigrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AP2_POO.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DataLeitura")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("KwGasto")
                        .HasColumnType("integer");

                    b.Property<double>("MediaConsumo")
                        .HasColumnType("double precision");

                    b.Property<int>("NumLeitura")
                        .HasColumnType("integer");

                    b.Property<double>("ValorPagar")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Contas");
                });
#pragma warning restore 612, 618
        }
    }
}
