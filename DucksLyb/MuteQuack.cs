using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksLyb.Interface;

namespace DucksLyb
{
    public class MuteQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "";
        }
    }
}
