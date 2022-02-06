using System;

namespace GY_WarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            Game game = new Game();

            game.createSoldier();
            game.createSoldier2();
            game.fight();

            Army army = new Army();

            army.grandBattle();



            Console.ReadLine();


        }







    }
}
