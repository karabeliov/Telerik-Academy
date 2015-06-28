namespace Game.Entities.Human
{
    using Game.Common;
    using System;

    public class Player : Fighter
    {
        private static int health = 100;
        private static int armor = 100;
        private static int speed = 1;
        private static int damage = 10;
        private int lives = 3;
        private int score = 0;

        private static string[] faceLeft = {"",
                                            " (oO)",
                                            "<=][>", 
                                            "  /\\"  };

        private static string[] faceRight = {"",
                                             "(Oo) ",
                                             "<][=>", 
                                             " /\\ "  };

        private static string[] faceUp = {   "_|^|_",
                                             " (Oo)", 
                                             "  ][ ", 
                                             "  /\\" };

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public int Lives
        {
            get { return this.lives; }
            set { this.lives = value; }
        }
        
        public Player(Point position)
            : base(position, faceRight, speed, health, damage, armor)
        {
        }

        public override void ChangeDirection(Direction direction)
        {
            switch (this.Direction)
            {
                case Direction.Left:
                    this.Symbol = Player.faceLeft;
                    break;
                case Direction.Right:
                    this.Symbol = Player.faceRight;
                    break;
                case Direction.Up:
                    this.Symbol = Player.faceUp;
                    break;
                default:
                    break;
            }
        }

        public override void Attack(int bulletDamage)
        {
            
        }

        protected override void InitialazeOffsets()
        {
            base.InitialazeOffsets();

            foreach (var item in this.offsets)
            {
                if (item.Key != Common.Direction.Left && item.Key != Common.Direction.Right)
                {
                    item.Value.XOffset = 0;
                    item.Value.YOffset = 0;
                }
            }
        }
    }
}
