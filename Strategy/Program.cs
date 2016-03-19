using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_PPT
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy_before.CSharpServerProgrammer programmer1 = new Strategy_before.CSharpServerProgrammer();
            programmer1.DoWork();

            Strategy_after.Programmer programmer2 = 
                new Strategy_after.Programmer(new Strategy_after.ServerJob(), new Strategy_after.CSharpProgramming());
            programmer2.DoWork();
            // C++ 클라이언트로 일이 바뀜
            programmer2.SetProgrammingJob(new Strategy_after.ClientJob());
            programmer2.SetLanguage(new Strategy_after.CppProgramming());
            programmer2.DoWork();
        }
    }
}
