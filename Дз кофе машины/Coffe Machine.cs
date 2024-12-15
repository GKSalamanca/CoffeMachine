using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Дз_кофе_машины.TypeCoffee;

namespace Дз_кофе_машины
{
    public class Coffe_Machine
    {
        public Coffee MakeCoffee(CoffeName coffeNumber)
        {
            Coffee coffee = null;
            switch (coffeNumber)
            {
                case CoffeName.Americano:
                    coffee = new Americano();
                    coffee.Make();
                    break;
                case CoffeName.Capuchino:
                    coffee = new Capuchino();
                    coffee.Make();
                    break;
                case CoffeName.Latte:
                    coffee = new Latte();
                    coffee.Make();
                    break;
                case CoffeName.Raff:
                    coffee = new Raff();
                    coffee.Make();
                    break;
            }
            return coffee;
        }
    }
}

