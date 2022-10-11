using Vakor.MiniMaxAlgorithm.Additional;
using Vakor.MiniMaxAlgorithm.Extensions;
using Vakor.MiniMaxAlgorithm.Mazes;

namespace Vakor.MiniMaxAlgorithm.Games;

public class Game
{
    public int EnemiesCount { get; private set; }
    public Maze Maze { get; set; }
    public Coordinates DestinationPoint { get; set; }
    public Coordinates AllyCoordinate { get; set; }
    public Coordinates[] EnemyCoordinates { get; set; }

    public Game(Maze maze, int enemiesCount)
    {
        Maze = maze;
        EnemiesCount = enemiesCount;
        EnemyCoordinates = new Coordinates[enemiesCount];
    }

    private Game(Maze maze, Coordinates destinationPoint, Coordinates allyCoordinate, Coordinates[] enemyCoordinates)
    {
        Maze = maze;
        DestinationPoint = destinationPoint;
        AllyCoordinate = allyCoordinate;
        EnemyCoordinates = enemyCoordinates;
    }

    public void InitNewGame()
    {
        List<Coordinates> usedCoordinates = new List<Coordinates>();
        usedCoordinates.Add(AllyCoordinate = Maze.GenerateRandomValidCoordinate(usedCoordinates));
        usedCoordinates.Add(DestinationPoint = Maze.GenerateRandomValidCoordinate(usedCoordinates));
        for (int i = 0; i < EnemiesCount; i++)
        {
            usedCoordinates.Add(EnemyCoordinates[i] = Maze.GenerateRandomValidCoordinate(usedCoordinates));
        }
    }
}