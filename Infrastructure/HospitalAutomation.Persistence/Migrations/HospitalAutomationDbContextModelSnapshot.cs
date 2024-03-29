﻿// <auto-generated />
using System;
using HospitalAutomation.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HospitalAutomation.Persistence.Migrations
{
    [DbContext(typeof(HospitalAutomationDbContext))]
    partial class HospitalAutomationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DoctorPatient", b =>
                {
                    b.Property<Guid>("DoctorsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uuid");

                    b.HasKey("DoctorsId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("DoctorPatient");
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PoliclinicId")
                        .HasColumnType("uuid");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PoliclinicId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("BloodGroupType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GenderType")
                        .HasColumnType("integer");

                    b.Property<long>("IdentificationNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Policlinic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Policlinics");
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Protocol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<int>("InsuranceType")
                        .HasColumnType("integer");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PoliclinicId")
                        .HasColumnType("uuid");

                    b.Property<int>("PoliclinicType")
                        .HasColumnType("integer");

                    b.Property<int>("ProvisionType")
                        .HasColumnType("integer");

                    b.Property<int>("TrackingType")
                        .HasColumnType("integer");

                    b.Property<int>("TreatmentType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PoliclinicId");

                    b.ToTable("Protocols");
                });

            modelBuilder.Entity("DoctorPatient", b =>
                {
                    b.HasOne("HospitalAutomation.Domain.Entities.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAutomation.Domain.Entities.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Doctor", b =>
                {
                    b.HasOne("HospitalAutomation.Domain.Entities.Policlinic", "Policlinic")
                        .WithMany("Doctors")
                        .HasForeignKey("PoliclinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Protocol", b =>
                {
                    b.HasOne("HospitalAutomation.Domain.Entities.Doctor", "Doctor")
                        .WithMany("Protocols")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAutomation.Domain.Entities.Patient", "Patient")
                        .WithMany("Protocols")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAutomation.Domain.Entities.Policlinic", "Policlinic")
                        .WithMany("Protocols")
                        .HasForeignKey("PoliclinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Doctor", b =>
                {
                    b.Navigation("Protocols");
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Patient", b =>
                {
                    b.Navigation("Protocols");
                });

            modelBuilder.Entity("HospitalAutomation.Domain.Entities.Policlinic", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Protocols");
                });
#pragma warning restore 612, 618
        }
    }
}
