using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordcount
{
    public class Word
    {
        public int GetWords(string Filename)
        {
            FileStream path = new FileStream(Filename, FileMode.Open);
            long size = path.Length;
            byte[] array = new byte[size];
            path.Read(array, 0, array.Length);
            path.Close();
            int count = 0;
            int flag = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 32 && array[i] <= 126)
                {
                    if ((array[i] >= 97 && array[i] <= 122) || (array[i] >= 65 && array[i] <= 90))//英文字母
                    {
                        if (flag >= 0)
                            flag++;
                        if (flag < 0)
                            flag = 0;
                    }
                    else if (array[i] >= 48 && array[i] <= 57)//数字
                    {
                        if (flag >= 4)
                            flag++;
                        else
                            flag = 0;
                    }
                    else //非字母数字符号
                    {
                        if (flag >= 4)
                        {
                            count++;
                            flag = 0;
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                }
            }
            return count;
        }
    }

}
