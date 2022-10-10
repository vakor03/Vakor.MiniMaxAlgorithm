using Vakor.MiniMaxAlgorithm.Additional;

namespace Vakor.MiniMaxAlgorithm.Mazes;

public class Maze
{
    private int[,] _matrix;

    public int this[int x, int y] => _matrix[x, y];
    public int this[Coordinates coordinates] => _matrix[coordinates.X, coordinates.Y];

    public int Height => _matrix.GetLength(0);
    public int Width => _matrix.GetLength(1);

    private Maze(int[,] matrix)
    {
        _matrix = matrix;
    }

    public static Maze GenerateDefaultMaze() => new Maze(new[,]
    {
        { 1, 1, 1, 1, 1, 1, 1 },
        { 1, 1, 1, 0, 1, 1, 1 },
        { 1, 1, 1, 0, 1, 1, 1 },
        { 1, 1, 1, 0, 1, 1, 1 },
        { 1, 1, 1, 1, 1, 1, 1 },
    });
}