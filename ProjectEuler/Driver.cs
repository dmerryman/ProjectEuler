using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler!");
            Problem1();
        }

        public static void Problem1()
        {
            int answer = MultiplesOf3And5.FindMultiplesOf3And5(limit: 1000);
            Console.WriteLine("The answer to problem 1 is {0}.", answer);
            Console.ReadKey();
        }
    }
}
