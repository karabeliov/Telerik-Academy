namespace Game.UI
{
    using System;
    using Entities.Human;
    using Interface;

    public class Field : IDraw
    {
        public void Draw()
        {
            this.DrowAtPosition();
        }

        public void DrowAtPosition()
        {
            Console.SetCursorPosition(0, 1);
            Console.Write("HP: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(new string('█', Player.Health / 2));
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(60, 1);
            Console.Write("Armor: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(new string('█', Player.Armor / 2));
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(130, 1);
            Console.Write("Lives: {0}", Game.GameMain.player.Lives);

            Console.SetCursorPosition(150, 1);
            Console.Write("Score: {0}", Game.GameMain.player.Score);

            Console.SetCursorPosition(0, GameMain.maxHight - 1);
            Console.Write(new string('█', GameMain.maxWidth - 1));
        }
    }
}