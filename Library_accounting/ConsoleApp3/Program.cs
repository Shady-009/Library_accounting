using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Reader reader1 = new Reader { Name = "Tom", Age = 18 };
                Reader reader2 = new Reader { Name = "Alice", Age = 22 };

                db.Readers.Add(reader1);
                db.Readers.Add(reader2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                Book book1 = new Book { Name = "WarAndPeace", PagesCount = 544 };
                Book book2 = new Book { Name = "Colobok", PagesCount = 7 };
                db.Books.Add(book1);
                db.Books.Add(book2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                Rent rent1 = new Rent { Duration = 22, Book = book1, Reader = reader2 };
                Rent rent2 = new Rent { Duration = 3, Book = book2, Reader = reader1 };

                db.BookRent.Add(rent1);
                db.BookRent.Add(rent2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");


                foreach (var rent in db.BookRent.ToList())
                {
                    Console.WriteLine($"Читатель под Id {rent.Reader.Id} взял книгу c номером" +
                        $" {rent.Book?.Id} на {rent.Duration} дня");
                }
            }
            Console.Read();
        }
        
    }
}
