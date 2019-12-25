using Core.Board;

namespace ConsoleRenderer
{
    public class StartUp
    {
        public static void Main()
        {
            StandardBoard standardBoard = new StandardBoard();

            for (int row = 0; row < standardBoard.Board.GetLength(0); row++)
            {
                for (int col = 0; col < standardBoard.Board.GetLength(1); col++)
                {
                    System.Console.Write(standardBoard.Board[row, col].Color);
                    System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine(standardBoard.Board[0,0].IsAttacked);
        }
    }
}
