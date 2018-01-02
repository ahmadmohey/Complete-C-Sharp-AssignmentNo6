using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Random rand = new Random();
            int x = 0;
            do
            {
                Console.WriteLine("Roll dice? (yes, no)");
                input = Console.ReadLine();
                if (input.ToLower() == "yes")
                {
                    x = rand.Next(1, 7);
                    Console.WriteLine("New dice no is " + x);
                }
            }
            while(input.ToLower() != "no");
        }
    }
}
