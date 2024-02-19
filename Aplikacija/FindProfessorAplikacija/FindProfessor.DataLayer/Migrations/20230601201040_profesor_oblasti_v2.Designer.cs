﻿// <auto-generated />
using System;
using FindProfessor.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FindProfessor.DataLayer.Migrations
{
    [DbContext(typeof(fpDbContext))]
    [Migration("20230601201040_profesor_oblasti_v2")]
    partial class profesor_oblasti_v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FindProfessor.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Korisnici");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("FindProfessor.Models.LogIn", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("LogIn");
                });

            modelBuilder.Entity("FindProfessor.Models.Recenzija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Komentar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Ocena")
                        .HasColumnType("float");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<int>("UcenikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vreme")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Recenzije");
                });

            modelBuilder.Entity("FindProfessor.Models.Termin", b =>
                {
                    b.Property<int>("TerminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TerminId"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KrajnjeVreme")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PocetnoVreme")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("TerminId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Termini");
                });

            modelBuilder.Entity("FindProfessor.Models.Usluga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Kraj")
                        .HasColumnType("datetime2");

                    b.Property<string>("Napomena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Pocetak")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UcenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.HasIndex("UcenikId");

                    b.ToTable("Usluge");
                });

            modelBuilder.Entity("FindProfessor.Models.Zakazivanje", b =>
                {
                    b.Property<int>("ZakazivanjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZakazivanjeId"));

                    b.Property<int>("TerminId")
                        .HasColumnType("int");

                    b.Property<int>("UcenikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ZakazanoTad")
                        .HasColumnType("datetime2");

                    b.HasKey("ZakazivanjeId");

                    b.HasIndex("TerminId");

                    b.HasIndex("UcenikId");

                    b.ToTable("Zakazivanja");
                });

            modelBuilder.Entity("FindProfessor.Models.Admin", b =>
                {
                    b.HasBaseType("FindProfessor.Models.Korisnik");

                    b.ToTable("Admini");
                });

            modelBuilder.Entity("FindProfessor.Models.Profesor", b =>
                {
                    b.HasBaseType("FindProfessor.Models.Korisnik");

                    b.Property<double>("CenaPoSatu")
                        .HasColumnType("float");

                    b.Property<string>("Oblast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProsecnaOcena")
                        .HasColumnType("float");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Validan")
                        .HasColumnType("bit");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("FindProfessor.Models.Ucenik", b =>
                {
                    b.HasBaseType("FindProfessor.Models.Korisnik");

                    b.Property<int>("Razred")
                        .HasColumnType("int");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Ucenik");
                });

            modelBuilder.Entity("FindProfessor.Models.Recenzija", b =>
                {
                    b.HasOne("FindProfessor.Models.Profesor", null)
                        .WithMany("Recenzije")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FindProfessor.Models.Termin", b =>
                {
                    b.HasOne("FindProfessor.Models.Profesor", "Profesor")
                        .WithMany("Termini")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("FindProfessor.Models.Usluga", b =>
                {
                    b.HasOne("FindProfessor.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FindProfessor.Models.Ucenik", "Ucenik")
                        .WithMany()
                        .HasForeignKey("UcenikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profesor");

                    b.Navigation("Ucenik");
                });

            modelBuilder.Entity("FindProfessor.Models.Zakazivanje", b =>
                {
                    b.HasOne("FindProfessor.Models.Termin", "Termin")
                        .WithMany()
                        .HasForeignKey("TerminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FindProfessor.Models.Ucenik", "Ucenik")
                        .WithMany()
                        .HasForeignKey("UcenikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Termin");

                    b.Navigation("Ucenik");
                });

            modelBuilder.Entity("FindProfessor.Models.Admin", b =>
                {
                    b.HasOne("FindProfessor.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("FindProfessor.Models.Admin", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FindProfessor.Models.Profesor", b =>
                {
                    b.HasOne("FindProfessor.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("FindProfessor.Models.Profesor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FindProfessor.Models.Ucenik", b =>
                {
                    b.HasOne("FindProfessor.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("FindProfessor.Models.Ucenik", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FindProfessor.Models.Profesor", b =>
                {
                    b.Navigation("Recenzije");

                    b.Navigation("Termini");
                });
#pragma warning restore 612, 618
        }
    }
}
