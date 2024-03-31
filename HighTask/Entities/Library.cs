
using Amazon.SimpleSystemsManagement.Model;
using HighTask.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AlreadyExistsException = HighTask.Utils.Exceptions.AlreadyExistsException;
using NullReferenceException = HighTask.Utils.Exceptions.NullReferenceException;

namespace HighTask.Entities
{
    internal class Library : IEntity
    {
        public int Id { get; set; }
        public int BookLimit {  get; set; }
        List<Book> Books { get; set; }
        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if(Books.Count >=BookLimit)
                throw new CapacityLimitException("Library artiq limiti asib");
            if (Books.Any(b => b.Name == book.Name && !b.IsDeleted))
                throw new AlreadyExistsException($"{book.Name} artiq movcud deyil");
            Books.Add(book);
        }
        public Book GetBookById(int? id)
        {
            if (id is null) throw new NullReferenceException("Id null ola bilmez");
            if(Books.Any(b=> b.Id == id && !b.IsDeleted))            
                return Books.Find(b => b.Id == id && !b.IsDeleted);
            throw new NotFoundException($"{id}-li kitab movcud deyil");
        }
        public List<Book> GetAllBooks()=> Books.FindAll(b=>!b.IsDeleted);
        public void DeleteBookId(int? id)
        {
            var existBook=GetBookById(id); 
            existBook.IsDeleted = true;
            throw new NotFoundException($"{id}-Id-li kitab movcud deyil");
        }
        public void EditBookName(int? id, string name)
        {
            var existBook = GetBookById(id);
            if (Books.Any(b => b.Name == name && !b.IsDeleted))
                throw new AlreadyExistsException($"{name} artiq movcuddur");
            existBook.Name = name;
        }
        public List<Book> FilterByPageCount(int minPageCount,int maxPageCount)=>       
           Books.FindAll(b => b.PageCount > minPageCount && b.PageCount < maxPageCount&&!b.IsDeleted); 
    }
}
