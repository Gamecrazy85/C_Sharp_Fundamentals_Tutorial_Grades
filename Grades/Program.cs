using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName( ref GradeBook book)
        {
            //book = new GradeBook();
            //book.Name = "The New Gradebook";
        }

        static void IncrementNumber(ref int number)
        {
            number = 42;
        }


        static void Main(string[] args)
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName( ref g2);
            Console.WriteLine(g2.Name);

            DateTime d;
            int x1 = 10;
            IncrementNumber(ref x1);
            Console.WriteLine(x1);

            //GradeBook book = new GradeBook();
            //book.AddGrade(91f);
            //book.AddGrade(89.5f);
            //book.AddGrade(75f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);
        }
    }
}
