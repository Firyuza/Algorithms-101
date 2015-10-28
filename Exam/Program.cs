namespace Exam
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students");

            var count = int.Parse(Console.ReadLine());

            Console.WriteLine("Result:");

            Exam exam = new Exam();
            exam.SitDownStudents(count);

            Console.ReadKey();
        }
    }
}
