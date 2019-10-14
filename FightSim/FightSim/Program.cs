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
            Fighter B = new Fighter();

            A.GetHp(100);

            List<Fighter> fighterHp = new List<Fighter>();
            fighterHp.Add();

            Console.WriteLine("Fighter A: "+ A.PresentName() + " \n Fighter B: " + B.PresentName());
            Console.WriteLine("Fighter A swing at fighter B dealing" + A.Attack() + "dmg");
            
            B.Hurt(25);
            B.IsAlive();
            B.GetHp();

            Console.ReadKey();
        }
    }
}
