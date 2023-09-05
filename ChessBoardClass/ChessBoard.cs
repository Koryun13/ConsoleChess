using System.Runtime.InteropServices;

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
       
        return new ChessSquare(row, col, bgColor);
    }

   
    public void SetFigureAtPosition(IFigure _figure, int row, int col)
    {   
        int crow = 8 - row;
        int ccol = col - 1;


        if (row < 0 || row >= 8 || col < 0 || col >= 8)
        {
            
        }
        else
        {
            try
            {
            board[crow, ccol].InitFigure(_figure);

            board[crow+1, ccol+1].Piece = '2';
            board[crow-1, ccol+1].Piece = '2';
            board[crow+1, ccol-1].Piece = '2';
            board[crow-1, ccol-1].Piece = '2';


            
            board[crow, ccol+1].Piece = '3';
            board[crow, ccol-1].Piece = '3';
            board[crow+1, ccol].Piece = '3';
            board[crow-1, ccol].Piece = '3';
         
           
        }
        catch(FormatException)
        {
            Console.WriteLine("INVALID INPUT ENTRY...");
        }
    }

        
        
    }

    

    public void SetPossibleMoves(int row, int col)
    {
        int crow = 8 - row;
        int ccol = col - 1;


        if (row < 0 || row >= 8 || col < 0 || col >= 8)
        {
            
        }
        else
        {
            if(board[crow, ccol].IsOccupied)
            {

            }
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
                    Console.Write(board[row, col].Piece + " ");
                }
                else
                {   
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(board[row,col].Piece + " ");
                }
                
            }

            Console.ResetColor();
            Console.WriteLine(" " + (8 - row)); 
        }

        Console.WriteLine("  A B C D E F G H");
    }


    private void SetNumberOfMoves(int row, int col)
    {
        
    }
 
}


