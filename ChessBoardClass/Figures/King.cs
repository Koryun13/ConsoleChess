namespace ChessBoardClass.Shared;



public class King : IFigure
{
    private ConsoleColor color;
    private char figureSymbol;

    public char FigureSymbol { get { return figureSymbol; } }

    public ConsoleColor Color { get { return color; } set { color = value; } }
    public King(ConsoleColor color)
    {
        this.color = color;

    }


    public char GetSymbol()
    {
        return figureSymbol;
    }

    public void Attack() { }
    public void Move() { }

    public bool CanMoveToPosition(string currentPosString, string newPosString)
    {
        Coordinate currentPos = new Coordinate(currentPosString);
        Coordinate newPos = new Coordinate(newPosString);

        Coordinate diff = newPos - currentPos;

        return Math.Max(Math.Abs(diff.X), Math.Abs(diff.Y)) == 1;
    }



}

