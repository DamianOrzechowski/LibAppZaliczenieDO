using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibApp.Models;

namespace LibApp.Interfaces
{
    public interface IBookRepository
    {
        public void AddBook(Book book);

        public void UpdateBook(Book book);

        public void DeleteBook(int id);

        public IEnumerable<Book> GetBooks();

        public Book GetBookById(int id);

        void Save();
    }
}
