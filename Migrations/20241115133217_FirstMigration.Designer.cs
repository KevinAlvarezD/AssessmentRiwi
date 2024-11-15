﻿// <auto-generated />
using AssessmentRiwi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssessmentRiwi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241115133217_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AssessmentRiwi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("OfficeHours")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("AssessmentRiwi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Email = "kev@riwi.io",
                            LastName = "Alvarez Diaz",
                            Name = "Kevin ",
                            Password = "$2a$11$WTxy.q9QhVH6kFKwNB.3t.NzZVDNkIim1eaVlIy.dy6Yt6QZgKFBS",
                            Role = "admin"
                        },
                        new
                        {
                            Id = 6,
                            Email = "keyla.lopera@riwi.io",
                            LastName = "Mesa Lopera",
                            Name = "Keyla",
                            Password = "$2a$11$yr4R6NGsg9sh3cECcTT4SOJamsxZ8VzplvMiwChtZRUWlec8S8UyK",
                            Role = "doctor"
                        });
                });

            modelBuilder.Entity("AssessmentRiwi.Models.Doctor", b =>
                {
                    b.HasOne("AssessmentRiwi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}