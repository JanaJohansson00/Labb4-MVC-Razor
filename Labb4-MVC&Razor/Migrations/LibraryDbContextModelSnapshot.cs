﻿// <auto-generated />
using System;
using Labb4_MVC_Razor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb4_MVC_Razor.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb4_MVC_Razor.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Peter Parks",
                            PublicationYear = 1996,
                            Title = "Hallelujah"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "F. Scott Fitzgerald",
                            PublicationYear = 1925,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Harper Lee",
                            PublicationYear = 1960,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "George Orwell",
                            PublicationYear = 1949,
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "J.D. Salinger",
                            PublicationYear = 1951,
                            Title = "The Catcher in the Rye"
                        });
                });

            modelBuilder.Entity("Labb4_MVC_Razor.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "janajohansson@hotmail.com",
                            Name = "Jana Johansson",
                            PhoneNumber = "01234567"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "erikeriksson@gmail.com",
                            Name = "Erik Eriksson",
                            PhoneNumber = "09876543"
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "aliceandersson@yahoo.com",
                            Name = "Alice Andersson",
                            PhoneNumber = "05554433"
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "karl.karlsson@mail.com",
                            Name = "Karl Karlsson",
                            PhoneNumber = "01122334"
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "anna.svensson@gmail.com",
                            Name = "Anna Svensson",
                            PhoneNumber = "09871234"
                        });
                });

            modelBuilder.Entity("Labb4_MVC_Razor.Models.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.HasKey("LoanId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            LoanId = 1,
                            BookId = 1,
                            CustomerId = 1,
                            LoanDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = true
                        },
                        new
                        {
                            LoanId = 2,
                            BookId = 2,
                            CustomerId = 2,
                            LoanDate = new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = true
                        },
                        new
                        {
                            LoanId = 3,
                            BookId = 3,
                            CustomerId = 3,
                            LoanDate = new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = false
                        },
                        new
                        {
                            LoanId = 4,
                            BookId = 4,
                            CustomerId = 4,
                            LoanDate = new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = true
                        },
                        new
                        {
                            LoanId = 5,
                            BookId = 5,
                            CustomerId = 5,
                            LoanDate = new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Returned = true
                        });
                });

            modelBuilder.Entity("Labb4_MVC_Razor.Models.Loan", b =>
                {
                    b.HasOne("Labb4_MVC_Razor.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb4_MVC_Razor.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
