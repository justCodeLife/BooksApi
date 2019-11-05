using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksApi.Services
{
    public interface IBooksRepository
    {
        Task<IEnumerable<Entities.Book>> GetBooksAsync();
        Task<Entities.Book> GetBookAsync(Guid id);
    }
}