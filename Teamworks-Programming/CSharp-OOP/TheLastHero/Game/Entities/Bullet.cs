namespace Game.Entities
{
    // TODO BULLET
    using System;

    using Common;
    using Interface;
    public abstract class Bullet : MovableObject, IMove
    {
        private const int bullet = 10;
        private const int rocket = 20;
        public Bullet(Point position, string[] symbol, int speed, int bulletDamage = bullet, int rocketDamage = rocket)
            : base(position, symbol, speed)
        {
            BulletDamage = bulletDamage;
            RocketDamage = rocketDamage;
        }

        public static int BulletDamage { get; private set; } // or public ??
        public static int RocketDamage { get; private set; }
        protected override void InitialazeOffsets()
        {
            this.offsets.Add(Direction.Up, new Offset(0, -this.Speed));
            this.offsets.Add(Direction.Left, new Offset(-this.Speed, 0));
            this.offsets.Add(Direction.Right, new Offset(this.Speed, 0));
        }
    }
}
