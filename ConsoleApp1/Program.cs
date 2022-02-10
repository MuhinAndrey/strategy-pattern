using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksLyb;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();

            Duck[] ducks = new Duck[] { mallardDuck, redheadDuck };

            for ( int i = 0; i < ducks.Length; i++ )
            {
                Console.WriteLine(ducks[i].Quack());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
