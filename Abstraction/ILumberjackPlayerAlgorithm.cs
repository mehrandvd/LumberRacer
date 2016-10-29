using System.Drawing;

namespace LumberRacer
{
    public interface ILumberjackPlayerAlgorithm
    {
        void StartGame(ILumberjackWorld world);
        void StopGame();
        IAlgorithmConfig AlgorithmConfig { get; }
        Image RequestedMonitorImage { get; }
        bool IsGameStarted { get; set; }
        bool IsGameFound { get; set; }
        bool IsPlayStarted { get; set; }
        int CommandCount { get; set; }
    }
}