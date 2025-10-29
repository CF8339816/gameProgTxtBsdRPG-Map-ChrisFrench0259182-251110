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

            DMap();













        }
        //methods below here

        //m1
        static void DrawMap()
        {

            for (int x = 0; x < map.GetLength(0); x++) // Rows
            {
                for (int y = 0; y < map.GetLength(1); y++) // Columns
                {

                    switch (map[x, y]) //changes colours
                    {
                        case '`': // Grass
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case '~': // Water
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case '^': // Mountain
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case '*': // trees
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;


                    }



                    Console.Write(map[x, y] );
                }
                Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        //m2
        static void DMap()
        {

            for (int x = 0; x < map.GetLength(0); x++) // Rows
            {
                for (int y = 0; y < map.GetLength(1); y++) // Columns
                {

                    switch (map[x, y]) //changes colours
                    {
                        case '`': // Grass
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case '~': // Water
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case '^': // Mountain
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case '*': // trees
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;


                    }

                    foreach map in map

                    Console.Write(map[x, y] );
                }
                Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        //m3

        //m4

        //m5








    }
}
