using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w09
{

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
    public class BookCollection:IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Remove(Book book)
        {
            books.Remove(book);
        }

        public Book Get(int index)
        {
           return books[index];
        }
       //....


       public IEnumerator<Book> GetEnumerator()
       {
           foreach (var book in this.books)
           {
               yield return book;
           }
       }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
    }


    class Test:IEnumerator<Book>
    {
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public Book Current { get; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }


}
