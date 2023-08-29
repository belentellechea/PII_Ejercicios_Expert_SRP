using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        //public string LibrarySector { get ; set; } el libro no debe saber en qué sector se encuentra, tiene responsabilidades agregadas.
        //public string LibraryShelve { get ; set; } lo mismo que lo anterior pero con el estante.

        public Book(string title, string author, string code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        no cumple con el SRP ya que la clase tiene más de una responsabilidad (crea el libro y también lo va guardando en una librería)
        debemos crear nuevas clases en donde se utilice la información que dentro de esta no se necesita o está de más. 
        una clase "shelve" necesita conocer la lista de libros, así como tener un número.
        clase "sector" tiene la responsabilidad de conocer la lista de estantes y también tener un nombre.
        */

    }
}
