namespace Game.Entities.Alien
{
    using Game.Common;
    using Game.Entities;

    public class Enemy : Fighter
    {
        // TODO Add Diffrent Enemies
        protected static string[] alienStep = {"(O O)",
                                               "  | ",
                                               " /|\\", 
                                               "  | ",
                                               " / \\"  };

        protected static string[] alienStand = {"(O O)",
                                                "  | ",
                                                " /|\\", 
                                                "  | ",
                                                " | |"  };

        private static int health = 100;
        private static int armor = 0;
        private static int speed = 1;
        private static int damage = 10;

        public Enemy(Point position)
            : base(position, Enemy.alienStep, speed, health, damage, armor)
        {
        }

        public override void ChangeDirection(Direction direction)
        {
            this.Direction = direction;

            switch (this.Direction)
            {
                case Direction.Left:
                    this.Symbol = Enemy.alienStep;
                    break;
                case Direction.Right:
                    this.Symbol = Enemy.alienStand;
                    break;
            }
        }
    }
}