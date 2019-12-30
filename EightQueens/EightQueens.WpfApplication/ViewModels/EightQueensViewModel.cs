namespace EightQueens.WpfApplication.ViewModels
{
    using Common;
    using EightQueens.WpfApplication.Models;
    using System.Collections.Generic;

    public class EightQueensViewModel
    {
        public List<BoardSquare> Board { get; set; }

        public EightQueensViewModel()
        {
            this.Board = new List<BoardSquare>();
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));

            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));

            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White) { UrlFigureImage = "../Resources/Crown/Crown.png" });
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));

            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));

            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));

            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black) { UrlFigureImage = "../Resources/Crown/Crown.png" });
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));

            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));

            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
            Board.Add(new BoardSquare(ChessColor.White));
            Board.Add(new BoardSquare(ChessColor.Black));
        }
    }
}
