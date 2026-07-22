using algorithms.console;
using algorithms.console.Insertion;
using algorithms.console.Search.Binary;
using algorithms.console.Search.Linear;
using algorithms.console.Sort;

var isPlayground = true;

if (isPlayground) 
{
    Playground.Do();
    return;
}

Console.WriteLine("Algorithms Project");

Console.WriteLine("\n\n");

Console.WriteLine("------------- Insertion Algorithms -------------");

Insertion.DoInsertionAtPosition();
Insertion.DoInsertionAtStart();
Insertion.DoInsertionAtEnd();

Console.WriteLine("\n\n");

Console.WriteLine("------------- Search Algorithms -------------");

LinearSearch.Do();
BinarySearch.Do();
BinarySearch.DoRecursive();

Console.WriteLine("\n\n");

Console.WriteLine("------------- Sort Algorithms -------------");
Sort.DoBubbleSort();
Sort.DoSelectionSort();
Sort.DoInsertionSort();


