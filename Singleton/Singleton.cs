using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_PPT
{
    public class Singleton
    {
        private static volatile Singleton _instance = null;
        private static object _lockObject = new object();
        public static Singleton Instance
        {
            get
            {
                if (null == _instance)
                {
                    lock (_lockObject)
                    {
                        _instance = new Singleton();
                    }
                }

                return _instance;
            }
        }
        private Singleton() { }

        public void Print()
        {
            Console.WriteLine("싱글톤 패턴입니다");
        }
    }
}
