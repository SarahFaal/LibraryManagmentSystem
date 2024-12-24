using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem
{
    internal class Member
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(string memberId, string name)
        {
            MemberId = memberId;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} borrowed {book.Title}");
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{Name} returned {book.Title}");
            }
            else
            {
                Console.WriteLine($"{Name} did not borrow {book.Title}");
            }
        }
    }
}
