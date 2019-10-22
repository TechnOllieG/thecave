using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textäventyr
{
    static class Var
    {
        public static int helped = 0;
        public static int hp = 20;
        public static bool key = false, crow = false;
    }
    class Program
    {
        static void Main(string[] args)
        {

            // helped function

            void helped()
            {
                switch(Var.helped)
                {
                    case 0:
                        Console.WriteLine("Sure Davos, I’ll help you!");
                        break;
                    case 1:
                        Console.WriteLine("Of course I’ll help!");
                        break;
                    case 2:
                        Console.WriteLine("You want help again Davos? Sure, I guess.");
                        break;
                    case 3:
                        Console.WriteLine("Again? Really?");
                        break;
                    case 4:
                        Console.WriteLine("We really need to have a talk about your independence Davos..");
                        break;
                    default:
                        Console.WriteLine("Please Davos, can you stop asking for help all the time?");
                        break;
                }
                Var.helped++;
            }

            // start

            start();

            void start()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You find yourself in a small dimly lit cavern. You are standing about 5 meters above the floor of the cavern on a stone shelf with the tunnel you just came from behind you.\n\nYou are a drow monk with the name Davos with rags for clothes. You are missing both of your arms since you lost them both a few days ago earlier in the cave system. Many basic tasks have become much harder to perform.\n\nYou are adventuring with 4 friends, the high-elf wizard Ravioli, the dragon-born barbarian Hirathak, the high-elf ranger Erik Richthofen and the tiefling druid Dyzmid. They are all next to you on the stone shelf.\n\nIn the cavern, north of you, there is a daise close to the center of the room with what appears to be a dead body on top of it.\n\nTo the west there is a river and west of that there is a small stone shore.\n\nWhat you focus on however is a sturdy metal door to the east of the room. This also resides on a stone shelf about 4 meters above the ground of the rest of the cavern. It is too far to jump from where you are now to the stone shelf where the door is located.\n\nHow to play: This is a text-based adventure game. You play the game by typing in simple instructions of between one and three words like walk north, get sword, pick lock etc.\nGood luck!");
                one();
            }

            // step one
            void one()
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nTo clarify, you are on the stone shelf, the first thing you need to do is to get down to the floor of the cavern");
                Console.WriteLine("\nInput Command:");
                string temp = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                if (temp == "jump" || temp=="jump down")
                {
                    Console.WriteLine("\nAfter a few moments of hesitation you jump down to the floor, but you hurt your leg in the fall. Your mobility is compromised.");
                    Var.hp -= 10;
                    two();
                }
                else if (temp == "ask for help" || temp == "get help" || temp == "help")
                {
                    Console.Write("\nRavioli: ");
                    helped();
                    Console.WriteLine("\nRavioli casts a quick spell, picks you up and slowly hover down to the floor where he sets you down.");
                    two();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid command, try again!");
                    one();
                }
            }

            // step two

            void two()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nYou find yourself on the floor of the cavern with the daise still to the north, the river to the west and the stone shelf with the metal door to the east.");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nInput Command:");
                string temp = Console.ReadLine().ToLower();

                if (temp == "walk west" || temp == "west" || temp == "walk to river" || temp == "go to river" || temp == "river")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nYou arrive at the edge of the river, it is about 2 meters wide, on the other side you spot something shiny on the floor.");
                    threeA();
                }
                else if (temp == "walk north" || temp == "north" || temp == "walk to daise" || temp == "go to daise" || temp == "daise")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nSlowly you walk up to the dead body on the daise, you notice a tool by the body, it looks to be a crowbar, slightly covered in blood.");
                    threeB();
                }
                else if (temp == "walk east" || temp == "east" || temp == "walk to door" || temp == "go to door" || temp == "door" || temp == "walk to stone shelf" || temp == "go to stone shelf" || temp == "stone shelf" || temp == "walk to shelf" || temp == "go to shelf" || temp == "shelf")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nYou approach the stone shelf where the metal door resides on. It is too far up to crawl up on.");
                    threeC();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid command, try again!");
                    two();
                }
            }

            // step three

            void threeA()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nYou can now either try to get accross the river or go back");
                Console.WriteLine("Input Command:");
                string temp = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Blue;

                if (temp == "swim" || temp == "swim across")
                {
                    if (Var.hp < 20)
                    {
                        Console.WriteLine("\nYou try kicking water fast enough to make it to the other side but your hurt leg is not quite enough to make it. Slowly you start sinking down into the water, you try kicking up but it’s useless, you will not make it up. Darkness sets around you, you breathe in. You have died");
                        failed();
                    }
                    else
                    {
                        Console.WriteLine("\nWith somewhat difficulty you manage to kick water fast enough to make it to the other shore. You manage to slither your way onto the floor and with some difficulty you make it into a standing position");
                        Console.WriteLine("\nYou search the ground and spot the shiny item again. You move closer and you can see that it is a key.");
                        fourA();
                    }
                }
                else if (temp == "jump" || temp == "jump across")
                {
                    if (Var.hp < 20)
                    {
                        Var.hp -= 5;
                        Console.WriteLine("\nYou jump over the river, but your leg gets more hurt in the landing. Every step is painful.");
                        Console.WriteLine("\nYou search the ground and spot the shiny item again. You move closer and you can see that it is a key.");
                    }
                    else
                    {
                        Console.WriteLine("\nYou manage to cleanly jump over the river.");
                        Console.WriteLine("\nYou search the ground and spot the shiny item again. You move closer and you can see that it is a key.");
                    }
                    fourA();
                }
                else if (temp == "help" || temp == "ask for help" || temp == "get help")
                {
                    Console.Write("\nHirathak: ");
                    helped();
                    Console.WriteLine("Hirathak picks you up and jumps cleanly over the river, sets you down and then jumps back");
                    Console.WriteLine("\nYou search the ground and spot the shiny item again. You move closer and you can see that it is a key.");
                    fourA();
                }
                else if (temp == "walk east" || temp == "back" || temp == "go back" || temp == "east")
                {
                    two();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid command, try again!");
                    threeA();
                }
            }
            void threeB()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nInput Command:");
                string temp = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Blue;

                if (temp == "get crowbar" || temp == "loot" && !Var.crow)
                {
                    Var.crow = true;
                    Console.WriteLine("\nYou slowly move toward the crowbar to pick it up when you realize that you still don’t have any arms. Erik notices your frustrations.\n\nErik: You want help holding onto that?\nDavos : Yeah, that would be nice thanks.\n\nErik picked up the crowbar.");
                    threeB();
                }
                else if (temp == "walk south" || temp == "back" || temp == "go back" || temp == "south")
                {
                    two();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid command, try again!");
                    threeB();
                }
            }
            void threeC()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nTo be clear: you are standing next to the stone shelf where the door resides on. You can either try to get onto the stone shelf or go back");
                Console.WriteLine("\nInput Command:");
                string temp = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Magenta;

                if (temp == "run" || temp == "run up wall" || temp == "parkour")
                {
                    if (Var.hp < 20)
                    {
                        Console.WriteLine("\nYour leg is too hurt to run up the wall fast enough.");
                        threeC();
                    }
                    else
                    {
                        Console.WriteLine("\nYou size up your target and without hesitation you quickly sprint up the wall. You have made it to the door.");
                        fourC();
                    }
                }
                else if (temp == "help" || temp == "ask for help" || temp == "get help")
                {
                    Console.Write("\nDyzmid: ");
                    helped();
                    Console.WriteLine("\nDyzmid throws you over his shoulder and steadily climb up the wall. You have made it to the door.");
                    fourC();
                }
                else if (temp == "walk west" || temp == "go back" || temp == "back" || temp == "west")
                {
                    two();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid command, try again!");
                    threeC();
                }
            }

            // step four

            void fourA()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nInput Command:");
                string temp = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Green;

                if (temp == "pick up key" || temp == "get key" && !Var.key)
                {
                    Var.key = true;
                    Console.WriteLine("\nYou hesitate for a bit. Then you kneel down and bend forward and pick up the key with your mouth. You found the key");
                    fourA();
                }
                else if (temp == "back" || temp == "go back" || temp == "jump across" || temp == "jump" || temp == "walk east" || temp == "east" || temp == "help")
                {
                    Console.WriteLine("\nYou jump across the river and manage to land mainly on the healthy leg.");
                    two();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid command, try again!");
                    fourA();
                }
            }
            void fourC()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nInput Command:");
                string temp = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                if (temp == "use key" || temp == "unlock door")
                {
                    if(Var.key)
                    {
                        Console.WriteLine("\nYou bend down and put the key still in your mouth into the lock. You turn it and open the door. On the inside is a large treasure room filled with gold coins, rubies, sapphires, emeralds, necklaces and many spell scrolls, there are also health potions and other potions in all colors and amounts.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nCongratulations! You have won!");
                        Console.ResetColor();
                        Console.WriteLine("\nPress any key to continue . . .");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nMissing items.");
                        fourC();
                    }
                }
                else if (temp == "pick lock" || temp == "help" || temp == "get help")
                {
                    if(Var.crow)
                    {
                        Console.WriteLine("\nDavos: Hey Erik! You still got that crowbar? Can you open this door?\nErik: Sure, I’ll be right there\nErik climbs onto the stone shelf and uses the crowbar on the door.As the door opens there is a magic spark from inside the room.The room appears to be completely empty except for a piece of paper that reads: Intruder alert, security system activated.\n\nYou have failed.");
                        failed();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nMissing items.");
                        fourC();
                    }
                }
                else if (temp == "back" || temp == "go back" || temp == "jump down" || temp == "jump" || temp == "walk west" || temp == "west")
                {
                    Console.WriteLine("\nYou jump down to the floor, the fall is shorter than for the first stone shelf. You make it down without any injuries");
                    two();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nInvalid command, try again!");
                    fourC();
                }
            }

            // failed function

            void failed()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                ConsoleKey response;
                Console.WriteLine("\nRetry? (Y/N)");
                response = Console.ReadKey(true).Key;

                if (response == ConsoleKey.Y) 
                {
                    Var.hp = 20;
                    Var.helped = 0;
                    Var.key = false;
                    Var.crow = false;
                    start();
                }
                else if (response == ConsoleKey.N)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid command, try again!");
                    failed();
                }
            }
        }
    }
}
