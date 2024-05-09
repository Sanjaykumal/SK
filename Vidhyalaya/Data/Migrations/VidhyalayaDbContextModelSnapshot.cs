﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Vidhyalaya.Data.Migrations
{
    [DbContext(typeof(VidhyalayaDbContext))]
    partial class VidhyalayaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Grade", b =>
                {
                    b.Property<int>("Label")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassTeacher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Medium")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SessionYear")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subjects")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Label");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("TEXT");

                    b.Property<int>("GradeLabel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Guardian_contact")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Guardian_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("sex")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GradeLabel");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.HasOne("Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeLabel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Grade", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
