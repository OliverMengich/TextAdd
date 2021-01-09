using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter The Required Text");
            string text = Console.ReadLine();
            Console.WriteLine("Enter text number you want to add");
            int num = int.Parse(Console.ReadLine());
            char t = text[num];
            var x =t.ToString();
            string fin = text.Insert(0, x);
            
            Console.WriteLine(fin);
            Console.ReadKey();*/

            // Longest Word in Text
            Console.WriteLine("Enter The Required Text");
            string text = Console.ReadLine();
            var x = text.Split();
            string word = "";
            int n = 0;
            foreach (var item in x)
            {
                if(item.Length > n)
                {
                    word = item;
                    n = item.Length;
                }
                
            }
            Console.WriteLine(word + ": "+ word.Length);
            Console.ReadKey();

            
        }
    }
}
