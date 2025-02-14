﻿// <auto-generated />
using CarSimulator.Models.Cars;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarSimulator.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20241019154112_CreateSteeringWheelsTable")]
    partial class CreateSteeringWheelsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarSimulator.Models.Cars.Bodies.SteeringWheel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BodyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodyId")
                        .IsUnique();

                    b.ToTable("SteeringWheel");
                });

            modelBuilder.Entity("CarSimulator.Models.Cars.Body", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("SelectedAlertType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Body");
                });

            modelBuilder.Entity("CarSimulator.Models.Cars.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Direction")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarSimulator.Models.Cars.Wheel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Wheels");
                });

            modelBuilder.Entity("CarSimulator.Models.Cars.Bodies.SteeringWheel", b =>
                {
                    b.HasOne("CarSimulator.Models.Cars.Body", "Body")
                        .WithOne("SteeringWheel")
                        .HasForeignKey("CarSimulator.Models.Cars.Bodies.SteeringWheel", "BodyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Body");
                });

            modelBuilder.Entity("CarSimulator.Models.Cars.Body", b =>
                {
                    b.HasOne("CarSimulator.Models.Cars.Car", "Car")
                        .WithOne("Body")
                        .HasForeignKey("CarSimulator.Models.Cars.Body", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarSimulator.Models.Cars.Wheel", b =>
                {
                    b.HasOne("CarSimulator.Models.Cars.Car", "Car")
                        .WithMany("Wheels")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarSimulator.Models.Cars.Body", b =>
                {
                    b.Navigation("SteeringWheel")
                        .IsRequired();
                });

            modelBuilder.Entity("CarSimulator.Models.Cars.Car", b =>
                {
                    b.Navigation("Body")
                        .IsRequired();

                    b.Navigation("Wheels");
                });
#pragma warning restore 612, 618
        }
    }
}
