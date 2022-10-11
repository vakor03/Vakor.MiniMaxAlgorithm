using Vakor.MiniMaxAlgorithm.Games;
using Vakor.MiniMaxAlgorithm.Mazes;

Game game = new Game(Maze.GenerateDefaultMaze(), 1);
game.InitNewGame();

Console.WriteLine("The end");