using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_after
{
    public interface Language
    {
        void How();
    }

    public class CSharpProgramming : Language
    {
        public void How()
        {
            Console.Write("C#로 ");
        }
    }

    public class CppProgramming : Language
    {
        public void How()
        {
            Console.Write("C++로 ");
        }
    }

    public interface ProgrammingJob
    {
        void DoWork();
    }

    public class ServerJob : ProgrammingJob
    {
        public void DoWork()
        {
            Console.WriteLine("서버를 만듭니다.");
        }
    }

    public class ClientJob : ProgrammingJob
    {
        public void DoWork()
        {
            Console.WriteLine("클라이언트를 만듭니다.");
        }
    }

    public class Programmer
    {
        private ProgrammingJob _job;
        private Language _language;

        public Programmer(ProgrammingJob job, Language language)
        {
            _job = job;
            _language = language;
        }

        public void SetProgrammingJob(ProgrammingJob job)
        {
            _job = job;
        }

        public void SetLanguage(Language language)
        {
            _language = language;
        }

        public void DoWork()
        {
            _language.How();
            _job.DoWork();
        }
    }
}
