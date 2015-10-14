namespace Exam
{
    using System;

    public class Exam
    {
        public void SitDownStudents(int count)
        {
            switch(count)
            {
                case 0:
                    Console.WriteLine("Nobody to sit down");
                    break;
                case 1:
                    Console.WriteLine(1);
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(1);
                    Console.WriteLine(1);
                    break;
                case 3:
                    Console.WriteLine(1);
                    Console.WriteLine(1 + " " + 3);
                    break;
                default:
                    Console.WriteLine(count);

                    for(var i = 1; i < count; i += 2)
                    {
                        Console.Write(i + " ");
                    }

                    for(var i = 0; i < count; i += 2)
                    {
                        Console.Write(i + " ");
                    }
                    break;

            }
        }
    }
}
