using System;
using BooksApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Contexts
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    ID = Guid.NewGuid(),
                    Firstname = "george",
                    Lastname = "rr martin"
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    ID = Guid.NewGuid(),
                    AuthorID = Guid.NewGuid(),
                    Title = "winds of winter",
                    Description = "winter :/"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}