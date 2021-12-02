using System;

namespace WizardNinjaSamurai
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        public int Health
        {
            get { return health; }
        }
         
        public virtual void Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
         
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
    class Wizard : Human
    {
        public override void Human(string name)
        {
            base.Human(name);
            Intelligence = 25;
            Health = 50;
        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.Health -=  dmg;
            Wizard.Health += dmg;
            return target.Health;

        }
        public void Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.Health += heal;
        }
    }
    class Ninja : Human
    {
        public override void Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 175;
            Health = 100;
        }
        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            target.Health -= dmg;
            Random rand = new Random();
            int chance = rand.Next(1,101);
            if (chance < 21)
            {
                target.Health -= 10;
            }
        }
        public void Steal(Human target)
        {
            int steal = 5;
            target.Health -= steal;
            Ninja.Human.Health += steal;
        }
    }
    class Samurai : Human
    {
        public override void Human(string name)
        {
            base.Human(name);
            Health = 200;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.Health < 50)
            {
                target.Health = 0;
            }
        }
        public void Meditate()
        {
            Samurai.Human.Health = 200;
        }
    }
}