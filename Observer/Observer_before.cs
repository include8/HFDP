using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_before
{
    public class BaseballScoreBoard
    {
        private Newspaper _newspaper;
        private BroadCastingStation _broadCastingStation;

        public BaseballScoreBoard(Newspaper newspaper, BroadCastingStation broadCastingStation)
        {
            _newspaper = newspaper;
            _broadCastingStation = broadCastingStation;
        }

        public void HitHomeRun(string playerName)
        {
            _newspaper.Notify(playerName);
            _broadCastingStation.Notify(playerName);
        }
    }

    public class Newspaper
    {
        public void Notify(string name)
        {
            _WriteArticle(name);
        }

        private void _WriteArticle(string name)
        {
            Console.WriteLine(name + "선수가 홈런을 쳤습니다. - 00 신문");
        }
    }

    public class BroadCastingStation
    {
        public void Notify(string name)
        {
            _Report(name);
        }

        private void _Report(string name)
        {
            Console.WriteLine(name + "선수가 홈런을 쳤습니다! - 00 방송국");
        }
    }
}
