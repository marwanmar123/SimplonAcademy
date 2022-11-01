﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimplonAcademy.Data;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221013152840_homed")]
    partial class homed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SimplonAcademy.Models.Formation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Certification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Competences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DayStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durée")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FormationTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Presentation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeBeginning")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VilleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FormationTypeId");

                    b.HasIndex("VilleId");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("SimplonAcademy.Models.FormationType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormationTypes");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Home", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CallContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescrpContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescrpHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescrpOffre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescrpTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageHeader")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LocalContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleOffre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleTeam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Image", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Data")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SimplonAcademy.Models.InscriptionForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FormationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("JobRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormationId");

                    b.ToTable("InscriptionForms");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HomeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("TitleMenu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescriptionTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HomeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ImageTeam")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("InstagramTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedinTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterTeam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SimplonAcademy.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SimplonAcademy.Models.Ville", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Villes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SimplonAcademy.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SimplonAcademy.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimplonAcademy.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SimplonAcademy.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimplonAcademy.Models.Formation", b =>
                {
                    b.HasOne("SimplonAcademy.Models.FormationType", "FormationType")
                        .WithMany("Formations")
                        .HasForeignKey("FormationTypeId");

                    b.HasOne("SimplonAcademy.Models.Ville", "Ville")
                        .WithMany("Formations")
                        .HasForeignKey("VilleId");

                    b.Navigation("FormationType");

                    b.Navigation("Ville");
                });

            modelBuilder.Entity("SimplonAcademy.Models.InscriptionForm", b =>
                {
                    b.HasOne("SimplonAcademy.Models.Formation", "Formation")
                        .WithMany("InscriptionForm")
                        .HasForeignKey("FormationId");

                    b.Navigation("Formation");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Menu", b =>
                {
                    b.HasOne("SimplonAcademy.Models.Home", "Home")
                        .WithMany("Menus")
                        .HasForeignKey("HomeId");

                    b.Navigation("Home");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Team", b =>
                {
                    b.HasOne("SimplonAcademy.Models.Home", "Home")
                        .WithMany("Teams")
                        .HasForeignKey("HomeId");

                    b.Navigation("Home");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Formation", b =>
                {
                    b.Navigation("InscriptionForm");
                });

            modelBuilder.Entity("SimplonAcademy.Models.FormationType", b =>
                {
                    b.Navigation("Formations");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Home", b =>
                {
                    b.Navigation("Menus");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("SimplonAcademy.Models.Ville", b =>
                {
                    b.Navigation("Formations");
                });
#pragma warning restore 612, 618
        }
    }
}
