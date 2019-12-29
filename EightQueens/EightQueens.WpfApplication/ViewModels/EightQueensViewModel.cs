namespace EightQueens.WpfApplication.ViewModels
{
    using EightQueens.WpfApplication.Models;
    using System.Collections.Generic;

    public class EightQueensViewModel
    {
        public List<BoardSquare> Board { get; set; }

        public EightQueensViewModel()
        {
            this.Board = new List<BoardSquare>();
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));

            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));

            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));

            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));

            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));

            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));

            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));

            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));
            Board.Add(new BoardSquare(new Common.Position(0, 1), string.Empty));
            Board.Add(new BoardSquare(new Common.Position(0, 0), "../Resources/BlackSquares/BlackSquare_A1.png"));

        }
    }
}
