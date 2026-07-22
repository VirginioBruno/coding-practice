namespace algorithms.console.Sort;

public static class Sort
{
    public static void DoBubbleSort() 
    {
        var items = Helper.GenerateIntArray(1, 20, 20);
    
        Console.WriteLine($"Executing {nameof(Sort)} - {nameof(DoBubbleSort)} Sorting {items.Length} elements ({Helper.ShowElements(items)})");
        var bubbleSort = new BubbleSortImplementation(items);

        var result = AlgorithmExecutor.Execute(bubbleSort);

        Console.WriteLine($"Executed {nameof(Sort)} - {nameof(DoBubbleSort)} - {Helper.ShowElements(items)}");
    }

    public static void DoSelectionSort() 
    {
        var items = Helper.GenerateIntArray(1, 20, 20);
    
        Console.WriteLine($"Executing {nameof(Sort)} - {nameof(DoSelectionSort)} Sorting {items.Length} elements ({Helper.ShowElements(items)})");
        var selectionSort = new SelectionSortImplementation(items);

        var result = AlgorithmExecutor.Execute(selectionSort);

        Console.WriteLine($"Executed {nameof(Sort)} - {nameof(DoSelectionSort)} - {Helper.ShowElements(items)}");
    }

     public static void DoInsertionSort() 
    {
        var items = Helper.GenerateIntArray(1, 200000, 100000);
    
        Console.WriteLine($"Executing {nameof(Sort)} - {nameof(DoInsertionSort)} Sorting {items.Length} elements ({Helper.ShowElements(items)})");
        var insertionSort = new InsertionSortImplementation(items);

        var result = AlgorithmExecutor.Execute(insertionSort);

        Console.WriteLine($"Executed {nameof(Sort)} - {nameof(DoInsertionSort)} - {Helper.ShowElements(items)}");
    }
}