﻿// <auto-generated />
using System;
using Examen.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infra.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgentId"));

                    b.Property<DateTime>("DateEmbauche")
                        .HasColumnType("datetime2");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgentId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Locataire", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AgentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdhesion")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocataireType")
                        .HasColumnType("int");

                    b.Property<int>("PointsBouns")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("AgentId");

                    b.ToTable("Locataires");

                    b.HasDiscriminator<int>("LocataireType").HasValue(0);

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Reservation", b =>
                {
                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocataireKey")
                        .HasColumnType("int");

                    b.Property<int>("VehiculeKey")
                        .HasColumnType("int");

                    b.Property<int>("DureeJours")
                        .HasColumnType("int");

                    b.HasKey("DateReservation", "LocataireKey", "VehiculeKey");

                    b.HasIndex("LocataireKey");

                    b.HasIndex("VehiculeKey");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Vehicule", b =>
                {
                    b.Property<int>("VehiculeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehiculeId"));

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<string>("Couleur")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Kilometrage")
                        .HasColumnType("int");

                    b.Property<double>("PrixJour")
                        .HasColumnType("float");

                    b.HasKey("VehiculeId");

                    b.HasIndex("AgentId");

                    b.ToTable("Vehicules");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Entreprise", b =>
                {
                    b.HasBaseType("Examen.ApplicationCore.Domain.Locataire");

                    b.Property<string>("Inutile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Personne", b =>
                {
                    b.HasBaseType("Examen.ApplicationCore.Domain.Locataire");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Locataire", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Agent", null)
                        .WithMany("locataires")
                        .HasForeignKey("AgentId");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Reservation", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Locataire", "locataire")
                        .WithMany("reservations")
                        .HasForeignKey("LocataireKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Vehicule", "vehicule")
                        .WithMany("reservations")
                        .HasForeignKey("VehiculeKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("locataire");

                    b.Navigation("vehicule");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Vehicule", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Agent", "agent")
                        .WithMany()
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("agent");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Agent", b =>
                {
                    b.Navigation("locataires");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Locataire", b =>
                {
                    b.Navigation("reservations");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Vehicule", b =>
                {
                    b.Navigation("reservations");
                });
#pragma warning restore 612, 618
        }
    }
}