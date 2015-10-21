namespace ShuffleArray
{
    public class Shuffle
    {
        private static int Count;

        public static void ShuffleArray(int[] a)
        {
            Count = a.Length;

            var begin = 1;
            var i = 2;
            var curCount = 1;

            var temp = a[2];
            a[2] = a[1];

            while (curCount < Count - 2)
            {
                while(i < Count && i != begin)
                {
                    Exch(ref temp, ref i, ref a);

                    curCount++;
                }

                if(curCount < Count - 2)
                {
                    i += 2;
                    begin = i;
                    temp = a[i];

                    Exch(ref temp, ref i, ref a);

                    curCount++;
                }
            }

        }

        private static void Exch(ref int temp, ref int i, ref int[] a)
        {
            if (i < Count / 2)
            {
                i *= 2;
            }
            else
            {
                i -= Count - 1 - i;
            }

            var secTemp = a[i];
            a[i] = temp;
            temp = secTemp;
        }
    }
}
