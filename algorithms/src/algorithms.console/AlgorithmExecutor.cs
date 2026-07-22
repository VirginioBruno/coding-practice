using System.Diagnostics;

namespace algorithms.console
{
    public static class AlgorithmExecutor
    {
        public static int Execute(IAlgorithmImplementation algorithm) 
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var result = algorithm.Execute();

            stopWatch.Stop();

            Console.WriteLine($"Elapsed time: {stopWatch.Elapsed}");

            return result;
        }
    }
}
