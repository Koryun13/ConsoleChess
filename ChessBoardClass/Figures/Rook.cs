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

        public bool CanMoveToPosition(int cRow, int cCol, int nRow, int nCol)
        {
            return cRow == nRow || cCol == nCol;
        }
        public  void Attack() { }
        public  void Move() { }
        
        

    }

