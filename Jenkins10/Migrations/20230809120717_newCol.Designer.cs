﻿// <auto-generated />
using System;
using Jenkins10.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jenkins10.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20230809120717_newCol")]
    partial class newCol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Jenkins10.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("Course", (string)null);

                    b.HasData(
                        new
                        {
                            CourseID = 1050,
                            Credits = 3,
                            Description = "Test1",
                            Title = "Chemistry"
                        },
                        new
                        {
                            CourseID = 4022,
                            Credits = 3,
                            Description = "Test2",
                            Title = "Microeconomics"
                        },
                        new
                        {
                            CourseID = 4041,
                            Credits = 3,
                            Description = "Test3",
                            Title = "Macroeconomics"
                        },
                        new
                        {
                            CourseID = 1045,
                            Credits = 4,
                            Description = "Test4",
                            Title = "Calculus"
                        },
                        new
                        {
                            CourseID = 3141,
                            Credits = 4,
                            Description = "Test5",
                            Title = "Trigonometry"
                        },
                        new
                        {
                            CourseID = 2021,
                            Credits = 3,
                            Description = "Test6",
                            Title = "Composition"
                        },
                        new
                        {
                            CourseID = 2042,
                            Credits = 4,
                            Description = "Test7",
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("Jenkins10.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentID"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment", (string)null);
                });

            modelBuilder.Entity("Jenkins10.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("Jenkins10.Models.Enrollment", b =>
                {
                    b.HasOne("Jenkins10.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jenkins10.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Jenkins10.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Jenkins10.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
