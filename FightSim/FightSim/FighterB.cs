﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class FighterB
    {
        private int hp;
        public string name;
        public string PresentName()
        {
            Console.Write("Write the name of the fighter: ");
            return name = Console.ReadLine();
        }
        /*
        public int Attack()
        {

        }
        public void Hurt(int amount)
        {

        }
        public bool IsAlive()
        {

        }
        public int GetHp()
        {

        }
        */
    }
}
