namespace ChessBoardClass.Shared;



    public class King : IFigure
    {
        private ConsoleColor color;
        private char figureSymbol;

        public char FigureSymbol{get{return figureSymbol;}}
        
        public ConsoleColor Color{get{return color;} set{color = value;}}
        public King(ConsoleColor color)
            {
                this.color = color;
                
            }


        public  char GetSymbol()
        {
            return figureSymbol;
        }

        public  void Attack() { }
        public  void Move() { }
        
        public bool CanMoveToPosition(int cRow, int cCol, int nRow, int nCol)
        {
            int dx = Math.Abs(nCol - cCol);
            int dy = Math.Abs(nRow - cRow);
            return dx <= 1 && dy <= 1;
        }

        
    }

