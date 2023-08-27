using System;
namespace ChessBoardClass.Shared;

struct ChessSquare
{
    public int Row { get; }
    public int Col { get; }
   // public char Piece { get; set; }

    //public Figure figure;
    public bool IsOccupied{get; set;}
    public IFigure figure{get; set;}
    public ConsoleColor BackgroundColor { get; set; }
    public ConsoleColor FigureColor { get; set; }

    public ChessSquare(int row, int col, ConsoleColor bgColor)
    {
        Row = row;
        Col = col;
        BackgroundColor = bgColor;
        IsOccupied = false;


    }
        
    public void InitFigure(IFigure figure)
    {
        this.figure = figure;
        FigureColor = figure.Color;
        IsOccupied = true;
      // Piece = figure.GetSymbol();

    }
}