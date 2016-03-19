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
            Observer_before.Newspaper newspaper = new Observer_before.Newspaper();
            Observer_before.BroadCastingStation station = new Observer_before.BroadCastingStation();
            Observer_before.BaseballScoreBoard scoreBoard1 = new Observer_before.BaseballScoreBoard(newspaper, station);

            scoreBoard1.HitHomeRun("박타자");

            Observer_after.Newspaper subA = new Observer_after.Newspaper("A");
            Observer_after.BroadCastingStation subB = new Observer_after.BroadCastingStation("B");
            Observer_after.Newspaper subC = new Observer_after.Newspaper("C");
            Observer_after.BaseballScoreBoard scoreBoard = new Observer_after.BaseballScoreBoard();
            scoreBoard.RegisterSubscriber(subA);
            scoreBoard.RegisterSubscriber(subB);
            scoreBoard.RegisterSubscriber(subC);

            scoreBoard.HitHomeRun("이홈런");
            scoreBoard.RemoveSubscriber(subC);
            scoreBoard.HitHomeRun("김안타");
        }
    }
}
