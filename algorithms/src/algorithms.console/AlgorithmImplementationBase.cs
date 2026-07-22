namespace algorithms.console
{
    public abstract class AlgorithmImplementationBase(int[] items, int item = 0, int index = 0) : IAlgorithmImplementation
    {
        public int[] Items { get; set; } = items;
        public int Item { get; set; } = item;
        public int Index { get; set; } = index;

        public abstract int Execute();
    }
}
