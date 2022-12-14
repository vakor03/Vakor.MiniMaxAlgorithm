using Vakor.MiniMaxAlgorithm.Additional;
using Vakor.MiniMaxAlgorithm.Mazes;

namespace Vakor.MiniMaxAlgorithm.Extensions;

public static class ExtensionMethods
{
    public static void PrintMazeBeautiful(this Maze maze)
    {
        for (int j = 0; j < maze.Width + 2; j++)
        {
            Console.Write("■");
        }

        Console.WriteLine();

        for (int i = 0; i < maze.Height; i++)
        {
            Console.Write("■");
            for (int j = 0; j < maze.Width; j++)
            {
                Console.Write(maze[i, j] == 0 ? "■" : "·");
            }

            Console.WriteLine("■");
        }

        for (int j = 0; j < maze.Width + 2; j++)
        {
            Console.Write("■");
        }

        Console.WriteLine();
    }

    public static Coordinates GenerateRandomValidCoordinate(this Maze maze, IEnumerable<Coordinates> usedCoordinates)
    {
        Random random = new Random();
        Coordinates randomCoordinates = new Coordinates(random.Next(0, maze.Height), random.Next(0, maze.Width));
        while (!maze.CheckCoordinatesForValid(randomCoordinates)  || usedCoordinates.Any(coords=>coords.Equals(randomCoordinates)))
        {
            randomCoordinates = new Coordinates(random.Next(0, maze.Height), random.Next(0, maze.Width));
        }

        return randomCoordinates;
    }
}