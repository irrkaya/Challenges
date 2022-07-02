using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                try
                {
                    Console.Write("Please enter a number:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter another number:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int total = num1 + num2;
                    Console.WriteLine(total);
                }
                catch (FormatException a)
                {
                    Console.WriteLine(a.Message);
                }
             
  
                Console.ReadLine();
            
           

        }
    }
}
