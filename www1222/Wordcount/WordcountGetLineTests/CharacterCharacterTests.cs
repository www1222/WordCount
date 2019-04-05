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
    public class CharacterCharacterTests
    {
        [TestMethod()]
        public void GetCharTest()
        {
            Character character = new Character();
            string filename = @"E:\input.txt";
            Console.WriteLine(character.GetChar(filename));
            
        }
    }
}