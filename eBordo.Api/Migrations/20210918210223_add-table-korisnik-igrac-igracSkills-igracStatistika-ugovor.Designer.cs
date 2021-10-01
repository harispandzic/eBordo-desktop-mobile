﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eBordo.Api.Database;

namespace eBordo.Api.Migrations
{
    [DbContext(typeof(eBordoContext))]
    [Migration("20210918210223_add-table-korisnik-igrac-igracSkills-igracStatistika-ugovor")]
    partial class addtablekorisnikigracigracSkillsigracStatistikaugovor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eBordo.Api.Database.Drzava", b =>
                {
                    b.Property<int>("drzavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nazivDrzave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zastavaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("drzavaId");

                    b.ToTable("drzave");
                });

            modelBuilder.Entity("eBordo.Api.Database.Grad", b =>
                {
                    b.Property<int>("gradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("drzavaId")
                        .HasColumnType("int");

                    b.Property<string>("nazivGrada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("gradId");

                    b.HasIndex("drzavaId");

                    b.ToTable("gradovi");
                });

            modelBuilder.Entity("eBordo.Api.Database.Igrac", b =>
                {
                    b.Property<int>("igracId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("boljaNoga")
                        .HasColumnType("int");

                    b.Property<int>("brojDresa")
                        .HasColumnType("int");

                    b.Property<DateTime>("datumPristupaKlubu")
                        .HasColumnType("datetime2");

                    b.Property<int>("igracSkillsId")
                        .HasColumnType("int");

                    b.Property<int>("igracStatistikaId")
                        .HasColumnType("int");

                    b.Property<int>("korisnikId")
                        .HasColumnType("int");

                    b.Property<int>("pozicija")
                        .HasColumnType("int");

                    b.Property<string>("slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tezina")
                        .HasColumnType("int");

                    b.Property<float>("trzisnaVrijednost")
                        .HasColumnType("real");

                    b.Property<int>("ugovorId")
                        .HasColumnType("int");

                    b.Property<float>("visina")
                        .HasColumnType("real");

                    b.HasKey("igracId");

                    b.HasIndex("igracSkillsId")
                        .IsUnique();

                    b.HasIndex("igracStatistikaId")
                        .IsUnique();

                    b.HasIndex("korisnikId")
                        .IsUnique();

                    b.HasIndex("ugovorId")
                        .IsUnique();

                    b.ToTable("igraci");
                });

            modelBuilder.Entity("eBordo.Api.Database.IgracSkills", b =>
                {
                    b.Property<int>("igracSkillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("brzina")
                        .HasColumnType("real");

                    b.Property<int>("brzinaZbir")
                        .HasColumnType("int");

                    b.Property<float>("dodavanje")
                        .HasColumnType("real");

                    b.Property<int>("dodavanjeZbir")
                        .HasColumnType("int");

                    b.Property<float>("driblanje")
                        .HasColumnType("real");

                    b.Property<int>("dribljanjeZbir")
                        .HasColumnType("int");

                    b.Property<int?>("igracId")
                        .HasColumnType("int");

                    b.Property<float>("klizeciStart")
                        .HasColumnType("real");

                    b.Property<int>("klizeciStartZbir")
                        .HasColumnType("int");

                    b.Property<float>("kontrolaLopte")
                        .HasColumnType("real");

                    b.Property<int>("kontrolaLopteZbir")
                        .HasColumnType("int");

                    b.Property<float>("kretanje")
                        .HasColumnType("real");

                    b.Property<int>("kretanjeZbir")
                        .HasColumnType("int");

                    b.Property<float>("markiranje")
                        .HasColumnType("real");

                    b.Property<int>("markiranjeZbir")
                        .HasColumnType("int");

                    b.Property<float>("odbrana")
                        .HasColumnType("real");

                    b.Property<int>("odbranaZbir")
                        .HasColumnType("int");

                    b.Property<float>("prosjekOcjena")
                        .HasColumnType("real");

                    b.Property<float>("skok")
                        .HasColumnType("real");

                    b.Property<int>("skokZbir")
                        .HasColumnType("int");

                    b.Property<float>("snaga")
                        .HasColumnType("real");

                    b.Property<int>("snagaZbir")
                        .HasColumnType("int");

                    b.Property<float>("sut")
                        .HasColumnType("real");

                    b.Property<int>("sutZbir")
                        .HasColumnType("int");

                    b.Property<float>("zbirOcjena")
                        .HasColumnType("real");

                    b.HasKey("igracSkillsId");

                    b.ToTable("igracSkills");
                });

            modelBuilder.Entity("eBordo.Api.Database.IgracStatistika", b =>
                {
                    b.Property<int>("igracStatistikaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("asistencije")
                        .HasColumnType("int");

                    b.Property<int>("brojNastupa")
                        .HasColumnType("int");

                    b.Property<int>("crveniKartoni")
                        .HasColumnType("int");

                    b.Property<int>("golovi")
                        .HasColumnType("int");

                    b.Property<int?>("igracId")
                        .HasColumnType("int");

                    b.Property<float>("prosjecnaOcjena")
                        .HasColumnType("real");

                    b.Property<int>("zbirOcjena")
                        .HasColumnType("int");

                    b.Property<int>("zutiKartoni")
                        .HasColumnType("int");

                    b.HasKey("igracStatistikaId");

                    b.ToTable("igracStatistika");
                });

            modelBuilder.Entity("eBordo.Api.Database.Korisnik", b =>
                {
                    b.Property<int>("korisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<int>("drzavljanstvoId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gradRodjenjaId")
                        .HasColumnType("int");

                    b.Property<int>("igracId")
                        .HasColumnType("int");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isIgrac")
                        .HasColumnType("bit");

                    b.Property<bool>("isTrener")
                        .HasColumnType("bit");

                    b.Property<string>("korisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("korisnikId");

                    b.HasIndex("drzavljanstvoId");

                    b.HasIndex("gradRodjenjaId");

                    b.ToTable("korisnici");
                });

            modelBuilder.Entity("eBordo.Api.Database.Ugovor", b =>
                {
                    b.Property<int>("ugovorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumZavrsetka")
                        .HasColumnType("datetime2");

                    b.Property<int?>("igracId")
                        .HasColumnType("int");

                    b.Property<float>("iznosPlate")
                        .HasColumnType("real");

                    b.HasKey("ugovorId");

                    b.ToTable("ugovori");
                });

            modelBuilder.Entity("eBordo.Api.Database.Grad", b =>
                {
                    b.HasOne("eBordo.Api.Database.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("drzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drzava");
                });

            modelBuilder.Entity("eBordo.Api.Database.Igrac", b =>
                {
                    b.HasOne("eBordo.Api.Database.IgracSkills", "igracSkills")
                        .WithOne("igrac")
                        .HasForeignKey("eBordo.Api.Database.Igrac", "igracSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBordo.Api.Database.IgracStatistika", "igracStatistika")
                        .WithOne("igrac")
                        .HasForeignKey("eBordo.Api.Database.Igrac", "igracStatistikaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBordo.Api.Database.Korisnik", "korisnik")
                        .WithOne("igrac")
                        .HasForeignKey("eBordo.Api.Database.Igrac", "korisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBordo.Api.Database.Ugovor", "ugovor")
                        .WithOne("igrac")
                        .HasForeignKey("eBordo.Api.Database.Igrac", "ugovorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("igracSkills");

                    b.Navigation("igracStatistika");

                    b.Navigation("korisnik");

                    b.Navigation("ugovor");
                });

            modelBuilder.Entity("eBordo.Api.Database.Korisnik", b =>
                {
                    b.HasOne("eBordo.Api.Database.Drzava", "drzavljanstvo")
                        .WithMany()
                        .HasForeignKey("drzavljanstvoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBordo.Api.Database.Grad", "gradRodjenja")
                        .WithMany()
                        .HasForeignKey("gradRodjenjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drzavljanstvo");

                    b.Navigation("gradRodjenja");
                });

            modelBuilder.Entity("eBordo.Api.Database.IgracSkills", b =>
                {
                    b.Navigation("igrac");
                });

            modelBuilder.Entity("eBordo.Api.Database.IgracStatistika", b =>
                {
                    b.Navigation("igrac");
                });

            modelBuilder.Entity("eBordo.Api.Database.Korisnik", b =>
                {
                    b.Navigation("igrac");
                });

            modelBuilder.Entity("eBordo.Api.Database.Ugovor", b =>
                {
                    b.Navigation("igrac");
                });
#pragma warning restore 612, 618
        }
    }
}
