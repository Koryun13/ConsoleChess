namespace ChessBoardClass.Shared;

public interface IFigure
{   
    ConsoleColor Color{get;set;}

    char FigureSymbol{get;}
    
     char GetSymbol();
     void Attack();
     void Move();
     public bool CanMoveToPosition(int cRow, int cCol, int nRow, int nCol);
    ///kioioio
}
