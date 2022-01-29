using System;

namespace Gierka 
{
    public class Enemy
    {
        public string Name;
        public int Health;
        public int CurrentHealth;
        public int Damage;

        public Enemy(string name, int health, int currenthealth, int damage)
        {
            this.Name = name;
            this.Damage = damage;
            this.CurrentHealth = currenthealth;
            this.Health = health;
        }

        public string GetName() { return this.Name; }
        public int GetHealth() { return this.Health; }
        public int GetCurrentHealth() { return this.CurrentHealth; }
        public void SetCurrentHealth(int damage) { this.CurrentHealth -= damage; }
        
        Random rnd = new Random();
        public int GetAttack() { return rnd.Next(this.Damage - 10, this.Damage + 10); }
    }
}