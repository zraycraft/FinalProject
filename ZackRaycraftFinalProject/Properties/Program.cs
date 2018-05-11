using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero();
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");

            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */

            Console.WriteLine("Greetings. You have Three heros to play with, have fun!");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Which hero do you wish to command?");
                Console.WriteLine("My Hero, Flash, or Wonder Woman");
                string pickHero = Console.ReadLine().ToUpper();
                if (pickHero == "MY HERO")
                {
                    myHero.PowerLevel = 50;
                    Console.WriteLine("What do you wish to do?");
                    Console.WriteLine("Charge Power, Investigate, Fight Crime, Fly, or Climb?");
                    string toDo = Console.ReadLine().ToUpper();
                    if (toDo == "CHARGE POWER")
                    {
                        myHero.ChargePower();
                    }
                    else if (toDo == "INVESTIGATE")
                    {
                        myHero.Investigate();
                    }
                    else if (toDo == "FIGHTCRIME")
                    {
                        myHero.FightCrime("POW");
                    }
                    else if (toDo == "FLY")
                    {
                        myHero.Fly();
                    }
                    else if (toDo == "CLIMB")
                    {
                        myHero.Climb(8);
                    }
                }

                if (pickHero == "FLASH")
                {
                    myHero.PowerLevel = 100;
                    Console.WriteLine("What do you wish to do?");
                    Console.WriteLine("Charge Power, Investigate, Fight Crime, Fly, or Climb?");
                    string toDo = Console.ReadLine().ToUpper();
                    if (toDo == "CHARGE POWER")
                    {
                        myOtherHero.ChargePower();
                    }
                    else if (toDo == "INVESTIGATE")
                    {
                        myOtherHero.Investigate();
                    }
                    else if (toDo == "FIGHTCRIME")
                    {
                        myOtherHero.FightCrime("POW");
                    }
                    else if (toDo == "FLY")
                    {
                        myOtherHero.Fly();
                    }
                    else if (toDo == "CLIMB")
                    {
                        myOtherHero.Climb(50);
                    }
                }

                if (pickHero == "WONDER WOMAN")
                {
                    myHero.PowerLevel = 50;
                    Console.WriteLine("What do you wish to do?");
                    Console.WriteLine("Charge Power, Investigate, Fight Crime, Fly, or Climb?");
                    string toDo = Console.ReadLine().ToUpper();
                    if (toDo == "CHARGE POWER")
                    {
                        thirdHero.ChargePower();
                    }
                    else if (toDo == "INVESTIGATE")
                    {
                        thirdHero.Investigate();
                    }
                    else if (toDo == "FIGHTCRIME")
                    {
                        thirdHero.FightCrime("POW");
                    }
                    else if (toDo == "FLY")
                    {
                        thirdHero.Fly();
                    }
                    else if (toDo == "CLIMB")
                    {
                        thirdHero.Climb(25);
                    }
                }
            }
        }
    }
}