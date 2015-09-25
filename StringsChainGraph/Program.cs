/*
google interview:

you are given n-strings; you have to find whether a chain can be termed with all the strings given number n? A chain can be formed b/w strings if last char of the 1st string matches with 1st char of second string. For example you are given

number of strings = 3

first string=sdfg

second string=dfgs

third string=ghjhk

they can be concatenated as ->

second first third

dfgs sdfg ghjhk (characters at concatenation points are same)

so concatenated string is-dfgsdfghjhk
*/
namespace StringsChainGraph
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of strings");

            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter strings with enter");

            string[] strings = new string[count];

            for(var i = 0; i < count; i++)
            {
                strings[i] = Console.ReadLine();
            }


            StringsChain chain = new StringsChain(strings);

            var result = chain.FindStringChain();


            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
