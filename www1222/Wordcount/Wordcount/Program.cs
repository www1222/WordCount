using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Wordcount;

namespace WordCount
{
    class Program
    {
        
        Line Line = new Line();
        static void Main(string[] args)
        {
            string filename = Console.ReadLine(); //@"E:\input.txt";
            Console.WriteLine(Line.GetRows(filename));
            Character character = new Character();
            Console.WriteLine(character.GetChar(filename));
            Word word = new Word();
            Console.WriteLine(word.GetWords(filename));
        }

    }
}
