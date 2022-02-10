using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksLyb.Interface;

namespace DucksLyb
{
    public class RedheadDuck : Duck
    {
        public override string Display()
        {
            return $"{this.GetType()}{flyBehavior.GetType()}{quackBehavior.GetType()}";
        }
    }
}
