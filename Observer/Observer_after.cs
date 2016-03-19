using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_after
{
    public class BaseballScoreBoard
    {
        private List<Subscriber> _subscribers = new List<Subscriber>();

        public void RegisterSubscriber(Subscriber sub)
        {
            _subscribers.Add(sub);
        }

        public void RemoveSubscriber(Subscriber sub)
        {
            _subscribers.Remove(sub);
        }

        public void HitHomeRun(string playerName)
        {
            foreach(Subscriber sub in _subscribers)
            {
                sub.Notify(playerName);
            }
        }
    }

    public interface Subscriber
    {
        void Notify(string playerName);
    }

    public class Newspaper : Subscriber
    {
        private string _name;

        public Newspaper(string name)
        {
            _name = name;
        }

        public void Notify(string playerName)
        {
            _WriteArticle(playerName);
        }

        private void _WriteArticle(string playerName)
        {
            Console.WriteLine(string.Format("{0}선수가 홈런을 쳤습니다. - {1} 신문", playerName, _name));
        }
    }

    public class BroadCastingStation : Subscriber
    {
        private string _name;

        public BroadCastingStation(string name)
        {
            _name = name;
        }

        public void Notify(string playerName)
        {
            _Report(playerName);
        }

        private void _Report(string playerName)
        {
            Console.WriteLine(string.Format("{0}선수가 홈런을 쳤습니다! - {1} 방송국", playerName, _name));
        }
    }
}
