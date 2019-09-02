using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationsLibrary
{
    class Book
    {
        //attributes for book class
        private string name;
        private int id;
        private string borrowDate;
        private string returnDate;
        private bool availability;
        //constructor for book class. Takes in book name 
        //and book id as its parameters
        public Book(string name, int id)
        {
            this.name = name;
            this.id = id;
            availability = true;
        }
        //method that is called to borrow a book. Takes in
        //borrow date and return date as its parameters
        public void Borrow(string borrowDate, string returnDate)
        {
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            availability = false;
        }
        //get method returns book name
        public string GetName()
        {
            return name;
        }
        //get method returns book id
        public int GetID()
        {
            return id;
        }
        //get method returns book availability
        public bool GetAvailability()
        {
            return availability;
        }
        //get method returns date when a book should be returned
        public string GetReturnDate()
        {
            return returnDate;
        }
    }
}
