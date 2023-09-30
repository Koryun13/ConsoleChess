namespace ChessBoardClass.Shared;



public class Rook : IFigure
{
    private ConsoleColor color;
    private char figureSymbol;

    public char FigureSymbol { get { return figureSymbol; } }

    public ConsoleColor Color { get { return color; } set { color = value; } }

    public Rook(ConsoleColor color)
    {
        this.color = color;

    }



    public char GetSymbol()
    {
        return figureSymbol;
    }

    public bool CanMoveToPosition(string currentPosString, string newPosString)
    {
        Coordinate currentPos = new Coordinate(currentPosString);
        Coordinate newPos = new Coordinate(newPosString);

        Coordinate diff = newPos - currentPos;

        return currentPos != newPos && (diff.X == 0 || diff.Y == 0);
    }

    public void Attack() { }
    public void Move() { }



}

