namespace Game
{
    //TODO GameEngine: this should move enemies and player and bullets
    using System;
    using Entities;
    using Entities.Human;
    using Game.Common;
    using Game.Entities.Alien;

    public class GameEngine
    {
        // Lockal boolean variables to control the flyEnemy behavior
        private static bool isLeftSideReached = true;
        private static bool isRightSideReached = false;
        private static bool isGoingDown = false;
        private static bool isGoingUp = false;

        public static bool hasSpawnedEnemy = false;
        public static bool enemyIsDead = true;
        public static Enemy enemy;
        // public static FlyEnemy flyEnemy; The logic of fly enemy will be the same, but the spawn is when the game starts

        public static void Move()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (GameMain.player.Position.X - 1 > 0)
                    {
                        GameMain.player.Direction = Direction.Left;
                        GameMain.player.Position.X--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (GameMain.player.Position.X + 1 < Console.WindowWidth - 4)
                    {
                        GameMain.player.Direction = Direction.Right;
                        GameMain.player.Position.X++;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.F)
                {
                    // TODO: Normal fire
                    GameMain.player.Attack(Bullet.BulletDamage);
                }
                else if (pressedKey.Key == ConsoleKey.G)
                {
                    // TODO: Rocket fire
                    GameMain.player.Attack(Bullet.RocketDamage);
                }
            }
        }

        public static void MoveEnemies()
        {
            MoveFlyEnemy();
            if (hasSpawnedEnemy) // If the flyEnemy reach the floor, hasSpawnEnemy = true and then we create our ground enemy
            {
                if (enemyIsDead) // If the ground enemy is alive the flyEnemy can't spawn another ground enemy
                {
                    SpawnGroundEnemy(); 
                    enemyIsDead = false;
                }

                MoveGroundEnemy();
            }
        }

        private static void SpawnGroundEnemy()
        {
            enemy = new Enemy(new Point(GameMain.flyEnemy.Position.X, GameMain.maxHight - 6)); // The X coordinate will be the same as flyEnemy.Position.X, the Y coordinate can be constant GameMain.maxHight - 6
        }

        private static void MoveFlyEnemy()
        {

            Random randomGenerator = new Random();

            if (isLeftSideReached && GameMain.flyEnemy.Position.X < GameMain.maxWidth - 10)
            {
                GameMain.flyEnemy.Position.X++;
                if (GameMain.flyEnemy.Position.X == GameMain.maxWidth - 12)
                {
                    isRightSideReached = true;
                    isLeftSideReached = false;
                }
            }

            if (isRightSideReached && GameMain.flyEnemy.Position.X > 0)
            {
                GameMain.flyEnemy.Position.X--;
                if (GameMain.flyEnemy.Position.X == 0)
                {
                    isRightSideReached = false;
                    isLeftSideReached = true;
                }
            }

            if ((randomGenerator.Next(100) < 2)) // 2% chans to go down and to drop an enemy
            {
                isGoingDown = true;
            }

            if (isGoingDown || isGoingUp)
            {
                // The droping algoritm. I make all the boolean variables false, exept isDroppingDown. Then until the flyEnemy reach the floor I subtract his Y cordinate
                if (isGoingDown && GameMain.flyEnemy.Position.Y < GameMain.maxHight - 2)
                {
                    isRightSideReached = false;
                    isLeftSideReached = false;

                    if (GameMain.flyEnemy.Position.Y == GameMain.maxHight - 6) // Check is the flyEnemy has reached the floor
                    {
                        hasSpawnedEnemy = true;
                        isGoingUp = true;
                        isGoingDown = false;
                    }

                    GameMain.flyEnemy.Position.Y++;
                }
                else if (GameMain.flyEnemy.Position.Y >= GameMain.maxHight / 2)
                {
                    isRightSideReached = false;
                    isLeftSideReached = false;

                    if (GameMain.flyEnemy.Position.Y == GameMain.maxHight / 2)
                    {
                        isGoingUp = false;
                        if (randomGenerator.Next(100) > 50)
                        {
                            isLeftSideReached = true;
                        }
                        else
                        {
                            isRightSideReached = true;
                        }
                    }

                    GameMain.flyEnemy.Position.Y--;
                }
            }
        }

        private static void MoveGroundEnemy()
        {
            if (enemy.Position.X > GameMain.player.Position.X)
            {
                enemy.Position.X--;
            }
            else if (enemy.Position.X < GameMain.player.Position.X)
            {
                enemy.Position.X++;
            }
        }
    }
}