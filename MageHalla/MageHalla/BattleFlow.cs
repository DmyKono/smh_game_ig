using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    internal class BattleFlow
    {
        Render_UI render_ui = null;
        public BattleFlow(PlayerMage player, EnemyMage enemy) 
        {
            render_ui = new Render_UI(enemy, player);
            Battle(player, enemy);
        }

        void Battle(PlayerMage player, EnemyMage enemy)
        {
            while (true)
            {
                render_ui.Render();
                player.Turn(enemy);
                if (enemy.HP<=0) 
                {
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"{player.Name} wins!");
                    System.Threading.Thread.Sleep(1500);
                    break;
                }
                enemy.Turn(player);
                if (player.HP <= 0)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine($"{enemy.Name} wins!");
                    System.Threading.Thread.Sleep(1500);
                    break;
                }

                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
