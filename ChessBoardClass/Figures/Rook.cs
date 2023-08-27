namespace ChessBoardClass.Shared;



    public class Rook : IFigure
    {
        private ConsoleColor color;
        private char figureSymbol;

        public char FigureSymbol{get{return figureSymbol;}}
        
        public ConsoleColor Color{get{return color;} set{color = value;}}

        public Rook(ConsoleColor color)
            {
                this.color = color;
            
            }



        public  char GetSymbol()
        {
            return figureSymbol;
        }

        public  void Attack() { }
        public  void Move() { }
        public  bool CanMoveToPosition(int[] newPosition, int[] coordinates)  {return true;}
    }

