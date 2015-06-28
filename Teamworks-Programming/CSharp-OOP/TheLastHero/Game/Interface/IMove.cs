namespace Game.Interface
{
    using System;
    using Game.Common;

    public interface IMove
    {
        int Speed { get; }

        Direction Direction { get; set; }

        void Move();
    }
}
