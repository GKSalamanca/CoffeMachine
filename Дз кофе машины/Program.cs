

namespace Дз_кофе_машины
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите кофе: 1. Американо 2. Капучино 3. Латте 4. Рафф");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var coffeNumber = (CoffeName)userInput;
            var CoffeeMachine = new Coffe_Machine();
            var americano = CoffeeMachine.MakeCoffee(coffeNumber);

           
        }
    }
}
