namespace Game.Common
{
    using System;
    using Game.Interface;

    public abstract class GameObject : IDraw
    {
        public GameObject(Point position, string[] symbol)
        {
            this.Position = position;
            this.Symbol = symbol;
        }

        public Point Position { get; set; }

        public string[] Symbol { get; protected set; }

        public int Widgh 
        { 
            get 
            { 
                return this.Symbol[0].Length; 
            } 
        }

        public int Heigth 
        { 
            get 
            { 
                return this.Symbol.Length; 
            } 
        }

        public virtual void Draw()
        {
            for (int i = 0; i < this.Symbol.Length; i++)
            {
                Console.SetCursorPosition(this.Position.X, this.Position.Y + i);
                Console.Write(this.Symbol[i]);
            }
        }
    }
}
