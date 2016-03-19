using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_before
{
    public class Programmer
    {
        public virtual void DoWork()
        {
            Console.WriteLine("내 일이 뭐에요?");
        }
    }

    public class CSharpServerProgrammer : Programmer
    {
        public override void DoWork()
        {
            Console.Write("C#으로 ");
            Console.WriteLine("서버를 만듭니다.");
        }
    }

    public class CppServerProgrammer : Programmer
    {
        public override void DoWork()
        {
            Console.Write("C++로 ");
            Console.WriteLine("서버를 만듭니다.");
        }
    }

    public class CSharpClientProgrammer : Programmer
    {
        public override void DoWork()
        {
            Console.Write("C#으로 ");
            Console.WriteLine("클라이언트를 만듭니다.");
        }
    }

    public class CppClientProgrammer : Programmer
    {
        public override void DoWork()
        {
            Console.Write("C++로 ");
            Console.WriteLine("클라이언트를 만듭니다.");
        }
    }
}
