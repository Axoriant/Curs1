using curs1;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestPR

{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            string[] myArr = { "Am", "Dm", "F", "C", "G", "Em" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }
                //Console.WriteLine(result);
            }
            Assert.Pass(result);
        }


    }
}