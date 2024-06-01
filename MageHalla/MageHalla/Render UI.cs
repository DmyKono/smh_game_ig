using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    internal class Render_UI
    {
        EnemyMage enemy;
        PlayerMage player;
        const int MaxHP = 200;

        public Render_UI(EnemyMage mage, PlayerMage player)
        {
            this.enemy = mage;
            this.player = player;
        }

        public void Render()
        {
            Console.Clear();
            Console.Write("Enemy ");
            HPBar(enemy);
            ShowEnemy();
            Console.Write("Your ");
            HPBar(player);
        }

        public void ShowEnemy()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine($"{enemy.NameGet()} ({enemy.TypeGet()})");
            TypeChange(enemy.TypeGet());
            Console.WriteLine("===============================================");
            ColorReset();
            Console.WriteLine("                      __,,,,_\r\n       _ __..-;''`--/'/ /.',-`-.\r\n   (`/' ` |  \\ \\ \\\\ / / / / .-'/`,_\r\n  /'`\\ \\   |  \\ | \\| // // / -.,/_,'-,\r\n /<7' ;  \\ \\  | ; ||/ /| | \\/    |`-/,/-.,_,/')\r\n/  _.-, `,-\\,__|  _-| / \\ \\/|_/  |    '-/.;.\\'\r\n`-`  f/ ;      / __/ \\__ `/ |__/ |\r\n     `-'      |  -| =|\\_  \\  |-' |\r\n           __/   /_..-' `  ),'  //\r\n       fL ((__.-'((___..-'' \\__.'");

            TypeChange(enemy.TypeGet());
            Console.WriteLine("===============================================");
            ColorReset();
        }
        void TypeChange(string type)
        {

            switch (type)
            {
                case "Fire":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "Water":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "Earth":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }

        }
        void ColorReset()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        void HPBar(Mage mage)
        {
            Console.WriteLine("HP: " + mage.HP + "/" + MaxHP);
            int barLength = 20;
            double percentage = (double)mage.HP / MaxHP;
            int numChars = (int)(percentage * barLength);

            Console.Write("[");
            for (int i = 0; i < barLength; i++)
            {
                if (i < numChars)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("#");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("-");
                }

            }
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("]");
        }
    }
}
