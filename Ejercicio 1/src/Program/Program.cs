using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Shelve shelve1 =new Shelve(7);
            shelve1.AddBook(book1);
            Sector sector1 = new Sector("A");
            sector1.AddShelve(shelve1);

            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelve shelve2 =new Shelve(3);
            shelve2.AddBook(book2);
            Sector sector2 = new Sector("B");
            sector2.AddShelve(shelve2);

            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");

        }
    }
}