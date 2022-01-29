using System;

namespace Gierka
{
    public class Rand
    {
        public int RNG(int min, int max)
        {
            int range = (max - min);
            Random rng = new Random();
            return min + rng.Next() % range;
        }
    }
    
    public class Hero
    {
        public string Name;
        public string MyClass;
        private int Health;
        private int CurrentHealth;
        private int Signs;
        private int Damage;
        private int Experience;
        private int Level;

        private void Init(int health = 5,int currenthealth = 5, int signs = 5, int damage = 5, int experience = 0, int level = 0)
        {
            this.Health = health;
            this.CurrentHealth = currenthealth;
            this.Signs = signs;
            this.Damage = damage;
            this.Experience = experience;
            this.Level = level;
        }

        public int GetHealth() { return this.Health; }
        public int GetCurrentHealth() { return this.CurrentHealth; }
        public void SetCurrentHealth(int signs) { this.CurrentHealth += signs; }
        public int GetSigns() { return this.Signs; }
        public int GetDamage() { return this.Damage; }
        public void ApplyDamage(int damage) { this.CurrentHealth -= damage; }
        public int GetExperience() { return this.Experience; }
        public int GetLevel() { return this.Level; }

        public Hero(string name, string myclass)
        {
            
            this.Name = name;
            this.MyClass = myclass;
            
            switch(myclass)
            {
                case "Szkola Cechu Wilka": Init(1000,1000, 250, 300); break;
                case "Szkola Cechu Kota": Init(800, 800, 275, 250); break;
                case "Szkola Cechu Niedzwiedzia": Init(1200, 1200, 225, 325); break;
                default: Init(); break;
            }
        }

        public int QuickAttack()
        {
            Rand rand = new Rand();
            int quickattack = rand.RNG(GetDamage()-10, GetDamage()+5);
                return quickattack;
        }

        public int StrongAttack()
        {
            Rand rand = new Rand();
            int strongattack = rand.RNG(GetDamage()-25, GetDamage()+20);
                return strongattack;
        }
        
        public int Igni()
        {
            Rand rand = new Rand();
            int signs = rand.RNG(GetSigns()-10, GetSigns()+10);
                return signs;
        }

        public int Quen()
        {
            int signs = GetSigns();
                return signs;
        }

        public void ChooseSigns()
        {
            Console.WriteLine("[1] Igni");
            Console.WriteLine("[2] Quen");
        }
    }
}
