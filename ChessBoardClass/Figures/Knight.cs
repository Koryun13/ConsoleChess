using System.Drawing;


namespace ChessBoardClass.Shared;



public class Knight : IFigure
{
    private ConsoleColor color;
    private char figureSymbol;

    public char FigureSymbol { get { return figureSymbol; } }

    public ConsoleColor Color { get { return color; } set { color = value; } }

    public Knight(ConsoleColor color)
    {
        this.color = color;
        this.figureSymbol = 'N';

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

        return (Math.Abs(diff.X) == 2 && Math.Abs(diff.Y) == 1) || (Math.Abs(diff.X) == 1 && Math.Abs(diff.Y) == 2);
    }



    public void Attack() { }
    public void Move() { }


}

