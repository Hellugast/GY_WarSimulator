using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GY_WarSimulator
{
    class Army
    {

        List<Soldier> army1 = new List<Soldier>();
        List<Soldier> army2 = new List<Soldier>();

        /* public Army()
         {
             army1.Add(new Soldier("Ordu1 askeri"));
             army1.Add(new Soldier("Ordu1 askeri"));
             army1.Add(new Soldier("Ordu1 askeri"));
             army1.Add(new Soldier("Ordu1 askeri"));
             army1.Add(new Soldier("Ordu1 askeri"));
             army1.Add(new Soldier("Ordu1 askeri"));
             army1.Add(new Soldier("Ordu1 askeri"));

         } */


        public Army()
        {
            Console.WriteLine("Ordularda kaç asker olsun");
            int soldierCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < soldierCount; i++)
            {
                army1.Add(new Soldier("Ordu1 askeri"));
            }

            for (int i = 0; i < soldierCount; i++)
            {
                army2.Add(new Soldier("Ordu2 askeri"));
            }

        }




        public void grandBattle()
        {
            Game game = new Game();

            int orduBirIndexi = 0;
            int orduIkiIndexi = 0;

            while (orduBirIndexi != army1.Count && orduIkiIndexi != army2.Count)
            {
                game.soldier1 = army1[orduBirIndexi];
                game.soldier2 = army2[orduIkiIndexi];
                int kazananNumara = game.fight();

                if (kazananNumara == 1)
                {
                    orduBirIndexi++;
                }

                else
                {
                    orduIkiIndexi++;
                }


            }

            if (orduBirIndexi > orduIkiIndexi)
            {
                Console.WriteLine("ORDU2 SAVASI KAZANDI");
            }
            else
                Console.WriteLine("ORDU1 SAVASI KAZANDI");

        }



        /* public List<Soldier> getArmy1() 
        {
            return army1;
        }
        */


    }
}
