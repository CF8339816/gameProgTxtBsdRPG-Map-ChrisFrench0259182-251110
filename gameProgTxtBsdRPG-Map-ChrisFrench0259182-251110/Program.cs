using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProgTxtBsdRPG_Map_ChrisFrench0259182_251110
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
        {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees







        static void Main(string[] args)
        {




            DrawMap();
            mapLegend();


            DrawMap(2);
            mapLegend();


            DrawMap(3);
            mapLegend();







            Console.ForegroundColor = ConsoleColor.White;

        }
        //methods below here

        //m1
        static void DrawMap()
        {

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {

                    switch (map[x, y]) //changes colours
                    {

                        case '`': // Grass
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case '~': // Water
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case '^': // Mountain
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case '*': // Trees
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;


                    }



                    Console.Write(map[x, y]);
                }
                Console.WriteLine();


                Console.ResetColor();

            }
        }

        //m2
        static void mapLegend()
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" `  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Grass");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" ~  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Water");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" ^  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Mountain");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" *  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Trees");

            Console.ResetColor();
        }


        //m3
        static void DrawMap(int scale)
        {
            int rows = map.GetLength(0);

            int cols = map.GetLength(1);

            Border(cols, scale);

            // for (int x = 0; x < map.GetLength(0); x++) 
            for (int x = 0; x < rows; x++)

            {
                for (int rowScale = 0; rowScale < scale; rowScale++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");

                    {
                        //for (int y = 0; y < map.GetLength(1); y++) 
                        for (int y = 0; y < cols; y++)

                        {
                            char tile = map[x, y];

                            switch (map[x, y]) //changes colours
                            {

                                case '`': // Grass
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    break;
                                case '~': // Water
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case '^': // Mountain
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                                case '*': // Trees
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;


                            }
                            for (int colScale = 0; colScale < scale; colScale++)
                            {
                                Console.Write(tile);
                            }


                            Console.Write(map[x, y]/* + " "*/);
                        }
                        // Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("|");

                        Console.ResetColor();
                    }
                }
            }
        }




        //m4

        static void Border(int cols, int scale)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("+");

            for (int i = 0; i < cols * scale; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }


        //m5

    }
}









            
        
    


