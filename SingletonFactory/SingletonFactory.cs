using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactory
{
    public abstract class Singleton<T> where T : new()
    {
        private static T _instance = default(T);
        private static object _lockObject = new object();
        public static T Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (null == _instance)
                    {
                        _instance = new T();
                    }
                }

                return _instance;
            }
        }
    }

    public class MonsterCreator : Singleton<MonsterCreator>
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
            _monsters = MonsterCreator.Instance.Create();
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
