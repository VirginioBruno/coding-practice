namespace algorithms.console.Insertion
{
    public static class Insertion
    {
        public static void DoInsertionAtEnd() 
        {
            var items = Helper.GenerateIntArray(1, 20, 20);
            var item = 21;
        
            Console.WriteLine($"Executing {nameof(Insertion)} - {nameof(DoInsertionAtEnd)} Inserting element {item} in collection with {items.Length} elements");
            var insertionAtEnd = new InsertionAtEndImplementation(items, item);

            var result = AlgorithmExecutor.Execute(insertionAtEnd);

            Console.WriteLine($"Executed {nameof(Insertion)} - {nameof(DoInsertionAtEnd)} Element {item} at index {Array.FindIndex(insertionAtEnd.Items, x => x == item)}");
        }

        public static void DoInsertionAtStart() 
        {
            var items = Helper.GenerateIntArray(1, 20, 20);
            var item = 111;
        
            Console.WriteLine($"Executing {nameof(Insertion)} - {nameof(DoInsertionAtStart)} Inserting element {item} in collection with {items.Length} elements");
            var insertionAtStart = new InsertionAtStartImplementation(items, item);

            var result = AlgorithmExecutor.Execute(insertionAtStart);

            Console.WriteLine($"Executed {nameof(Insertion)} - {nameof(DoInsertionAtStart)} Element {item} at index {Array.FindIndex(insertionAtStart.Items, x => x == item)}");
        }

        public static void DoInsertionAtPosition() 
        {
            var items = Helper.GenerateIntArray(1, 20, 20);
            var item = 222;
            var position = 21;
        
            Console.WriteLine($"Executing {nameof(Insertion)} - {nameof(DoInsertionAtPosition)} Inserting element {item} at index {position} in collection with {items.Length} elements");
            var insertionAtPosition = new InsertionAtPositionImplementation(items, item, position);

            var result = AlgorithmExecutor.Execute(insertionAtPosition);

            Console.WriteLine($"Executed {nameof(Insertion)} - {nameof(DoInsertionAtPosition)} Element {item} at index {Array.FindIndex(insertionAtPosition.Items, x => x == item)}");
        }
    }
}
