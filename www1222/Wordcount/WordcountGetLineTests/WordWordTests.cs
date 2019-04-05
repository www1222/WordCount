using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordcount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordcount.Tests
{
    [TestClass()]
    public class WordWordTests
    {
        [TestMethod()]
        public void GetWordsTest()
        {
            Word word = new Word();
            string filename = @"E:\input.txt";
            Console.WriteLine(word.GetWords(filename));
        }
    }
}