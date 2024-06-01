using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageHalla
{
    public abstract class Mage
    {
        public string Name { get; }
        public string Type { get; }
        public double HP { get; protected set; }

        public event Action<Mage, Mage, int> SpellCast = delegate { };
        public Mage(string name, string type)
        {
            Name = name;
            Type = type;
            HP = 200;
        }

        public abstract void Attack(Mage target);
        public abstract void Defend();
        public abstract string TypeGet();
        public abstract void Turn(Mage target);
        public void GetDamaged(int damage, string type)
        {
            switch (this.Type)
            {
                case "Fire":
                    switch (type)
                    {
                        case "Water":
                            HP -= 2 * (double)damage;
                            break;
                        case "Earth":
                            HP -= 0.5 * (double)damage;
                            break;
                        default:
                            HP -= (double)damage;
                            break;
                    }
                    break;
                case "Water":
                    switch (type)
                    {
                        case "Earth":
                            HP -= 2 * (double)damage;
                            break;
                        case "Fire":
                            HP -= 0.5 * (double)damage;
                            break;
                        default:
                            HP -= (double)damage;
                            break;
                    }
                    break;
                case "Earth":
                    switch (type)
                    {
                        case "Fire":
                            HP -= 2 * (double)damage;
                            break;
                        case "Water":
                            HP -= 0.5 * (double)damage;
                            break;
                        default:
                            HP -= (double)damage;
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (HP < 0)
                HP = 0;
        }

        protected internal void OnSpellCast(Mage caster, Mage target, int damage)
        {
            SpellCast?.Invoke(caster, target, damage);
        }
    }
}
