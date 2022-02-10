using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksLyb.Interface;

namespace DucksLyb
{
    public class RubberDuck : Duck, IQuackable
    {
        public override string Display()
        {
            return "Display" + " " + this.GetType();
        }
        public  string Quack()
        {
            return "Quack" + " " + this.GetType();
        }
    }
}
