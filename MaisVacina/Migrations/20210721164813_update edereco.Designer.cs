﻿// <auto-generated />
using System;
using MaisVacina.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaisVacina.Migrations
{
    [DbContext(typeof(MaisVacinaContext))]
    [Migration("20210721164813_update edereco")]
    partial class updateedereco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MaisVacina.Models.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("MaisVacina.Models.Login", b =>
                {
                    b.Property<int>("Idlogin")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Emaillogin");

                    b.Property<string>("Nomelogin");

                    b.Property<string>("Senhalogin");

                    b.Property<string>("Usuario");

                    b.HasKey("Idlogin");

                    b.ToTable("Login");
                });
#pragma warning restore 612, 618
        }
    }
}
