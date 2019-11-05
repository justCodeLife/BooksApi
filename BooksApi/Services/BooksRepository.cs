using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BooksApi.Contexts;
using BooksApi.Entities;

namespace BooksApi.Services
{
    public class BooksRepository : IBooksRepository,IDisposable
    {
        private BooksContext _context;

        public BooksRepository(BooksContext booksContext)
        {
            _context = booksContext ?? throw new ArgumentNullException(nameof(booksContext));
        }

        public Task<IEnumerable<Book>> GetBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}