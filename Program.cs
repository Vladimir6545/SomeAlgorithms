using System;
using System.Collections.Generic;

namespace SomeAlgorithms
{
    class Program
    {
        public string Test(string text)
        {
            List<int> sortList = new List<int>();

            foreach (var item in text)
            {
                sortList.Add(Convert.ToInt32(item.ToString()));
            }
            sortList.Sort();
            text = string.Join("", sortList);

            return text;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Test("9514"));
        }
    }
}
