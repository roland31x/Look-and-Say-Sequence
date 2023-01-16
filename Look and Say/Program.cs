using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Look_and_Say
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "1";
            Console.WriteLine("Look and Say sequence generator, enter an 'n' value to display first 'n' numbers.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("0: " + s);
            for(int i = 1; i <= n; i++)
            {
                Console.Write(i + ": ");
                Console.Write(Generate(ref s));
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static string Generate(ref string s)
        {
            char[] chars = s.ToCharArray();
            StringBuilder str = new StringBuilder();
            int say = 1;
            for(int j = 0; j < chars.Length; j++)
            {
                try
                {
                    while (s[j] == s[j + 1])
                    {
                        say++;
                        j++;
                    }
                    str.Append(say);
                    str.Append(s[j]);
                    say = 1;
                }
                catch (Exception)
                {
                    str.Append(say);
                    str.Append(s[j]);
                }
            }
            s = str.ToString();
            return str.ToString();
        }
    }
}
