using System;
using System.Text;

class SmetalnikaNaBaba
{
    static void Main()
    {
        checked
        {
            // Input
            int size = int.Parse(Console.ReadLine());
            int[,] smetalo = new int[8, size];

            for (int row = 0; row < smetalo.GetLength(0); row++)
            {
                long number = long.Parse(Console.ReadLine());
                string bitsNumber = Convert.ToString(number, 2).PadLeft(size, '0');
                for (int col = 0; col < smetalo.GetLength(1); col++)
                {
                    smetalo[row, col] = Convert.ToInt32(bitsNumber[col].ToString(), 2);
                }
            }

            // Solution
            string command = string.Empty;
            int countEmpyCol = 0;
            while (true)
            {
                command = Console.ReadLine();

                if (command == "reset")
                {
                    // reset
                    for (int row = 0; row < smetalo.GetLength(0); row++)
                    {
                        int count = 0; // clean every time 0
                        for (int col = 0; col < smetalo.GetLength(1); col++)
                        {
                            if (smetalo[row, col] == 1)
                            {
                                count++;
                                smetalo[row, col] = 0;
                            }
                        }
                        for (int i = 0; i < count; i++) // full the matrix with count time "1" 
                        {
                            smetalo[row, i] = 1;
                        }
                    }
                }
                else if (command != "stop")
                {
                    int rowCom = int.Parse(Console.ReadLine());
                    int colCom = int.Parse(Console.ReadLine());

                    if (colCom < 0)
                    {
                        colCom = 0;
                    }
                    else if (colCom > size - 1)
                    {
                        colCom = size - 1;
                    }
                    if (command == "right")
                    {
                        // right commant
                        int count = 0; // clean every time 0
                        for (int col = colCom; col < smetalo.GetLength(1); col++)
                        {
                            if (smetalo[rowCom, col] == 1)
                            {
                                count++;
                                smetalo[rowCom, col] = 0;
                            }
                        }

                        for (int i = 0; i < count; i++) // full the matrix with count time "1" 
                        {
                            smetalo[rowCom, size - 1 - i] = 1;
                        }
                    }
                    else if (command == "left")
                    {
                        // left commant
                        int count = 0; // clean every time 0
                        for (int col = colCom; col > 0; col--)
                        {
                            if (smetalo[rowCom, col] == 1)
                            {
                                count++;
                                smetalo[rowCom, col] = 0;
                            }
                        }

                        for (int i = 0; i < count; i++) // full the matrix with count time "1" 
                        {
                            smetalo[rowCom, i] = 1;
                        }
                    }
                }
                else if (command == "stop")
                {
                    for (int row = 0; row < smetalo.GetLength(1); row++)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int col = 0; col < smetalo.GetLength(0); col++)
                        {
                            sb.Append(smetalo[col, row]); // add all 1
                        }

                        long number = Convert.ToInt32(sb.ToString(), 2); // convert to int from bits(string)
                        if (number == 0)
                        {
                            countEmpyCol++;
                        }
                    }
                    break;
                }
            }

            //// Print Matrix
            //for (int row = 0; row < smetalo.GetLength(0); row++)
            //{
            //    for (int col = 0; col < smetalo.GetLength(1); col++)
            //    {
            //        Console.Write(smetalo[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            // Output
            long result = 0;
            for (int row = 0; row < smetalo.GetLength(0); row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < smetalo.GetLength(1); col++)
                {
                    sb.Append(smetalo[row, col]); // add all 1
                }

                result += Convert.ToInt32(sb.ToString(), 2); // convert to int from bits(string)
            }

            Console.WriteLine(result * countEmpyCol); // print numbers

        }
    }
}