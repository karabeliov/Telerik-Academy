namespace Game.Common
{
    using System;
    using Entities;

    public abstract class Fighter : MovableObject
    {
        private Point startBullPosition = new Point();
        public Fighter(Point position, string[] symbol, int speed, int health, int damage, int armor = 0)
            : base(position, symbol, speed)
        {
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public static int Health { get; set; }

        public static int Armor { get; set; }

        public static int Damage { get; set; }

        public virtual void Attack()
        {
            
        }
    }
}