using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Wordcount
{
    public class Character
    {
        public int GetChar(string Filename)
        {
            FileStream path = new FileStream(Filename, FileMode.Open);
            long size = path.Length;
            byte[] array = new byte[size];
            path.Read(array, 0, array.Length);
            path.Close();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 32 && array[i] <= 126)
                    count++;
            }
            return count;
        }
    }

}
