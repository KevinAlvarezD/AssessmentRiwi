﻿// <auto-generated />
using System;
using AssessmentRiwi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssessmentRiwi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AssessmentRiwi.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("appointment_date");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("reason");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("AssessmentRiwi.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctor_id");

                    b.Property<TimeSpan>("EndHour")
                        .HasColumnType("time(6)")
                        .HasColumnName("end_hour");

                    b.Property<TimeSpan>("StartHour")
                        .HasColumnType("time(6)")
                        .HasColumnName("start_hour");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("availabilities");
                });

            modelBuilder.Entity("AssessmentRiwi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("OfficeHours")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("office_hours");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("specialty");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("AssessmentRiwi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("MedicalHistory")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("medical_history");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("patients");
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
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Email = "kev@riwi.io",
                            LastName = "Alvarez Diaz",
                            Name = "Kevin ",
                            Password = "$2a$11$K0Tyxmfg/9RFFwj9v0t1tuStHOZg/7NSBwVWjyjWu0onLSdeZ.Dly",
                            Role = "admin"
                        },
                        new
                        {
                            Id = 6,
                            Email = "keyla.lopera@riwi.io",
                            LastName = "Mesa Lopera",
                            Name = "Keyla",
                            Password = "$2a$11$98.FdpAbIdvC5MqWJK7xkuGqkaCL5eS5x7HMTsgqujUl99wn/ZFa.",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 7,
                            Email = "juan.perez@riwi.io",
                            LastName = "Perez",
                            Name = "Juan",
                            Password = "$2a$11$ZKY22dpzcBpVwAgumft0we8iIGCELInAAt88fIgzS6Ae5vpvkyKIO",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 8,
                            Email = "marta.gomez@riwi.io",
                            LastName = "Gomez",
                            Name = "Marta",
                            Password = "$2a$11$fENMpX2z3MntoGUTFcrf7.9QEc13Iy69Cv7/2AUSNNlGchNvhXLDC",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 9,
                            Email = "carlos.lopez@riwi.io",
                            LastName = "Lopez",
                            Name = "Carlos",
                            Password = "$2a$11$aIxVWrPj6XGQ6Qwz3gngnu0n5.kitXripRVCjAJudYFdS2qIawLLq",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 10,
                            Email = "ana.martinez@riwi.io",
                            LastName = "Martinez",
                            Name = "Ana",
                            Password = "$2a$11$54sp1mz33gZzZ80i.Eq0Hu2i1GiW00lKrb8LbqAzxSRiUfGvrGO/e",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 11,
                            Email = "luis.ramirez@riwi.io",
                            LastName = "Ramirez",
                            Name = "Luis",
                            Password = "$2a$11$szhSGX0Tf7xm8vvlk6Wp3u/wRZzlyLsnwclR91F.rdpNx76tNE9Ae",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 12,
                            Email = "sofia.diaz@riwi.io",
                            LastName = "Diaz",
                            Name = "Sofia",
                            Password = "$2a$11$clps.teLD29jP7q2bdge7O2tWqX0e3pcig3zWEkhlOyc4ApbCjR4O",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 13,
                            Email = "felipe.mendez@riwi.io",
                            LastName = "Mendez",
                            Name = "Felipe",
                            Password = "$2a$11$aKa76XXXzNxYXkLK861dDubz7XA5zveMCaQwSp5KJmbN8lB.h9a5q",
                            Role = "patient"
                        });
                });

            modelBuilder.Entity("AssessmentRiwi.Models.Appointment", b =>
                {
                    b.HasOne("AssessmentRiwi.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssessmentRiwi.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("AssessmentRiwi.Models.Availability", b =>
                {
                    b.HasOne("AssessmentRiwi.Models.Doctor", "Doctor")
                        .WithMany("Availabilities")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
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

            modelBuilder.Entity("AssessmentRiwi.Models.Patient", b =>
                {
                    b.HasOne("AssessmentRiwi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AssessmentRiwi.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Availabilities");
                });

            modelBuilder.Entity("AssessmentRiwi.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
