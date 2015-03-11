using System;

class Eggcelent
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int dots = number + 1;
        int topDown = number - 1;
        int side = number;
        int dotsIn = topDown;

        if (number == 2)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', topDown));
            Console.Write(new string('.', dots));
            Console.WriteLine();

            dots -= 2;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', topDown));
            Console.Write(new string('@', dots));
            Console.Write(new string('.', dots));
            Console.Write(new string('@', dots));
            Console.Write(new string('*', topDown));
            Console.Write(new string('.', dots));
            Console.WriteLine();
            Console.Write(new string('.', dots));
            Console.Write(new string('*', topDown));
            Console.Write(new string('.', dots));
            Console.Write(new string('@', dots));
            Console.Write(new string('.', dots));
            Console.Write(new string('*', topDown));
            Console.Write(new string('.', dots));
            Console.WriteLine();
            dots += 2;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', topDown));
            Console.Write(new string('.', dots));
            Console.WriteLine();
        }
        else
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', topDown));
            Console.Write(new string('.', dots));
            Console.WriteLine();
            dots -= 2;
            dotsIn += 2;

            for (int height = 0; height < number / 2; height++)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('.', dotsIn));
                Console.Write("*");
                Console.Write(new string('.', dots));
                Console.WriteLine();
                dots -= 2;
                dotsIn += 4;
            }
            dots += 2;
            dotsIn -= 4;
            int symbolIn = dotsIn / 2;
            for (int height = 0; height < number - 2; height++)
            {
                Console.Write(".");
                Console.Write("*");
                if (height == number / 2 - 2)
                {
                    for (int i = 0; i < dotsIn / 2 + 1; i++)
                    {
                        bool isSymbol = true;
                        if (isSymbol)
                        {
                            Console.Write("@");
                            isSymbol = false;
                        }
                        if (!isSymbol && i != dotsIn / 2)
                        {
                            Console.Write(".");
                            isSymbol = true;
                        }
                    }
                }
                else if (height == number / 2 - 1)
                {
                    for (int i = 0; i < dotsIn / 2 + 1; i++)
                    {
                        bool isSymbol = true;
                        if (isSymbol)
                        {
                            Console.Write(".");
                            isSymbol = false;
                        }
                        if (!isSymbol && i != dotsIn / 2)
                        {
                            Console.Write("@");
                            isSymbol = true;
                        }
                    }
                }
                else
                {

                    Console.Write(new string('.', dotsIn));
                }
                Console.Write("*");
                Console.Write(".");
                Console.WriteLine();

                symbolIn += 2;
            }

            for (int height = 0; height < number / 2; height++)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('.', dotsIn));
                Console.Write("*");
                Console.Write(new string('.', dots));
                Console.WriteLine();
                dots += 2;
                dotsIn -= 4;
            }
            Console.Write(new string('.', dots));
            Console.Write(new string('*', topDown));
            Console.Write(new string('.', dots));
            Console.WriteLine();
        }        
    }
}