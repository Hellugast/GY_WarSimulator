using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GY_WarSimulator
{
    class Game
    {
        public Soldier soldier1 { get; set; }
        public Soldier soldier2 { get; set; }
        public void createSoldier()
        {
            Console.WriteLine("Asker ismi gir");
            this.soldier1 = new Soldier(Console.ReadLine());
        }

        public void createSoldier2()
        {
            Console.WriteLine("Asker ismi gir");
            this.soldier2 = new Soldier(Console.ReadLine());
        }

        /* public void createArmyOne()
         {
             Army army = new Army();
             army.fillArmyOne();
             foreach (var item in army.ToString())
             {
                 Console.WriteLine(item);
             }

         } */



        public int fight()
        {

            while (soldier1.health > 0 && soldier2.health > 0)
            {
                soldier2.health = soldier2.health - (soldier1.weapon.Damage - soldier2.armor);
                soldier1.health = soldier1.health - (soldier2.weapon.Damage - soldier1.armor);

            }

            if (soldier1.health > 0)
            {
                Console.WriteLine($"{soldier1.soldierName} kazandı");
                return 1;
            }
            else
            {
                Console.WriteLine($"{soldier2.soldierName} kazandı");
                return 2;
            }
        }





    }
}
