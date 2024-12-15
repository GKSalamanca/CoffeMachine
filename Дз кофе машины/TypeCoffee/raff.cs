using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_кофе_машины.TypeCoffee
{
    internal class Raff : Coffee
    {
        public override void Make()
        {
            Console.WriteLine("Ваш раф-кофе");
        }
    }
}
