using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a numbers range to get the prime numbers between them:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("prime numbers between "+num1+" and "+num2+":");
            while(num1 < num2)
            {
               
                int flag = 0;
                for(int i=2; i<num1; i++)
                {
                    if(num1%i==0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag==0)
                    Console.WriteLine(num1);
                num1++;
            }
            
         


            Console.ReadKey();

        }
    }
}
