using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_after;

namespace DesignPattern_PPT
{
    class Program
    {
        static void Main(string[] args)
        {
            Decorator_after.BasePizza baconPotatoPizza = new Decorator_after.Pizza();
            baconPotatoPizza = new Decorator_after.PizzaWithPotato(baconPotatoPizza);
            baconPotatoPizza = new Decorator_after.PizzaWithBacon(baconPotatoPizza);

            baconPotatoPizza.PrintDescription();
            Console.WriteLine("피자의 가격은 " + baconPotatoPizza.GetCost() + "원입니다.");
        }
    }
}
