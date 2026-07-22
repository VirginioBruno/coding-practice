namespace algorithms.console.Search.Linear
{
    public static class LinearSearch
    {
        public static void Do() 
        {
            var items = Helper.GenerateIntArray(1, 1000, 1000);
            var item = 10;
        
            Console.WriteLine($"Executing {nameof(LinearSearch)} - Finding element {item} in collection with {items.Length} elements - Exists? {items.Any(x => x == item)}");
            var linearSearch = new LinearSearchImplementation(items, item);

            var index = AlgorithmExecutor.Execute(linearSearch);

            Console.WriteLine($"Executed {nameof(LinearSearch)} - Element {item} found at index {index}");
        }
    }
}
