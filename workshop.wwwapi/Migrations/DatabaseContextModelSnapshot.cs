﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("patient_id");

                    b.Property<DateTime>("Booking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("appointment_time");

                    b.HasKey("DoctorId", "PatientId");

                    b.HasIndex("PatientId");

                    b.ToTable("appointment");

                    b.HasData(
                        new
                        {
                            DoctorId = 4,
                            PatientId = 4,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9651)
                        },
                        new
                        {
                            DoctorId = 4,
                            PatientId = 3,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9654)
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 3,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9654)
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 4,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9655)
                        },
                        new
                        {
                            DoctorId = 4,
                            PatientId = 7,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9655)
                        },
                        new
                        {
                            DoctorId = 7,
                            PatientId = 6,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9656)
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 5,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9657)
                        },
                        new
                        {
                            DoctorId = 7,
                            PatientId = 1,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9657)
                        },
                        new
                        {
                            DoctorId = 1,
                            PatientId = 7,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9658)
                        },
                        new
                        {
                            DoctorId = 6,
                            PatientId = 3,
                            Booking = new DateTime(2024, 2, 2, 12, 47, 25, 805, DateTimeKind.Utc).AddTicks(9658)
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.HasKey("Id");

                    b.ToTable("doctor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Elvis Obama"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Audrey Jagger"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Mick Hepburn"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Elvis Presley"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Elvis Jagger"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Charles Presley"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Charles Obama"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Donald Trump"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Jimi Trump"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Audrey Trump"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.HasKey("Id");

                    b.ToTable("patient");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Elvis Hepburn"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Kate Winslet"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Kate Jagger"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Oprah Hepburn"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Oprah Winslet"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Kate Hendrix"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Elvis Winfrey"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Kate Windsor"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Kate Hepburn"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Kate Obama"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.Doctor", null)
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.Patient", null)
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
