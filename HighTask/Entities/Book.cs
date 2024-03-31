using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighTask.Entities
{
    internal class Book : IEntity
    { 
        public int Id { get; private set; }
        static int StaticId;
        public string Name { get; set; }
        public string AuthorName { get; set ; }
        public int PageCount { get; set ; }
        public bool IsDeleted { get; set ; }
        public Book(string name, string authorName, int pageCount)
        {
            StaticId++;
            Id = StaticId;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, AuthorName: {AuthorName},";
        }
    }
}
