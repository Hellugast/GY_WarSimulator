using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GY_WarSimulator
{
    class Soldier
    {
        Random random = new Random();
        public string soldierName { get; set; }
        public int health { get; set; } = 100;
        public int armor { get; set; } = 10;

        public Weapon weapon { get; set; }


        public Soldier(string name)
        {
            this.soldierName = name;
            chooseWeapon();
            Console.WriteLine(name + " " + weapon.weaponName + " silahını kuşandı");
        }


        public void chooseWeapon()
        {
            int useRandomToChooseWeapon = random.Next(1, 4);

            switch (useRandomToChooseWeapon)
            {
                case 1:
                    this.weapon = new Knife();
                    break;
                case 2:
                    this.weapon = new Rifle();
                    break;
                case 3:
                    this.weapon = new LMG();
                    break;
                default:
                    break;
            }

        }



    }
}
