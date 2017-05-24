using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        private static float temp;
        static void Main(string[] args)
        {
            Console.WriteLine("UnitTest example start:");
            UnitTesting();
            Console.WriteLine("dynamic get user input example start:");
            while (true)
            {
                 Console.WriteLine(output(Console.ReadLine()));
            }
        }
        private static bool output(string str2CharPending)
        {
                char[] arr = str2CharPending.ToCharArray();
                List<char> listInput = new List<char>();
                listInput.AddRange(str2CharPending);
                for(int index=0;index<=arr.Length-1;index++)
                {
                    temp= arr[index]-'0';
                }           
            bool verification=temp < 48 ? true : false;
            return verification;
        }
        private static void UnitTesting()
        {
            List<string> unitTest = new List<string>();
            unitTest.Add("0");
            unitTest.Add("0.1");
            unitTest.Add(".1");
            unitTest.Add("+1");
            unitTest.Add("-1");
            unitTest.Add("abc");
            unitTest.Add("1 1");

            foreach (string i in unitTest)
            {
                Console.WriteLine("input:{0},output:{1}",i,output(i));
            }
        }

    }
}
