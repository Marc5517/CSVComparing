using CSVComparing.Models;
using CSVComparing.FileComparing;

namespace CSVComparing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\KOM\Dokumenter\Consistency_1_0_0.csv";
            string path2 = @"C:\Users\KOM\Dokumenter\Consistency_1_0_1.csv";

            
            Comparing3.ReadCSVFile2(path1, path2);

            Comparing2.ReadCSVFile(path1, path2);

            if (Comparing1.CSVEquals(path1, path2))
            {
                Console.WriteLine("The two CSV files are the same.");
            }
            else
            {
                Console.WriteLine("The two CSV files are not the same.");
            }
        }
    }
}