using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GY_WarSimulator
{
    class Weapon
    {
        public int Damage { get; set; }
        public string weaponName { get; set; }
    }

    class Knife : Weapon
    {
        public Knife()
        {
            this.weaponName = "knife";
            this.Damage = 11;
        }
    }

    class Rifle : Weapon
    {
        public Rifle()
        {
            this.weaponName = "Rifle";
            this.Damage = 15;
        }

    }

    class LMG : Weapon
    {
        public LMG()
        {
            this.weaponName = "LMG";
            this.Damage = 20;
        }
    }





}
