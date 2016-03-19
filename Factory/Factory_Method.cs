using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class MonsterCreator
    {
        public List<Monster> Create()
        {
            List<Monster> monsters = new List<Monster>();
            monsters.Add(new PolarBear());
            monsters.Add(new Snowman());
            monsters.Add(new Salamander());
            monsters.Add(new Scorpion());
            monsters.Add(new Bat());
            monsters.Add(new Snake());

            return monsters;
        }
    }

    public class Game
    {
        private List<Monster> _monsters;

        public Game()
        {
            _monsters = new MonsterCreator().Create();
        }

        public void PrintMonsters()
        {
            foreach (Monster m in _monsters)
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
