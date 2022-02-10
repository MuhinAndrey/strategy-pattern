using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksLyb;
using DucksLyb.Interface;

namespace Utky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();
            RubberDuck rubberDuck = new RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            Duck[] ducks = new Duck[] { mallardDuck, redheadDuck, rubberDuck, decoyDuck };

            for ( int i = 0; i < ducks.Length; i++ )
            {
                if (ducks[i] is IQuackable)
                {
                    Console.WriteLine((ducks[i] as IQuackable).Quack());
                }
                if (ducks[i] is IFlyable)
                {
                    Console.WriteLine((ducks[i] as IFlyable).Fly());
                }
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
