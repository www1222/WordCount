using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Tests
{
    [TestClass()]
    public class GetLineGetLineTests
    {
        [TestMethod()]
        public void GetRowsTest()
        {
            Line Line = new Line();
            string filename = @"E:\input.txt";
            string filename2 = @"E:\input2.txt";
            string filename3 = @"E:\input3.txt";
            string filename4 = @"E:\input4.txt";
            string filename5 = @"E:\input5.txt";
            string filename6 = @"E:\input6.txt";
            string filename7 = @"E:\input7.txt";
            string filename8 = @"E:\input8.txt";
            string filename9 = @"E:\input9.txt";
            string filename10 = @"E:\input10.txt";
            Console.WriteLine(Line.GetRows(filename));
            Console.WriteLine(Line.GetRows(filename2));
            Console.WriteLine(Line.GetRows(filename3));
            Console.WriteLine(Line.GetRows(filename4));
            Console.WriteLine(Line.GetRows(filename5));
            Console.WriteLine(Line.GetRows(filename6));
            Console.WriteLine(Line.GetRows(filename7));
            Console.WriteLine(Line.GetRows(filename8));
            Console.WriteLine(Line.GetRows(filename9));
            Console.WriteLine(Line.GetRows(filename10));
        }
    }
}