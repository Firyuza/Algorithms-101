using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalizePath
{
    public class Path
    {
        private string GivenPath { get; set; }

        public Path(string path)
        {
            GivenPath = path;
        }

        public string NormalizePath()
        {
            var splittedStr = GivenPath.Split('\\');

            var list = new List<string>();

            for (var i = 0; i < splittedStr.Count(); i++)
            {
                if (splittedStr[i] == ".." && list.Count > 0)
                {
                    list.RemoveAt(list.Count - 1);
                }
                else
                {
                    list.Add(splittedStr[i]);
                }

            }

            var result = "";

            foreach(var item in list)
            {
                result += item + "\\";
            }

            return result;
        }

    }
}
