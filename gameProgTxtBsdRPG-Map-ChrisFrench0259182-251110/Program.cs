using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        static int customScale;
        static int custScale;
        static int scale;

        static int asciiValue = 232; // ASCII value for 'bell'
        

        static int anotherAsciiValue = 206; // ASCII value for 'hollow star'



        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("DisplayMap():");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" (added this one because it was in the examples) ");
            DrawMap(0);
            Console.WriteLine();
            mapLegend();
            Console.WriteLine("\n");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("DisplayMap(1):");
            DrawMap(1);
            Console.WriteLine();
            mapLegend();
            Console.WriteLine("\n");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("DisplayMap(2):");
            DrawMap(2);
            Console.WriteLine();
            mapLegend();
            Console.WriteLine("\n");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("DisplayMap(3):");
            DrawMap(3);
            Console.WriteLine();
            mapLegend();

            Console.WriteLine("\n");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("DisplayMap(4):");
            DrawMap(4);
            Console.WriteLine();
            mapLegend();

            Thread.Sleep(1500);
            getScale();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"DisplayMap({custScale}):");
            // scale = customScale;
            DrawMap(custScale);
            Console.WriteLine();
            mapLegend();






            Console.ForegroundColor = ConsoleColor.White;

        }
        //methods below here

        //m1
        static void getScale()
        {

            Console.WriteLine("What scale would you like to try next?");
            custScale = int.Parse(Console.ReadLine());
           //int customScale = Convert.ToInt32(custScale);

        }


        //m2
        static void mapLegend()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
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

             for (int x = 0; x < map.GetLength(0); x++) 
           

            {
                for (int rowScale = 0; rowScale < scale; rowScale++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    //Console.Write("|");
                    //Console.Write((char)7);
                    Console.Write((char)asciiValue);
                    {
                        for (int y = 0; y < map.GetLength(1); y++) 
                      

                        {
                            char tile = map[x, y];

                            switch (map[x, y]) //changes colours
                            {

                                case '`': // Grass
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
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

                          
                        }
                        // Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        //Console.WriteLine("|");
                        //Console.WriteLine((char)7);
                        Console.WriteLine((char)asciiValue);
                    }

                }

            }
                    Border(cols, scale);
                    Console.ResetColor();

        }


        //m4

        static void Border(int cols, int scale)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.Write("+");
            Console.Write((char)anotherAsciiValue);

            for (int i = 0; i < cols * scale; i++)
            {
                //Console.Write("-");
                //Console.Write((char)7);
                Console.Write((char)asciiValue);
            }
            //Console.WriteLine("+");
            //Console.WriteLine((char)15);
            Console.WriteLine((char)anotherAsciiValue);
        }


        //m5

    }
}









            
        
    


