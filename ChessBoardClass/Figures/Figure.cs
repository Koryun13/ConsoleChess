namespace ChessBoardClass.Shared;

public interface IFigure
{   
    ConsoleColor Color{get;set;}

    char FigureSymbol{get;}
    
     char GetSymbol();
     void Attack();
     void Move();
     bool CanMoveToPosition(int[] newPosition, int[] coordinates);
    
}
