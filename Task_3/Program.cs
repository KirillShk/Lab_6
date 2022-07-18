using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s1 = Console.ReadLine();
            string s2 = "";
            string result = "";
            char ch1 = '{';
            char ch2 = '}';
            int ind1 = 0;
            int ind2 = 0;
            foreach(char a in s1)
            {
                if (a == ch2)
                {
                    ind2 = s1.IndexOf(ch2)+1;
                    string x = s1.Substring(0, ind2);
                    ind1 = x.LastIndexOf(ch1);          
                }
             s1 = s1.Remove(ind1, ind2 - ind1);
            }
           //Console.WriteLine(ind1);
           //Console.WriteLine(ind2);
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}

/*if (a == ch1)
{
    ind1 = s1.IndexOf(ch1);
    ind2 = s1.IndexOf(ch2) + 1;
    s1 = s1.Remove(ind1, ind2 - ind1);
}*/
