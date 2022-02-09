﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class FrequencyOfWords
    {
        public static void GetFrequencyOfWords(string paragraph)
        {
            MyMapNode<string, int> hashTable = new MyMapNode<string, int>(8);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (hashTable.Exists(word))
                {
                    hashTable.Add(word.ToLower(), hashTable.Get(word.ToLower()) + 1);
                }
                else
                {
                    hashTable.Add(word.ToLower(), 1);
                }
            }
            Console.WriteLine("Displaying after Add Operation:");
            hashTable.Display();
            string s = "or";
            hashTable.Remove(s);
            Console.WriteLine("After Removing an item {0}:", s);
            hashTable.Display();
        }
    }
}
