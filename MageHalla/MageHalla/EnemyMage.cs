using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    public class EnemyMage : Mage
    {
        public EnemyMage(string name, string Type) : base(name, Type) { }

        public void Introduce()
        {
            Console.WriteLine($"{this.Name}, the {this.Type} Mage!");
        }

        public override string TypeGet()
        {
            return this.Type;
        }

        public string NameGet()
        {
            return this.Name;
        }

        public override void Turn(Mage target)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4); 
            if(randomNumber == 1) 
            {
                this.Attack(target);
            }
            else
            {
                this.Defend();
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
