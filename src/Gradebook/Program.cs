using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gabriel\'s Gradebook");

            book.AddGrade(34);
            book.AddGrade(323);
            book.AddGrade(14);
            book.AddGrade(1324);
            book.AddGrade(4.43);
            book.AddGrade(143);
            
            var stats = book.GetStatistics();


            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
