using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_after
{
    public interface BasePizza
    {
        void PrintDescription();
        int GetCost();
    }

    public class ThinPizza : BasePizza
    {
        private int _cost = 7000;

        public void PrintDescription()
        {
            Console.WriteLine("가 들어간 씬피자입니다.");
        }
        
        public int GetCost()
        {
            return _cost;
        }
    }

    public class CheesecrustPizza : BasePizza
    {
        private int _cost = 10000;

        public void PrintDescription()
        {
            Console.WriteLine("가 들어간 치즈크러스트피자입니다.");
        }

        public int GetCost()
        {
            return _cost;
        }
    }

    public class Pizza : BasePizza
    {
        private int _cost = 8000;

        public void PrintDescription()
        {
            Console.WriteLine("가 들어간 피자입니다.");
        }

        public int GetCost()
        {
            return _cost;
        }
    }

    public class PizzaDecorator : BasePizza
    {
        protected BasePizza _pizza;
        public virtual void PrintDescription() { }
        public virtual int GetCost() { return 0; }
    }

    public class Potato : PizzaDecorator
    {
        private int _cost = 1000;

        public Potato(BasePizza pizza)
        {
            _pizza = pizza;
        }

        public override void PrintDescription()
        {
            Console.Write("감자 ");
            _pizza.PrintDescription();
        }

        public override int GetCost()
        {
            return _cost + _pizza.GetCost();
        }
    }

    public class Bacon : PizzaDecorator
    {
        private int _cost = 2500;

        public Bacon(BasePizza pizza)
        {
            _pizza = pizza;
        }

        public override void PrintDescription()
        {
            Console.Write("베이컨 ");
            _pizza.PrintDescription();
        }

        public override int GetCost()
        {
            return _cost + _pizza.GetCost();
        }
    }
}
