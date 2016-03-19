using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface MonsterCreator
    {
        List<Monster> Create();
    }

    public class SnowMonsterCreator : MonsterCreator
    {
        public List<Monster> Create()
        {
            List<Monster> monsters = new List<Monster>();
            monsters.Add(new PolarBear());
            monsters.Add(new Snowman());
            return monsters;
        }
    }

    public class DessertMonsterCreator : MonsterCreator
    {
        public List<Monster> Create()
        {
            List<Monster> monsters = new List<Monster>();
            monsters.Add(new Salamander());
            monsters.Add(new Scorpion());
            return monsters;
        }
    }

    public class WoodMonsterCreator : MonsterCreator
    {
        public List<Monster> Create()
        {
            List<Monster> monsters = new List<Monster>();
            monsters.Add(new Bat());
            monsters.Add(new Snake());
            return monsters;
        }
    }

    public class Game
    {
        private List<Monster> _monsters;

        public Game(MonsterCreator creator)
        {
            _monsters = creator.Create();
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
