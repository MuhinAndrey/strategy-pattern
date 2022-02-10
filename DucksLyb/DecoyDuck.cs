using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksLyb
{
    public class DecoyDuck : Duck
    {
        public override string Display()
        {
            return $"{this.GetType()}{flyBehavior.GetType()}{quackBehavior.GetType()}";
        }
    }
}
