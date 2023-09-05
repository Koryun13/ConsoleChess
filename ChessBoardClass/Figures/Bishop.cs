namespace ChessBoardClass.Shared;



    public class Bishop : IFigure
    {
       private ConsoleColor color;
        private char figureSymbol;

        public char FigureSymbol{get{return figureSymbol;}}
        
        public ConsoleColor Color{get{return color;} set{color = value;}}
        
        public Bishop(ConsoleColor color)
            {
                this.color = color;

            }


        public  char GetSymbol()
        {
            return figureSymbol;
        }

         

        public bool CanMoveToPosition(int cRow, int cCol, int nRow, int nCol)
        {
            int dx = Math.Abs(nCol - cCol);
            int dy = Math.Abs(nRow - cRow);
            return dx == dy;
        }


        public  void Attack() { }
        public  void Move() { }

        
    }

