using System;

namespace Human
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public string ShowHealth{
            get
            {
                return $"Health: {health}";
            }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }

        public int Attack(Human target)
        {
            int damage = this.Strength*5;
            target.health -= damage;
            return target.health;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human Sophie = new Human("Sophie");
            Human Noel = new Human("Noel");
            Sophie.Attack(Noel);
            Console.WriteLine(Noel.ShowHealth);
        }
    }
}
