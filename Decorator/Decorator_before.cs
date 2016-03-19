using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_before
{
    public interface Pizza
    {
        void PrintDescription();
        int GetCost();
    }

    public class CheesePizza : Pizza
    {
        private int _cost = 10000;

        public void PrintDescription()
        {
            Console.WriteLine("치즈가 들어간 피자입니다.");
        }

        public int GetCost()
        {
            return _cost;
        }
    }

    public class PotatoPizza : Pizza
    {
        private int _cost = 13000;

        public void PrintDescription()
        {
            Console.WriteLine("감자가 들어간 피자입니다.");
        }

        public int GetCost()
        {
            return _cost;
        }
    }

    public class PotatoPizzaWithCheesecrust : Pizza
    {
        private int _cost = 15000;

        public void PrintDescription()
        {
            Console.WriteLine("감자가 들어간 치즈 크러스트 피자입니다.");
        }

        public int GetCost()
        {
            return _cost;
        }
    }
}
