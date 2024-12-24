using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem
{
    internal class Library
    {
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Added book: {book.Title}");
        }

        public void RegisterMember(Member member)
        {
            Members.Add(member);
            Console.WriteLine($"Registered member: {member.Name}");
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available books:");
            foreach (var book in Books)
            {
                if (book.IsAvailable)
                {
                    book.DisplayInfo();
                }
            }
        }
    }
}
