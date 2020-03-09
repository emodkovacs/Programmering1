using System;

 
namespace Miss_eller_träff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi ska spela. ");
            int[,] gameboard = new int[4, 4];
            Random rnd = new Random();
            int x = rnd.Next(4);//Målets x och y koordinater
            int y = rnd.Next(4);
            gameboard[x, y] = 1;//Målet
            bool hittat = false;
            int försök = 0;
            
            while (!hittat)
            {
                Console.WriteLine("Ge koordinaterna: ");
                Console.Write("x= ");
                int xa = Convert.ToInt32(Console.ReadLine());
                Console.Write("y= ");
                int ya = Convert.ToInt32(Console.ReadLine());
                
                if (gameboard[xa - 1, ya - 1] == 1)
                {
                    Console.WriteLine("Grattis du har hittat målet.");
                    gameboard[xa - 1, ya - 1] = 3;//3 betyder hen har hittat
                    hittat = true;
                }
                else
                {
                    Console.WriteLine("Du har missat, prova igen.");
                    gameboard[xa - 1, ya - 1] = 2;//2 betyder hen har missat
                }
                försök++;
                Console.WriteLine(" | 1|2|3|4|");
                for (int i = 0; i < gameboard.GetLength(0); i++)
                {
                    Console.Write(i+1 + "|");
                    for (int j = 0; j < gameboard.GetLength(1); j++)
                    {
                        switch (gameboard[i, j])
                        {
                            case 2:
                                Console.Write(" *");
                                break;
                            case 3:
                                Console.Write(" M");
                                break;
                            default:
                                Console.Write(" ");
                                break;
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Antalet försök=" + försök);
        }
    }
}