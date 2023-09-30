using System.Drawing;

// using time stamp to understend time complexity of the algorithm
// find the most optimal path to get to the destination.

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


    public bool CanMoveToPosition(int cRow, int cCol, int nRow, int nCol)
    {
        int dx = Math.Abs(nCol - cCol);
        int dy = Math.Abs(nRow - cRow);
        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }


    public void Attack() { }
    public void Move() { }


}

