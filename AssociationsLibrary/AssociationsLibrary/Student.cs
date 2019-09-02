using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationsLibrary
{
    class Student
    {
        //attributes for student class
        private string name;
        private int studentNumber;
        private Book[] books;
        private int count;
        //constructor for student classs. Takes in student
        //name and student number
        public Student(string name, int studentNumber)
        {
            this.name = name;
            this.studentNumber = studentNumber;
            books = new Book[1000];
            count = 0;
        }
        //method used to assign a book to a student. Takes in a
        //book object, borrow date and return date as its parameters.
        //Books are assigned to the array of "books"
        public void AssignBook(Book book, string borrowDate, string returnDate)
        {
            books[count] = book;
            books[count].Borrow(borrowDate, returnDate);
            count++;
        }
        //get method that returns student number
        public int GetStudentNumber()
        {
            return studentNumber;
        }
        //get method that returns student name
        public string GetStudentName()
        {
            return name;
        }
        
    }
}
