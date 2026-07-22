using algorithms.console;
using algorithms.console.Insertion;
using algorithms.console.Search.Binary;
using algorithms.console.Search.Linear;
using algorithms.console.Sort;

namespace CodingPractice.Tests;

public class AlgorithmsTests
{
    [Fact]
    public void SortingAlgorithms_OrderItemsAscending()
    {
        var expected = new[] { -2, 0, 1, 3, 3, 8 };
        var algorithms = new AlgorithmImplementationBase[]
        {
            new BubbleSortImplementation([3, -2, 8, 3, 0, 1]),
            new SelectionSortImplementation([3, -2, 8, 3, 0, 1]),
            new InsertionSortImplementation([3, -2, 8, 3, 0, 1])
        };

        foreach (var algorithm in algorithms)
        {
            algorithm.Execute();
            Assert.Equal(expected, algorithm.Items);
        }
    }

    [Fact]
    public void SearchAlgorithms_FindBoundaryItemsAndReturnMinusOneWhenMissing()
    {
        int[] items = [1, 3, 5, 7, 9];

        Assert.Equal(0, new BinarySearchImplementation(items, 1).Execute());
        Assert.Equal(4, new BinarySearchImplementation(items, 9).Execute());
        Assert.Equal(-1, new BinarySearchImplementation(items, 6).Execute());
        Assert.Equal(4, new BinarySearchRecursiveImplementation(items, 9).Execute());
        Assert.Equal(2, new LinearSearchImplementation(items, 5).Execute());
        Assert.Equal(-1, new LinearSearchImplementation(items, 6).Execute());
    }

    [Fact]
    public void InsertionAlgorithms_InsertAtStartPositionAndEnd()
    {
        var atStart = new InsertionAtStartImplementation([2, 3], 1);
        var atPosition = new InsertionAtPositionImplementation([1, 3], 2, 1);
        var atEnd = new InsertionAtEndImplementation([1, 2], 3);

        atStart.Execute();
        atPosition.Execute();
        atEnd.Execute();

        Assert.Equal([1, 2, 3], atStart.Items);
        Assert.Equal([1, 2, 3], atPosition.Items);
        Assert.Equal([1, 2, 3], atEnd.Items);
    }

    [Fact]
    public void InsertionAtPosition_RejectsAnInvalidIndex()
    {
        var insertion = new InsertionAtPositionImplementation([1, 2], 3, 3);

        Assert.Throws<ArgumentOutOfRangeException>(() => insertion.Execute());
    }
}
