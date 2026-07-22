namespace algorithms.console.Insertion;

public class InsertionAtEndImplementation(int[] items, int item) : AlgorithmImplementationBase(items, item)
{
    public override int Execute()
    {
        var result = new int[Items.Length + 1];
        var index = 0;

        while(index < Items.Length) 
        {
            result[index] = Items[index];
            index++;
        }

        result[index] = Item;
        Items = result;

        return 1;
    }
}