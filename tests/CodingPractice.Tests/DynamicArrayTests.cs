using data.structures.console.Collections;

namespace CodingPractice.Tests;

public class DynamicArrayTests
{
    [Fact]
    public void Add_GrowsBeyondInitialCapacityAndPreservesOrder()
    {
        var array = new DynamicArray<int>();

        for (var item = 0; item < 25; item++)
            array.Add(item);

        Assert.Equal(25, array.Count);
        Assert.Equal(Enumerable.Range(0, 25), array);
    }

    [Fact]
    public void Remove_RemovesFirstMatchAndShiftsRemainingItems()
    {
        var array = new DynamicArray<string>();
        array.Add("alpha");
        array.Add("beta");
        array.Add("gamma");

        array.Remove("beta");

        Assert.Equal(2, array.Count);
        Assert.Equal(["alpha", "gamma"], array);
    }

    [Fact]
    public void Remove_DoesNotChangeCollectionWhenItemIsMissing()
    {
        var array = new DynamicArray<int>();
        array.Add(1);
        array.Add(2);

        array.Remove(99);

        Assert.Equal(2, array.Count);
        Assert.Equal([1, 2], array);
    }

    [Fact]
    public void Constructor_RejectsNegativeCapacity()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new DynamicArray<int>(-1));
    }
}
