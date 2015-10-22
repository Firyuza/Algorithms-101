namespace HeightOfTree
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of vertices");

            int count = int.Parse(Console.ReadLine());

            var vertices = new int[count];

            Console.WriteLine("Enter vertices of tree with enter");

            for(var i = 0; i < count; i++)
            {
                vertices[i] = int.Parse(Console.ReadLine());
            }
            

            Tree tree = new Tree(vertices);

            var height = tree.FindHeight();


            Console.WriteLine("Height of tree " + height);

            Console.ReadKey();
        }
    }
}
