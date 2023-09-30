namespace ChessBoardClass.Shared;



public class Bishop : IFigure
{
    private ConsoleColor color;
    private char figureSymbol;

    public char FigureSymbol { get { return figureSymbol; } }

    public ConsoleColor Color { get { return color; } set { color = value; } }

    public Bishop(ConsoleColor color)
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

        return currentPos != newPos && Math.Abs(diff.X) == Math.Abs(diff.Y);
    }


    public void Attack() { }
    public void Move() { }


}

