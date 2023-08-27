namespace ChessBoardClass.Shared;


public class ChessBoard
{
    private ChessSquare[,] board;

    public ChessBoard()
    {
        board = new ChessSquare[8, 8];
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                ChessSquare square = CreateChessSquare(row, col);
                board[row, col] = square;
            }
        }
    }

    private ChessSquare CreateChessSquare(int row, int col)
    {
        ConsoleColor bgColor = (row + col) % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Yellow;
        //ConsoleColor fgColor = bgColor == ConsoleColor.White ? ConsoleColor.Black : ConsoleColor.White;
        //char piece = ' ';

        return new ChessSquare(row, col, bgColor);
    }

   
    public void SetFigureAtPosition(IFigure _figure, int row, int col)
    {
        if (row < 0 || row >= 8 || col < 0 || col >= 8)
        {
            
        }
        else
        {
           board[8 - row, col - 1].InitFigure(_figure);
           
           
            //board[8 - row, col - 1].FigureColor = figure.Color;
        }

        
        
    }
    public void PrintBoard()
        {
            Console.WriteLine("  A B C D E F G H"); 

            for (int row = 0; row < 8; row++)
            {
                Console.Write(8 - row + " "); 

                for (int col = 0; col < 8; col++)

                {   
                    Console.BackgroundColor = board[row, col].BackgroundColor;
                    
                    if(board[row,col].IsOccupied)
                    {
                        
                        
                        Console.ForegroundColor = board[row,col].figure.Color;

                        Console.Write(board[row, col].figure.GetSymbol() + " ");
                        


                    }
                    else
                    {   
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  ");
                    }
                    
                }

                Console.ResetColor();
                Console.WriteLine(" " + (8 - row)); 
            }

            Console.WriteLine("  A B C D E F G H");
        }

         // private char GetInitialPiece(int row, int col)
    // {
    
    //     char piece = ' ';
    //     if (row == 0 || row == 7)
    //     {
    //         char[] pieces = { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' };
    //         piece = pieces[col];
    //     }
    //     else if (row == 1 || row == 6)
    //     {
    //         piece = 'p';
    //     }
    //     return piece;
    // }

        
    }


// public class ChessBoard
// {
//     public static int Size;
//     private enum Letters {
//         A,
//         B,
//         C,
//         D,
//         E,
//         F,
//         G,
//         H
//     }

//     private char [,] board; 

//     public ChessBoard(int size)
//     {
//         board = new char[size,size];

//         for(int i = 0; i < size; i++)
//         {
//             for(int j = 0; j < size; j++)
//             {
//                 board[i,j] = '*';
//             }
//         }
//     }

//     public void PrintBoard()
//     {
//        // Console.Write(Size);

//         for (int i = 0; i < board.GetLength(0); i++)
//         {
//             for (int j = 0; j < board.GetLength(1); j++)
//             {
//                 Console.Write(board[i,j] + "  ");
//             }
//             Console.WriteLine();
//         }
//     }
    
//     public void SetFigure(char symbol ,int horizon, int vertical)
//     {
//         board[horizon,vertical] = symbol;
//     }

    
// }
