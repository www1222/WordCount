using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace WordCount
{
     public class Line //读取行数
    {
        public static int GetRows(string Filename)
        {
            string path = Filename;
            int lines = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.ReadLine() != null)
                {
                    lines++;
                }
            }
            return lines;
        }
    }
}