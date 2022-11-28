using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C#";
            string str2 = "C#";
            string str3 = "Programiz";

            int result;

            // compares str1 with str2
            result = String.Compare(str1, str2);//возвращаетзначение 0, так как равноstr1 str2
            Console.WriteLine(result);

            //compares str1 with str3
            result = String.Compare(str1, str3);//returns -1с момента появления str1 str3
            Console.WriteLine(result);

            //compares str3 with str1
            result = String.Compare(str3, str1);//возвращает 1с момента рождения после str 3 str1
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
