using Labb4_MVC_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4_MVC_Razor.Data
{
    public class LibraryDbContext : DbContext 
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            SeedData(modelBuilder);
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, Name = "Jana Johansson", Email = "janajohansson@hotmail.com", PhoneNumber = "01234567" },
                new Customer { CustomerId = 2, Name = "Erik Eriksson", Email = "erikeriksson@gmail.com", PhoneNumber = "09876543" },
                new Customer { CustomerId = 3, Name = "Alice Andersson", Email = "aliceandersson@yahoo.com", PhoneNumber = "05554433" },
                new Customer { CustomerId = 4, Name = "Karl Karlsson", Email = "karl.karlsson@mail.com", PhoneNumber = "01122334" },
                new Customer { CustomerId = 5, Name = "Anna Svensson", Email = "anna.svensson@gmail.com", PhoneNumber = "09871234" }
                );
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "Hallelujah", Author = "Peter Parks", PublicationYear = 1996 },
                new Book { BookId = 2, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublicationYear = 1925 },
                new Book { BookId = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublicationYear = 1960 },
                new Book { BookId = 4, Title = "1984", Author = "George Orwell", PublicationYear = 1949 },
                new Book { BookId = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", PublicationYear = 1951 }
                );
            modelBuilder.Entity<Loan>().HasData(
            new Loan { LoanId = 1, CustomerId = 1, BookId = 1, LoanDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 28), Returned = true },
            new Loan { LoanId = 2, CustomerId = 2, BookId = 2, LoanDate = new DateTime(2024, 04, 15), ReturnDate = new DateTime(2024, 04, 25), Returned = true },
            new Loan { LoanId = 3, CustomerId = 3, BookId = 3, LoanDate = new DateTime(2024, 04, 10), ReturnDate = new DateTime(2024, 04, 10), Returned = false },
            new Loan { LoanId = 4, CustomerId = 4, BookId = 4, LoanDate = new DateTime(2024, 04, 05), ReturnDate = new DateTime(2024, 04, 15), Returned = true },
            new Loan { LoanId = 5, CustomerId = 5, BookId = 5, LoanDate = new DateTime(2024, 04, 01), ReturnDate = new DateTime(2024, 04, 10), Returned = true }
                );
        }
    }
}
