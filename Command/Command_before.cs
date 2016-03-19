using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_before
{
    public class Controller
    {
        private Charactor _player;

        public Controller(Charactor player)
        {
            _player = player;
        }

        public void PressRightButton()
        {
            _player.GoToRight();
        }

        public void PressLeftButton()
        {
            _player.GoToLeft();
        }

        public void PressJumpButton()
        {
            _player.Jump();
        }
    }

    public class Charactor
    {
        public void GoToRight()
        {
            Console.WriteLine("오른쪽으로 이동");
        }

        public void GoToLeft()
        {
            Console.WriteLine("왼쪽으로 이동");
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
}
