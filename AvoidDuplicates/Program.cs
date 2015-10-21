using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of first list");
            var l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter data for first list of student's name, phone address");

            var firstList = new List<Student>();
            for(int i = 0; i < l1; i++)
            {
                Student student = new Student();

                student.Name = Console.ReadLine();
                student.Phone = long.Parse(Console.ReadLine());
                student.Address = Console.ReadLine();

                firstList.Add(student);
            }

            Console.WriteLine("Enter length of second list");
            var l2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter data for second list of student's name, phone address");

            var secondList = new List<Student>();
            for (int i = 0; i < l2; i++)
            {
                Student student = new Student();

                student.Name = Console.ReadLine();
                student.Phone = long.Parse(Console.ReadLine());
                student.Address = Console.ReadLine();

                secondList.Add(student);
            }

            OneList result = new OneList(firstList, secondList);

            result.RemoveDuplicates();

            result.ShowResult();

            Console.ReadKey();
        }
    }
}
