using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_after
{
    public interface Command
    {
        void Execute();
        void Undo();
    }

    public class JumpCommand : Command
    {
        private Charactor _charactor;

        public JumpCommand(Charactor charater)
        {
            _charactor = charater;
        }

        public void Execute()
        {
            _charactor.Jump();
        }

        public void Undo()
        {
            _charactor.Jump();
        }
    }

    public class GoToRightCommand : Command
    {
        private Charactor _charactor;

        public GoToRightCommand(Charactor charater)
        {
            _charactor = charater;
        }

        public void Execute()
        {
            _charactor.GoToRight();
        }

        public void Undo()
        {
            _charactor.GoToLeft();
        }
    }

    public class GoToLeftCommand : Command
    {
        private Charactor _charactor;

        public GoToLeftCommand(Charactor charater)
        {
            _charactor = charater;
        }

        public void Execute()
        {
            _charactor.GoToLeft();
        }

        public void Undo()
        {
            _charactor.GoToRight();
        }
    }

    public class Controller
    {
        private Command _goToRight;
        private Command _goToLeft;
        private Command _jump;
        private Stack<Command> _playLog = new Stack<Command>();

        public Controller(Charactor charactor)
        {
            _goToLeft = new GoToLeftCommand(charactor);
            _goToRight = new GoToRightCommand(charactor);
            _jump = new JumpCommand(charactor);
        }

        public void PressRightButton()
        {
            _playLog.Push(_goToRight);
            _goToRight.Execute();
        }

        public void PressLeftButton()
        {
            _playLog.Push(_goToLeft);
            _goToLeft.Execute();
        }

        public void PressJumpButton()
        {
            _playLog.Push(_jump);
            _jump.Execute();
        }

        public void Undo()
        {
            if (_playLog.Peek() == null)
                return;

            Command prevAction = _playLog.Pop();
            prevAction.Undo();
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
