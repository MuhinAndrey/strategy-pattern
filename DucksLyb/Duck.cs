using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksLyb;
using DucksLyb.Interface;

namespace DucksLyb
{
    abstract public class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
        public string PerformFly()
        {
            return flyBehavior.Fly();
        }
        public string PerformQuack()
        {
            return quackBehavior.Quack();
        }
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public string Swim()
        {
            return "Буль-буль-буль" + " " + this.GetType();
        }
        abstract public string Display();
    }
}
