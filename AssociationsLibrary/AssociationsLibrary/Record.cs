using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationsLibrary
{
    class Record
    {
        //attriibutes for keeping record of books the library owns,
        //students registered in the library and books borrowed out
        //by the library.
        private Book[] books;
        private Book[] bbooks;
        private Student[] students;
        private int countB;
        private int countbb;
        private int countS;
        //constructor for the record class. All the variables are
        //initialized here
        public Record()
        {
            books = new Book[1000];
            bbooks = new Book[1000];
            students = new Student[1000];
            countB = 0;
            countbb = 0;
            countS = 0;
        }
        //method used to add books to the library record. Takes
        //in a Book object as a parameter
        public void AddBook(Book book){
            books[countB] = book;
            countB++;
        }
        //method used to add students to the library record. Takes
        //in a Student object as a parameter
        public void AddStudent(Student student)
        {
            students[countS] = student;
            countS++;
        }
        //method used to borrow a book to a student. Takes
        //in student name, student number, book id, borrow 
        //date and return date as parameters
        public void BorrowBook(string name, int stuNum, int bookId, string borrowDate, string returnDate)
        {
            for (int i = 0; i < countS; i++)
            {
                if (students[i].GetStudentName() == name && students[i].GetStudentNumber() == stuNum)
                {
                    for (int j = 0; j < countB; j++)
                    {
                        if (books[j].GetID() == bookId)
                        {
                            students[i].AssignBook(books[j],borrowDate,returnDate);
                            bbooks[countbb++] = books[j];
                            break;
                        }
                    }
                }
            }
        }
        //method used to check if a certain book is available.
        //Takes book id as parameters
        public bool IsAvailable(int id)
        {
            bool availability = true;
            for(int i=0;i< countbb; i++)
            {
                if (bbooks[i].GetID() == id)
                {
                    availability = false;
                    break;
                }
            }
            return availability;
        }
        //method used to check the number of books that need
        //to be returned by a certain date. Takes in a date
        //as parameters
        public int TotalToBeReturnedBy(String date)
        {
            int sum = 0;
            for(int i= 0; i < countbb; i++)
            {
                if(bbooks[i].GetReturnDate() == date)
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
