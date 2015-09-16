namespace StringsChainGraph
{
    using System.Collections.Generic;
    using System.Linq;

    public class StringsChain
    {
        private IList<CharDirection> CharsList { get; set; }

        private int Count { get; set; }
        
        private string[] Strings { get; set; }


        public StringsChain(string[] strings)
        {
            Count = strings.Length;

            Strings = new string[Count];

            for (var i = 0; i < strings.Length; i++)
            {
                Strings[i] = strings[i];
            }

            DoCharMap(strings);
        }

        public string FindStringChain()
        {
            var chain = new List<int>();

            int i = 0;
            int begin = 0;

            chain.Add(CharsList[i].Number);

            while (i < Count && chain.Count != Count)
            {
                var result = CharsList.Where(x => x.First == CharsList[i].Last && x.Number != CharsList[i].Number).FirstOrDefault();

                if (result == null)
                {
                    begin++;
                    i = begin;

                    chain.Clear();
                }
                else
                {
                    i = CharsList.IndexOf(result);
                }

                if(i < Count)
                {
                    chain.Add(CharsList[i].Number);
                }
            }

            if(chain.Count == Count)
            {
                var stringsChain = Strings[chain[0]];
                for(i = 1; i < chain.Count; i++)
                {
                    stringsChain += Strings[chain[i]].Remove(0, 1);
                }

                return stringsChain;
            }
            else
            {
                return "Strings chain is impossible! \n";
            }
        }

        private void DoCharMap(string[] strings)
        {
            CharsList = new List<CharDirection>();

            for (var i = 0; i < strings.Length; i++)
            {
                var charDirection = new CharDirection
                {
                    First = strings[i][0],
                    Last = strings[i][strings[i].Length - 1],
                    Number = i
                };

                CharsList.Add(charDirection);
            }
        }
    }
}
