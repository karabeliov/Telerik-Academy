namespace Game.Entities.Alien
{
    using Game.Common;
    using System;

    public class FlyEnemy : Fighter
    {
        private static int health = 100;
        private static int armor = 100;
        private static int speed = 5;
        private static int damage = 10;

        protected static string[] flyAlien = {"     (OO)",
                                              " ___|/||\\|___",
                                              "|████████████|",
                                              " \\██████████/" };

        public FlyEnemy(Point position)
            : base(position, FlyEnemy.flyAlien, speed, health, damage, armor)
        {
        }

        public override void ChangeDirection(Direction direction)
        {
            this.Direction = direction;

            switch (this.Direction)
            {
                case Direction.UpLeft:
                    this.Symbol = FlyEnemy.flyAlien;
                    break;
                case Direction.UpRight:
                    this.Symbol = FlyEnemy.flyAlien;
                    break;
            }
        }
    }
}
