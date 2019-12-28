using EightQueens.Logic;

namespace EightQueens.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(new ConsoleRenderer());
            engine.FindPositionsOfAllQueens(new Position(0, 10));
        }
    }
}
