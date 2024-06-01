using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;

namespace MageHalla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = NameChoosing();
            string Type = TypeChoosing();

            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".");
            }
            System.Threading.Thread.Sleep(2500);

            PlayerMage player = new PlayerMage(Name, Type);
            EnemyMage enemy = new EnemyMage("MR>BEEEEEEEEEEEEEEAAAAAST!!!!", randType());

            Introducing(Type, Name, player, enemy);


            while (true)
            {
                Console.WriteLine("\nReady? (y/n)");

                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    Console.WriteLine("\nFIGHT!");
                    System.Threading.Thread.Sleep(500);
                    break;
                }
                else if (input.ToLower() == "n")
                {
                    Console.WriteLine("u seriously thought yu gonna quit?");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\nFIGHT!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("wrong answer, buddy");
                    continue;
                }


            }
            BattleFlow battle = new BattleFlow(player, enemy);

        }

        static string NameChoosing()
        {
            while (true)
            {
                Console.WriteLine("Enter your name (max 5 characters): ");
                string PlayerName = Console.ReadLine();

                if (PlayerName.Length >= 6)
                {
                    Console.Clear();
                    Console.WriteLine("Too many characters!");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Your name is:{PlayerName}!");
                    return PlayerName;
                }
            }
        }
        static string TypeChoosing()
        {
            while (true)
            {
                Console.WriteLine("Choosing the class: ");
                Console.WriteLine("[1] - Water ");
                Console.WriteLine("[2] - Fire ");
                Console.WriteLine("[3] - Earth ");

                string playerType = Console.ReadLine();

                switch (playerType)
                {
                    case "1":
                        playerType = "Water";
                        Console.Clear();
                        Console.WriteLine("You have chosen " + playerType);
                        return playerType;

                    case "2":
                        playerType = "Fire";
                        Console.Clear();
                        Console.WriteLine("You have chosen " + playerType);
                        return playerType;

                    case "3":
                        playerType = "Earth";
                        Console.Clear();
                        Console.WriteLine($"You have chosen {playerType}");
                        return playerType;

                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong option!");
                        continue;
                }
            }
        }

        static string randType()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            switch (randomNumber)
            {
                case 1:
                    return "Water";

                case 2:
                    return "Fire";

                case 3:
                    return "Earth";

                default:
                    return "None";
            }
        }
        static void Introducing(string Type, string Name, PlayerMage player, EnemyMage enemy)
        {
            player.Introduce();

            System.Threading.Thread.Sleep(1500);

            Console.WriteLine("VS.");

            System.Threading.Thread.Sleep(2000);

            enemy.Introduce();
        }
    }
}
