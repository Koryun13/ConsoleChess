// namespace ChessBoardClass.Shared;

// public class Move
// {
//     public int Row{get; set;}
//     public int Col{get; set;}


//     public bool CanMoveToPosition(int cRow, int cCol, int nRow, int nCol)
//     {
//         int dx = Math.Abs(nCol - cCol);
//         int dy = Math.Abs(nRow - cRow);
//         return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
//     }
    


//     public void PrintBoard()
//         {
//             Console.WriteLine("  A B C D E F G H"); 

//             for (int row = 0; row < 8; row++)
//             {
//                 Console.Write(8 - row + " "); 

//                 for (int col = 0; col < 8; col++)

//                 {   
//                     Console.BackgroundColor = board[row, col].BackgroundColor;
                    
//                     if(board[row,col].IsOccupied)
//                     {
                        
                        
//                         Console.ForegroundColor = board[row,col].figure.Color;

//                         Console.Write(board[row, col].figure.GetSymbol() + " ");
                        


//                     }
//                     else
//                     {   
//                         Console.ForegroundColor = ConsoleColor.White;
//                         Console.Write("  ");
//                     }
                    
//                 }

//                 Console.ResetColor();
//                 Console.WriteLine(" " + (8 - row)); 
//             }

//             Console.WriteLine("  A B C D E F G H");
//         }
// }