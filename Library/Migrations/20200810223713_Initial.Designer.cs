﻿// <auto-generated />
using System;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20200810223713_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorName");

                    b.Property<int?>("BookId");

                    b.HasKey("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookGenre");

                    b.Property<string>("BookTitle");

                    b.Property<int>("CopyCount");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library.Models.Copy", b =>
                {
                    b.Property<int>("CopyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<bool>("OnLoan");

                    b.HasKey("CopyId");

                    b.HasIndex("BookId");

                    b.ToTable("Copies");
                });

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.HasOne("Library.Models.Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("Library.Models.Copy", b =>
                {
                    b.HasOne("Library.Models.Book", "Book")
                        .WithMany("Copies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}