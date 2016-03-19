using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_before
{
    public class Game
    {
        private List<Monster> _monsters = new List<Monster>();

        public Game()
        {
            _monsters.Add(new PolarBear());
            _monsters.Add(new Snowman());
            _monsters.Add(new Salamander());
            _monsters.Add(new Scorpion());
            _monsters.Add(new Bat());
            _monsters.Add(new Snake());
        }

        public void PrintMonsters()
        {
            foreach(Monster m in _monsters)
            {
                Console.WriteLine(m.GetType().Name);
            }
        }
    }

    public class Monster
    { 
    }

    public class PolarBear : Monster
    {
    }

    public class Snowman : Monster
    {
    }

    public class Salamander : Monster
    {
    }

    public class Scorpion : Monster
    {
    }

    public class Bat : Monster
    {
    }

    public class Snake : Monster
    {

    }
}
