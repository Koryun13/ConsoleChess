namespace ChessBoardClass.Shared;

public struct ChessSquare
{
    public char Piece { get; set; }
    public bool IsOccupied { get; set; }
    public IFigure Figure { get; set; }
    //public ConsoleColor BackgroundColor { get; set; }
    public ConsoleColor FigureColor { get; set; }

    public ChessSquare()
    {
        IsOccupied = false;
        Piece = ' ';
    }

    public void InitFigure(IFigure figure)
    {
        Figure = figure;
        FigureColor = figure.Color;
        IsOccupied = true;
        Piece = figure.GetSymbol();
    }
}
