namespace JustLudo.Renderers
{
    using JustLudo.Board.Contracts;
    using JustLudo.Common;
    using JustLudo.Common.Console;
    using JustLudo.Figures;
    using JustLudo.Renderers.Contracts;
    using System;
    using System.Diagnostics;
    using System.Threading;

    public class ConsoleRenderer : IRenderer
    {
        private const string logo = "JUST LUDO";
        private const int CharactersPerRowPerBoardSquare = 5;
        private const int CharactersPerColPerBoardSquare = 5;
        static int ConsoleRows = 83;
        static int ConsoleCols = 90;




        public void RenderMainMenu()
        {
            ConsoleHelpers.SetCourserAtCenter(logo.Length);
            Thread.Sleep(1000);
            Console.WriteLine(logo);

        }
        public void RenderBoard(IBoard board)
        {
            Console.WindowHeight = ConsoleRows;
            Console.WindowWidth = ConsoleCols;
            Console.BufferHeight = ConsoleRows;
            Console.BufferWidth = ConsoleCols;
            //var startRowPrint = Console.WindowHeight / 2 - (board.TotalRows / 2) * CharactersPerRowPerBoardSquare;
            //var startColPrint = Console.WindowWidth / 2 - (board.TotalCols / 2) * CharactersPerColPerBoardSquare;
            var startRowPrint = 0;
            var startColPrint = 0;
            var currentRowPrint = startRowPrint;
            var currentColPrint = startColPrint;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleColor backgroundCcolor;

            var startTablePrintRow = (board.TotalRows - 3) / 2;
            var startTablePrintCol = (board.TotalCols - 3) / 2;


            for (int top = 0; top < (board.TotalRows - 3) / 2; top++)
            {

                for (int left = 0; left < (board.TotalCols - 3) / 2; left++)
                {



                    //var position = Position.FromArrayCoordinates(top, left);
                    //var figure = board.GetFigureAtPosition(position);
                    //ConsoleHelpers.PrintFigure(figure, top ConsoleColor.Green);


                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

                    if ((top == 1 || top == 3) && (left == 1 || left == 3))
                    {
                        backgroundCcolor = ConsoleColor.Black;

                        var backgroundColor = ConsoleColor.Green;
                        ConsoleHelpers.PrintFigure(currentRowPrint, currentColPrint, backgroundColor);


                    }
                    else
                    {
                        var backgroundColor = Console.BackgroundColor = ConsoleColor.Green;


                        for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
                        {
                            for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
                            {
                                Console.SetCursorPosition(currentRowPrint + J, currentColPrint + i);
                                Console.WriteLine(" ");
                            }
                        }
                        Console.SetCursorPosition(currentColPrint, currentRowPrint);
                        Console.WriteLine(" ");
                    }





                }

            }
            Console.SetCursorPosition(startTablePrintRow, startTablePrintCol);



            for (int top = 8; top < board.TotalRows; top++)
            {
                for (int left = 0; left < (board.TotalCols - 3) / 2; left++)
                {
                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

                    Console.BackgroundColor = ConsoleColor.Blue;


                    if ((top == 9 || top == 11) && (left == 1 || left == 3))
                    {
                        backgroundCcolor = ConsoleColor.Black;
                        var backgroundColor = ConsoleColor.Blue;
                        ConsoleHelpers.PrintFigure(currentRowPrint, currentColPrint, backgroundColor);


                    }
                    else
                    {
                        for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
                        {
                            for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
                            {
                                Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
                                Console.WriteLine(" ");
                            }
                        }
                        Console.SetCursorPosition(currentColPrint, currentRowPrint);

                        Console.WriteLine(" ");
                    }



                }
            }

            for (int top = 0; top < (board.TotalRows - 3) / 2; top++)
            {
                for (int left = 8; left < board.TotalCols; left++)
                {
                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

                    Console.BackgroundColor = ConsoleColor.Red;
                    if ((top == 1 || top == 3) && (left == 9 || left == 11))
                    {
                        backgroundCcolor = ConsoleColor.Black;
                        var backgroundColor = ConsoleColor.Red;
                        ConsoleHelpers.PrintFigure(currentRowPrint, currentColPrint, backgroundColor);


                    }
                    else
                    {
                        for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
                        {
                            for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
                            {
                                Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
                                Console.WriteLine(" ");
                            }
                        }
                        Console.SetCursorPosition(currentColPrint, currentRowPrint);
                        Console.WriteLine(" ");
                    }



                }
            }

            for (int top = 8; top < board.TotalRows; top++)
            {
                for (int left = 8; left < board.TotalCols; left++)
                {
                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

                    Console.BackgroundColor = ConsoleColor.Yellow;

                    if ((top == 9 || top == 11) && (left == 9 || left == 11))
                    {
                        backgroundCcolor = ConsoleColor.Black;
                        var backgroundColor = ConsoleColor.Yellow;
                        ConsoleHelpers.PrintFigure(currentRowPrint, currentColPrint, backgroundColor);


                    }
                    else
                    {
                        for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
                        {
                            for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
                            {
                                Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
                                Console.WriteLine(" ");
                            }
                        }
                        Console.SetCursorPosition(currentColPrint, currentRowPrint);
                        Console.WriteLine(" ");
                    }



                }
            }


            for (int top = ((board.TotalCols - 3) / 2); top < 8; top++)
            {

                for (int left = 0; left < board.TotalRows; left++)
                {
                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;


                    if ((top == 6) && (left > 0 && left < 5))
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (top == 6 && (left > 7 && left < 12))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;

                    }


                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
                    {

                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
                        {
                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
                            if (J == 0 || J == CharactersPerColPerBoardSquare - 1)
                            {
                                Console.Write("|");

                            }


                        }

                    }

                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
                    Console.WriteLine("-----");

                    if ((top > 0 && top < 5) && (left == 7))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }

                }
            }




            for (int top = 0; top < 5; top++)
            {
                for (int left = 5; left < 8; left++)
                {
                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

                    Console.BackgroundColor = ConsoleColor.Black;
                    if (left == 6 && top > 0 && top < 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;

                    }


                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
                    {
                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
                        {
                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
                            if (J == 0 || (J == CharactersPerRowPerBoardSquare - 1))
                            {
                                Console.Write("|");

                            }


                        }




                    }
                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
                    if ((left == 7 || left == 6) && top > 0 && top < 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("-----");

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine("-----");

                    }

                }
            }



            for (int top = 8; top < board.TotalRows; top++)
            {
                for (int left = 5; left < 8; left++)
                {
                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

                    Console.BackgroundColor = ConsoleColor.Black;
                    if (left == 6 && top > 7 && top < 12)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
                    {
                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
                        {
                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
                            if (J == 0 || (J == CharactersPerRowPerBoardSquare - 1))
                            {
                                Console.Write("|");

                            }


                        }

                        // Console.WriteLine("|");


                    }
                    Console.SetCursorPosition(currentColPrint, currentRowPrint);

                    if ((left == 7 || left == 6) && top > 7 && top < board.TotalRows - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-----");

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine("-----");

                    }
                }
            }

            Console.SetCursorPosition(70, 2);
        }
    }
}
