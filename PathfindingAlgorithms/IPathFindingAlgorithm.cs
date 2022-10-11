using Vakor.MiniMaxAlgorithm.Additional;
using Vakor.MiniMaxAlgorithm.Mazes;

namespace Vakor.MiniMaxAlgorithm.PathfindingAlgorithms;

public interface IPathFindingAlgorithm
{
    public int FindPath(Maze maze, Coordinates startPoint, Coordinates destPoint, out List<Coordinates> path);
}