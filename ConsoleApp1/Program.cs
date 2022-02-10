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

            IFlyBehavior flywithwings = new FlyWithWings();
            IFlyBehavior flynoway = new FlyNoWay();

            IQuackBehavior dquack = new DQuack();
            IQuackBehavior squeak = new Squeak();
            IQuackBehavior mutequack = new MuteQuack();

            mallardDuck.setFlyBehavior(flywithwings);
            mallardDuck.setQuackBehavior(dquack);

            redheadDuck.setFlyBehavior(flywithwings);
            redheadDuck.setQuackBehavior(dquack);

            rubberDuck.setFlyBehavior(flynoway);
            rubberDuck.setQuackBehavior(squeak);

            decoyDuck.setFlyBehavior(flynoway);
            decoyDuck.setQuackBehavior(mutequack);

            Duck[] ducks = new Duck[] { mallardDuck, redheadDuck, rubberDuck, decoyDuck };

            for ( int i = 0; i < ducks.Length; i++ )
            {
                Console.WriteLine(ducks[i].PerformQuack());
                Console.WriteLine(ducks[i].PerformFly());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
