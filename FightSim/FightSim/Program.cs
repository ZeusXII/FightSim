using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter A = new Fighter();
            FighterB B = new FighterB();


            Console.WriteLine("Fighter A: "+ A.PresentName() + " \n Fighter B: " + B.PresentName());
            Console.WriteLine("Fighter A Swings at fihgter B, dealing " +  + "dmg");
        

            Console.ReadKey();
        }
    }
}
