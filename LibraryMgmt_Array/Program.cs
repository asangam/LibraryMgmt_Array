using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmt_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string StudentName,roll,faculty,Pnumber,email, /*date*/level;
            int i,Nbooks;
            string[] BookName = new string[5];
            string[] BISBN = new string[5];
            string[] Author = new string[5];
            string[] Rdate = new string[5];
            //Student Details

            //Console.Write("\n Enter today Date: ");
            //date = Console.ReadLine();
            Console.Write("\n Enter the student name: ");
            StudentName = Console.ReadLine();
            Console.Write("\n Enter the level: ");
            level = Console.ReadLine();
            Console.Write("\n Enter the Faculty: ");
            faculty = Console.ReadLine();
            Console.Write("\n Enter the Roll Number: ");
            roll = Console.ReadLine();
            Console.Write("\n Enter the student contact number: ");
            Pnumber = Console.ReadLine();
            Console.Write("\n Enter the student email address: ");
            email = Console.ReadLine();
            Console.Clear();
           label:
            Console.Write("\n Enter the number of book to be borrowed: ");
            Nbooks = Convert.ToInt32(Console.ReadLine());

            if (Nbooks <= 5)
            
                //Details of the book
                for (i = 1; i <= Nbooks; i++)
                {
                    Console.Write("\n Enter the book name: ");
                    BookName[i] = Console.ReadLine();
                    Console.Write("\n Enter the ISBN Number: ");
                    BISBN[i] = Console.ReadLine();
                    Console.Write("\n Enter the author name: ");
                    Author[i] = Console.ReadLine();
                    Console.Write("\n Enter the return date of : ");
                    Rdate[i] = Console.ReadLine();
                }


           else
            {
                Console.Write("\n Only 5 maximum books are allowed");
                Console.Write("\n Please enter the value up to 5 ");
                Console.ReadLine();
                Console.Clear();
                goto label;
            }


            Console.Clear();
            Console.Write("\t\t\t\t\t Date:{0} ",DateTime.Now.ToString("yyyy-MM-dd"));
            Console.Write("\n\n \t\t\tDetails of the Student");

            Console.Write("\n\n******************************************************");
            Console.Write("\n Name: {0} ",StudentName);
            Console.Write("\n Level: {0}",level);
            Console.Write("\n Faculty: {0}",faculty);
            Console.Write("\n Roll Number: {0}",roll);
            Console.Write("\n Phone Number: {0}",Pnumber);
            Console.Write("\n Email: {0}",email);
            Console.Write("\n******************************************************");

            Console.Write("\n \t\tDetails of the book borrowed");
                Console.Write("\n\n******************************************************");
                Console.Write("\n {0}\t\t{1}\t\t{2}\t\t{3}\t\t", "BookName", "ISBN", "Author","Return Date");

            for (i = 1; i <= Nbooks; i++)
            {

                Console.Write("\n {0}\t\t{1}\t\t{2}\t\t{3}\t\t", BookName[i],BISBN[i],Author[i],Rdate[i]);

            }





            Console.ReadLine();

            

        }
    }
}
