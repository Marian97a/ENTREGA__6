﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mvtur_Viagens_API.Context;

#nullable disable

namespace Mvtur_Viagens_API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mvtur_Viagens_API.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Mvtur_Viagens_API.Models.Destinos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Data_ida")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Data_volta")
                        .HasColumnType("double");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Origem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("Mvtur_Viagens_API.Models.Passagens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<double>("Valor_passagens")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("DestinoId");

                    b.ToTable("Passagens");
                });

            modelBuilder.Entity("Mvtur_Viagens_API.Models.Passagens", b =>
                {
                    b.HasOne("Mvtur_Viagens_API.Models.Clientes", "Cliente")
                        .WithMany("Passagens")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mvtur_Viagens_API.Models.Destinos", "Destino")
                        .WithMany("Passagens")
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Destino");
                });

            modelBuilder.Entity("Mvtur_Viagens_API.Models.Clientes", b =>
                {
                    b.Navigation("Passagens");
                });

            modelBuilder.Entity("Mvtur_Viagens_API.Models.Destinos", b =>
                {
                    b.Navigation("Passagens");
                });
#pragma warning restore 612, 618
        }
    }
}