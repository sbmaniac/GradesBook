using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GradeBook book = new GradeBook();

            book.NameChanged += OnNamechanged;
           
            book.Name = "Maurycy's Grade Book";

            book.Name = null;
            book.Name = "Szczepan's Grade Book";


            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
      }

        static void OnNamechanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }
        
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": "+ result);
        }
    }
}
