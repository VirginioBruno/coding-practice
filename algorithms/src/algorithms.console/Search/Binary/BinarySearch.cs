namespace algorithms.console.Search.Binary
{
    public class BinarySearch
    {
        public static void Do()
        {
            var items = Helper.GenerateOrderedIntArray(1, 1000, 1000);
            var item = 10;

            var exists = items.Any(x => x == item);
            Console.WriteLine($"Executing {nameof(BinarySearchImplementation)} - Finding element {item} in collection with {items.Length} elements - Exists? {exists}");
            var search = new BinarySearchImplementation(items, item);

            var index = AlgorithmExecutor.Execute(search);

            Console.WriteLine($"Executed {nameof(BinarySearchImplementation)} - Element {item} found at index {index}");
        }

        public static void DoRecursive()
        {
            var items = Helper.GenerateOrderedIntArray(1, 1000, 1000);
            var item = 10;

            var exists = items.Any(x => x == item);
            Console.WriteLine($"Executing {nameof(BinarySearchRecursiveImplementation)} - Finding element {item} in collection with {items.Length} - Exists? {exists}");
            var search = new BinarySearchRecursiveImplementation(items, item);

            var index = AlgorithmExecutor.Execute(search);

            Console.WriteLine($"Executed {nameof(BinarySearchRecursiveImplementation)} - Element {item} found at index {index}");
        }
    }
}
