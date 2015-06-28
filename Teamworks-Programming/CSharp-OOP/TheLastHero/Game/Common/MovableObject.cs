namespace Game.Common
{
    using System;
    using Game.Interface;
    using System.Collections;
    using System.Collections.Generic;

    public abstract class MovableObject : GameObject, IMove
    {
        protected Dictionary<Direction, Offset> offsets;

        private int speed;

        public MovableObject(Point position, string[] symbol, int speed)
            : base(position, symbol)
        {
            this.speed = speed;
            this.offsets = new Dictionary<Direction, Offset>();
            this.Direction = Common.Direction.Stady;
            this.InitialazeOffsets();
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
        }

        public Direction Direction { get; set; }

        public void Move()
        {
        }

        public abstract void ChangeDirection(Direction direction);

        protected virtual void InitialazeOffsets()
        {
            this.offsets.Add(Direction.Stady, new Offset(0, 0));
            this.offsets.Add(Direction.Up, new Offset(0, -this.Speed));
            this.offsets.Add(Direction.Down, new Offset(0, +this.Speed));
            this.offsets.Add(Direction.Left, new Offset(-this.Speed, 0));
            this.offsets.Add(Direction.Right, new Offset(this.Speed, 0));
            this.offsets.Add(Direction.UpLeft, new Offset(-this.Speed, -this.Speed));
            this.offsets.Add(Direction.UpRight, new Offset(this.Speed, -this.Speed));
            this.offsets.Add(Direction.DownLeft, new Offset(-this.Speed, this.Speed));
            this.offsets.Add(Direction.DownRight, new Offset(this.Speed, this.Speed));
        }
    }
}
