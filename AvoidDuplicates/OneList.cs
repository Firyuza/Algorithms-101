namespace AvoidDuplicates
{
    using System;
    using System.Collections.Generic;

    public class OneList
    {
        private IList<Student> ResultList;

        private IList<Student> FirstList;

        private IList<Student> SecondList;

        public OneList(IList<Student> first, IList<Student> second)
        {
            FirstList = first;
            SecondList = second;

            ResultList = new List<Student>();
        }

        public void RemoveDuplicates()
        {
            int i = 0;
            int j = 0;

            while(i < FirstList.Count || j < SecondList.Count)
            {
                if (ResultList.Count > 0)
                {
                    if(i < FirstList.Count)
                    {
                        Insert(FirstList, i);

                            i++;
                    }
                    
                    if(j < SecondList.Count)
                    {
                        Insert(SecondList, j);

                        j++;
                    }
                }
                else
                {
                    ResultList.Add(FirstList[i]);
                    i++;

                    Insert(SecondList, j);
                    j++;
                }

            }
        }

        public void ShowResult()
        {
            for(var i = 0; i < ResultList.Count; i++)
            {
                Console.WriteLine(ResultList[i].Name + " " + ResultList[i].Phone + " " + ResultList[i].Address);
            }
        }


        private void Insert(IList<Student> list, int i)
        {
            var left = 0;
            var right = ResultList.Count;
            var mid = right / 2 - 1;

            var isDuplicate = false;

            if ((right / 2) % 2 == 0)
            {
                mid--;
            }

            while (left < right - 1 && !isDuplicate)
            {
                if (ResultList[mid].Name.CompareTo(list[i].Name) > 0)
                {
                    right = mid;
                    mid = (left + mid) / 2;
                }
                else
                {
                    if (ResultList[mid].Name == list[i].Name && ResultList[mid].Phone == list[i].Phone)
                    {
                        isDuplicate = true;

                    }
                    else
                    {
                        left = mid;
                        mid = (mid + right) / 2;
                    }
                }
            }

            if (left - right <= 1 && !isDuplicate)
            {
                if (ResultList[left].Name.CompareTo(list[i].Name) > 0)
                {
                    if(left == 0)
                    {
                        ResultList.Insert(left, list[i]);
                    }
                    else
                    {
                        ResultList.Insert(left - 1, list[i]);
                    }
                }
                else
                {
                    if(ResultList[left].Name.CompareTo(list[i].Name) == 0) 
                    {
                        if (ResultList[left].Phone != list[i].Phone)
                        {
                            ResultList.Insert(left + 1, list[i]);
                        }
                    }
                    else
                    {
                        ResultList.Insert(left + 1, list[i]);
                    }
                }
            }
        }
    }
}
