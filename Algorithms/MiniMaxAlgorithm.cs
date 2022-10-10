using Vakor.MiniMaxAlgorithm.Additional;

namespace Vakor.MiniMaxAlgorithm.Algorithms;

public class MiniMaxAlgorithm : IAlgorithm
{
    private int _maxDepth = 4;

    public MiniMaxAlgorithm(int maxDepth)
    {
        _maxDepth = maxDepth;
    }

    public MiniMaxAlgorithm()
    {
    }

    public int Minimax(Node currentPosition, int depth, bool maximizingPlayer)
    {
        if (depth ==0 || currentPosition.GameIsOver)
        {
            return currentPosition.GetEvaluation();
        }

        if (maximizingPlayer)
        {
            int maxEvaluation = Int32.MinValue;
            foreach (var child in currentPosition.GetChildren())
            {
                int evaluation = Minimax(child, depth - 1, false);
                maxEvaluation = Math.Max(maxEvaluation, evaluation);
            }

            return maxEvaluation;
        }
        else
        {
            int minEvaluation = Int32.MinValue;
            foreach (var child in currentPosition.GetChildren())
            {
                int evaluation = Minimax(child, depth - 1, false);
                minEvaluation = Math.Min(minEvaluation, evaluation);
            }

            return minEvaluation;
        }
    }
}

public class Node
{
    public bool GameIsOver => false;
    public int GetEvaluation() => 1;
    public Node[] GetChildren() => new[] { new Node() };
}