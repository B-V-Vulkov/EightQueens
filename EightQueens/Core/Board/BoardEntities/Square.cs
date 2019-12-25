namespace Core.Board.BoardEntities
{
    using Common;

    public class Square : BaseBoardEntity
    {
        public Square(ChessColor chessColor) 
            : base(chessColor)
        {
        }
    }
}
