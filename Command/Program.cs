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
            Command_before.Charactor player1 = new Command_before.Charactor();
            Command_before.Controller controller1 = new Command_before.Controller(player1);

            controller1.PressLeftButton();

            Command_after.Charactor player2 = new Command_after.Charactor();
            Command_after.Controller controller2 = new Command_after.Controller(player2);

            controller2.PressRightButton();
            controller2.PressJumpButton();
            controller2.PressRightButton();

            controller2.Undo();
        }
    }
}
