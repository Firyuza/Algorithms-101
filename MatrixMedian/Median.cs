namespace MatrixMedian
{
    using System.Collections.Generic;

    public class Median
    {
        public IList<int> sortedList;

        public int medianPosition;

        public int GetMedian(int rows, int columns, int[][] matrix)
        {
            sortedList = new List<int>();

            medianPosition = rows * columns / 2;
            if ((rows * columns)% 2 == 0)
            {
                medianPosition--;
            }

            for (var j = 0; j < columns; j++)
            {
                if (j == medianPosition)
                {
                    return matrix[0][j];
                }

                sortedList.Add(matrix[0][j]);
            }

            for (var i = 1; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    Insert(matrix[i][j]);
                }
            }

            return sortedList[medianPosition];
        }

        private void Insert(int value)
        {
            var left = 0;
            var right = sortedList.Count;
            var mid = right / 2 - 1;
            if ((right / 2) % 2 == 0)
            {
                mid--;
            }

            while (left < right - 1)
            {
                if (sortedList[mid] > value)
                {
                    right = mid;
                    mid = (left + mid) / 2;
                }
                else
                {
                    if (sortedList[mid] == value)
                    {
                        sortedList.Insert(mid + 1, value);
                    }
                    else
                    {
                        left = mid;
                        mid = (mid + right) / 2;
                    }
                }
            }

            if (left - right <= 1)
            {
                if (sortedList[left] > value)
                {
                    sortedList.Insert(left - 1, value);
                }
                else
                {
                    sortedList.Insert(left + 1, value);
                }
            }
        }
    }
}
