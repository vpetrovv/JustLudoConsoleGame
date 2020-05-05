namespace JustLudo.Common.Console
{
    using JustLudo.Figures;
    using JustLudo.Figures.Contracts;
    using JustLudo.Players.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Security.Principal;

    public static class ConsoleHelpers
    {
        static bool[,] token = new bool[,]
          {
                {false,true,false,},
                {true,true,true,},
                {false,true,false,}


          };
        public static ConsoleColor ToConsoleColor(this LudoColor ludocolor)
        {
            switch (ludocolor)
            {
                case LudoColor.Green:
                    return ConsoleColor.Green;
                case LudoColor.Yellow:
                    return ConsoleColor.Yellow;
                case LudoColor.Red:
                    return ConsoleColor.Red;
                case LudoColor.Blue:
                    return ConsoleColor.Blue;
                default:
                    throw new InvalidOperationException("Invalid Ludo color!");

            }
        }
        public static void SetCourserAtCenter(int lengthOfMessage)
        {
            int centerRow = 2;
            int centerCol = 2;
            Console.SetCursorPosition(centerCol, centerRow);

        }


        public static void PrintFigure(int top, int left, ConsoleColor backgroundColor)
        {
            var curentFigure = token;

            if (curentFigure == null)
            {
                PrintEmptySquare(backgroundColor, top, left);
                return;
            }


            for (int i = 0; i < curentFigure.GetLength(0); i++)
            {
                for (int j = 0; j < curentFigure.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j + left + 1, i + top + 1);


                    if (curentFigure[i, j])
                    {
                        Console.BackgroundColor = backgroundColor;


                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write(" ");

                }

            }







        }

        public static void PrintEmptySquare(ConsoleColor backgroundColor, int left, int top)
        {
            for (int i = 0; i < ConsoleConstants.CharactersPerRowPerBoardSquare; i++)
            {
                for (int J = 0; J < ConsoleConstants.CharactersPerColPerBoardSquare; J++)
                {
                    Console.SetCursorPosition(left + J, top + i);
                    Console.WriteLine(" ");
                }
            }
        }

    }
}
