﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");

            string paragraph = "To be or not to be or not";
            FrequencyOfWords.GetFrequencyOfWords(paragraph);
            Console.ReadLine();
        }
    }
}



