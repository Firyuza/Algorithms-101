namespace HeightOfTree
{
    using System.Collections.Generic;

    public class Tree
    {
        private IList<int> Levels { get; set; }

        private int Height { get; set; }

        private int[] Vertices { get; set; }

        private int Count { get; set; }


        public Tree(int[] vertices)
        {
            Count = vertices.Length;

            Vertices = new int[Count];

            Levels = new List<int>();

            Height = 0;

            for (var i = 0; i < vertices.Length; i++)
            {
                Vertices[i] = vertices[i];    
            }
        }

        public int FindHeight()
        {
            for(var i = 0; i < Count; i++)
            {
                if (Vertices[i] != -1)
                {
                    var j = Vertices[i];

                    var curHeight = 0;

                    while (j != -1)
                    {
                        j = Vertices[j];
                        curHeight++;
                    }
                    curHeight++;

                    if (curHeight > Height)
                    {
                        Height = curHeight;
                    }
                }
            }

            return Height;
        }
    }
}
