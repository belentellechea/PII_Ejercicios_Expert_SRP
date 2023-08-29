using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public int ShelveNumber {get; set;}
        public List<Book> BookOnShelve {get;} = new List<Book>();
        
        public Shelve(int newNumber) //constructor de Shelve, sirve para otorgarle un valor a esta (en este caso, un número). 
        {
            this.ShelveNumber = newNumber;
        }

        public void AddBook(Book book) //método para agregar el libro a la lista de shelve del valor anteriormente otorgado. 
        {
            BookOnShelve.Add(book);
        }
    }
}
