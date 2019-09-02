using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationsLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and initialize record object
            Record rec = new Record();
            //add books to record
            rec.AddBook(new Book("Harry Potter",9292));
            rec.AddBook(new Book("Diary of A Wimpy Kid", 9993));
            rec.AddBook(new Book("Soccer Bosses", 9532));
            rec.AddBook(new Book("Java Tutorials", 9789));
            rec.AddBook(new Book("How to Code", 9362));
            rec.AddBook(new Book("Black Panther", 9454));
            //adds student to record
            rec.AddStudent(new Student("Alexander",201707042));
            //checks if harry potter book is available
            Console.WriteLine(rec.IsAvailable(9292));
            //borrows harry potter, Diary of A Wimpy Kid, Soccer Bosses
            //and Java Tutorials to Alexander
            rec.BorrowBook("Alexander", 201707042, 9292, "06/08/2019", "14/08/2019");
            rec.BorrowBook("Alexander", 201707042, 9993, "06/08/2019", "14/08/2019");
            rec.BorrowBook("Alexander", 201707042, 9532, "05/06/2019", "12/06/2019");
            rec.BorrowBook("Alexander", 201707042, 9789, "04/05/2019", "16/05/2019");
            //checks if harry potter is available
            Console.WriteLine(rec.IsAvailable(9292));
            //checks if black panther is available
            Console.WriteLine(rec.IsAvailable(9454));
            //checks how many books are to be returned by 14/08/2019
            Console.WriteLine(rec.TotalToBeReturnedBy("14/08/2019"));
        }
    }
}
