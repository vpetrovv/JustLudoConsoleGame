//namespace JustLudo.Renderers
//{
//    using JustLudo.Board.Contracts;
//    using JustLudo.Common.Console;
//    using JustLudo.Renderers.Contracts;
//    using System;
//    using System.Diagnostics;
//    using System.Threading;

//    public class ConsoleRenderer : IRenderer
//    {

//        private const string logo = "JUST LUDO";
//        private const int CharactersPerRowPerBoardSquare = 7;
//        private const int CharactersPerColPerBoardSquare = 7;
//        static int ConsoleRows = 100;
//        static int ConsoleCols = 100;

//        public void RenderMainMenu()
//        {
//            ConsoleHelpers.SetCourserAtCenter(logo.Length);
//            Thread.Sleep(1000);
//            Console.WriteLine(logo);

//        }
//        public void RenderBoard(IBoard board)
//        {
//            Console.WindowHeight = ConsoleRows;
//            Console.WindowWidth = ConsoleCols;
//            Console.BufferHeight = ConsoleRows;
//            Console.BufferWidth = ConsoleCols;
//            //var startRowPrint = Console.WindowHeight / 2 - (board.TotalRows / 2) * CharactersPerRowPerBoardSquare;
//            //var startColPrint = Console.WindowWidth / 2 - (board.TotalCols / 2) * CharactersPerColPerBoardSquare;
//            var startRowPrint = 4;
//            var startColPrint = 4;
//            var currentRowPrint = startRowPrint;
//            var currentColPrint = startColPrint;
//            Console.BackgroundColor = ConsoleColor.White;

//            var startTablePrintRow = (board.TotalRows - 3) / 2;
//            var startTablePrintCol = (board.TotalCols - 3) / 2;


//            for (int top = 0; top < (board.TotalRows - 3) / 2; top++)
//            {

//                for (int left = 0; left < (board.TotalCols - 3) / 2; left++)
//                {
//                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
//                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

//                    Console.BackgroundColor = ConsoleColor.Green;


//                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
//                    {
//                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
//                        {
//                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
//                            Console.WriteLine(" ");
//                        }
//                    }
//                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
//                    Console.WriteLine(" ");




//                }

//            }


//            for (int top = 8; top < board.TotalRows; top++)
//            {
//                for (int left = 0; left < (board.TotalCols - 3) / 2; left++)
//                {
//                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
//                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

//                    Console.BackgroundColor = ConsoleColor.Blue;


//                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
//                    {
//                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
//                        {
//                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
//                            Console.WriteLine(" ");
//                        }
//                    }
//                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
//                    Console.WriteLine(" ");

//                }
//            }

//            for (int top = 0; top < (board.TotalRows - 3) / 2; top++)
//            {
//                for (int left = 8; left < board.TotalCols; left++)
//                {
//                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
//                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

//                    Console.BackgroundColor = ConsoleColor.Red;


//                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
//                    {
//                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
//                        {
//                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
//                            Console.WriteLine(" ");
//                        }
//                    }
//                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
//                    Console.WriteLine(" ");

//                }
//            }

//            for (int top = 8; top < board.TotalRows; top++)
//            {
//                for (int left = 8; left < board.TotalCols; left++)
//                {
//                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
//                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

//                    Console.BackgroundColor = ConsoleColor.Yellow;


//                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
//                    {
//                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
//                        {
//                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
//                            Console.WriteLine(" ");
//                        }
//                    }
//                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
//                    Console.WriteLine(" ");


//                }
//            }


//            for (int top = (board.TotalCols - 3) / 2; top < 8; top++)
//            {
//                for (int left = 0; left < board.TotalRows; left++)
//                {
//                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
//                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;


//                    if ((top == 6) && (left > 0 && left < 5))
//                    {
//                        Console.BackgroundColor = ConsoleColor.Green;
//                    }
//                    else if (top == 6 && (left > 7 && left < 12))
//                    {
//                        Console.BackgroundColor = ConsoleColor.Yellow;
//                    }
//                    else
//                    {
//                        Console.BackgroundColor = ConsoleColor.Black;

//                    }


//                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
//                    {
//                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
//                        {
//                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
//                            if (J == 0 || (J == CharactersPerRowPerBoardSquare - 1))
//                            {
//                                Console.Write("|");

//                            }


//                        }

//                    }

//                    Console.SetCursorPosition(currentColPrint, currentRowPrint);


//                    Console.WriteLine("-------");
//                    if ((top > 0 && top < 5) && (left == 7))
//                    {
//                        Console.BackgroundColor = ConsoleColor.Green;
//                    }

//                }
//            }




//            for (int top = 0; top < 5; top++)
//            {
//                for (int left = 5; left < 8; left++)
//                {
//                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
//                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

//                    Console.BackgroundColor = ConsoleColor.Black;
//                    if (left == 6 && top > 0 && top < 5)
//                    {
//                        Console.BackgroundColor = ConsoleColor.Red;

//                    }


//                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
//                    {
//                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
//                        {
//                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
//                            if (J == 0 || (J == CharactersPerRowPerBoardSquare - 1))
//                            {
//                                Console.Write("|");

//                            }


//                        }




//                    }
//                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
//                    if ((left == 7 || left == 6) && top > 0 && top < 5)
//                    {
//                        Console.BackgroundColor = ConsoleColor.Red;
//                        Console.WriteLine("-------");

//                    }
//                    else
//                    {
//                        Console.BackgroundColor = ConsoleColor.Black;

//                        Console.WriteLine("-------");

//                    }

//                }
//            }



//            for (int top = 8; top < board.TotalRows; top++)
//            {
//                for (int left = 5; left < 8; left++)
//                {
//                    currentRowPrint = startRowPrint + left * CharactersPerRowPerBoardSquare;
//                    currentColPrint = startColPrint + top * CharactersPerColPerBoardSquare;

//                    Console.BackgroundColor = ConsoleColor.Black;
//                    if (left == 6 && top > 7 && top < 12)
//                    {
//                        Console.BackgroundColor = ConsoleColor.Blue;

//                    }

//                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
//                    {
//                        for (int J = 0; J < CharactersPerColPerBoardSquare; J++)
//                        {
//                            Console.SetCursorPosition(currentColPrint + J, currentRowPrint + i);
//                            if (J == 0 || (J == CharactersPerRowPerBoardSquare - 1))
//                            {
//                                Console.Write("|");

//                            }


//                        }

//                        // Console.WriteLine("|");


//                    }
//                    Console.SetCursorPosition(currentColPrint, currentRowPrint);

//                    if ((left == 7 || left == 6) && top > 7 && top < board.TotalRows - 1)
//                    {
//                        Console.BackgroundColor = ConsoleColor.Blue;
//                        Console.WriteLine("-------");

//                    }
//                    else
//                    {
//                        Console.BackgroundColor = ConsoleColor.Black;

//                        Console.WriteLine("-------");

//                    }

//                }
//            }


//            Console.ReadLine();
//        }
//    }
//}
