using System;
using System.Collections.Generic;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string startText = "Hello, World !!!";
            string[] startTextArray = startText.Split(' ');

            foreach (var word in startTextArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}