using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    public class PlayerMage : Mage
    {
        public PlayerMage(string name, string Type) : base(name, Type) { }
        
        public void Introduce()
        {
            Console.WriteLine($"{this.Name}, the {this.Type} Mage!");
        }

        public override string TypeGet()
        {
            return this.Type;
        }

        public override void Turn(Mage enemy)
        {
            Console.WriteLine("Choose your turn:" +
                                "[1] - attack " +
                                "[2] - heal" +
                                "[3] - self destruct lmao");
            while(true)
            {
                string playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case "1":
                        this.Attack(enemy); break;

                    case "2":
                        this.Defend();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("wrong");
                        continue;
                }
                break;
            }
            
        }

        public override void Attack(Mage target)
        {
            switch (this.Type)
            {
                case "Fire":
                    FireBreath fireBreath = new FireBreath();
                    fireBreath.Cast(this, target);
                    break;
                case "Water":
                    IceSpike Ice = new IceSpike();
                    Ice.Cast(this, target);
                    break;
                case "Earth":
                    LeechSeed seed = new LeechSeed();
                    seed.Cast(this, target);
                    break;
            }
           
        }

        public override void Defend()
        {
            switch (this.Type)
            {
                case "Fire":
                    HP += 3;
                    break;
                case "Water":
                    HP += 6;
                    break;
                case "Earth":
                    HP += 12;
                    break;
            }
        }
    }
}
