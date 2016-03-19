﻿using System;
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
            Abstract_Factory.Game game = new Abstract_Factory.Game(new Abstract_Factory.WoodMonsterCreator());
            game.PrintMonsters();
        }
    }
}
