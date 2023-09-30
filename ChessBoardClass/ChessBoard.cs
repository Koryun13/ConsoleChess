using System;

namespace ChessBoardClass.Shared
{
    public class ChessBoard
    {
        private ChessSquare[,] chessboard;

        public ChessBoard()
        {
            InitializeChessboard();
        }

        private void InitializeChessboard()
        {
            chessboard = new ChessSquare[8, 8];

            foreach (string coordinateString in Coordinate.AllCoordinates)
            {
                Coordinate.SetCodrdinate(coordinateString);
                int x = Coordinate.X;
                int y = Coordinate.Y;
                chessboard[x, y] = new ChessSquare();
            }
        }

        public void PrintChessboard()
        {
            Console.WriteLine("  A  B  C  D  E  F  G  H");
            

            foreach (string coordinateString in Coordinate.AllCoordinates)
            {
                Coordinate.SetCodrdinate(coordinateString);
                int x = Coordinate.X;
                int y = Coordinate.Y;

                if (y == 0)
                {
                    Console.Write((8 - x));
                }
                Console.BackgroundColor = (x + y) % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Yellow;
                Console.Write($" {chessboard[x, y].Piece} ");
                Console.ResetColor();
               // Console.Write("|");

                if (y == 7)
                {
                    Console.WriteLine("");
                }
            }
        }

        // Add other chess-related methods here

        public void MovePiece(string fromCoordinate, string toCoordinate)
        {
            // Implement piece movement logic here
        }

        // More methods for managing the game

    }
}
