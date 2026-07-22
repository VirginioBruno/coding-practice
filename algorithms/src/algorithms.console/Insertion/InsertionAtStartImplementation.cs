namespace algorithms.console.Insertion;

public class InsertionAtStartImplementation(int[] items, int item) : AlgorithmImplementationBase(items, item)
{
    public override int Execute()
    {
        var result = new int[Items.Length + 1];
        var index = 0;

        result[index] = Item;
        index++;

        for(int i = 0; i < Items.Length; i++) 
        {
            result[index] = Items[i];
            index++;
        }

        Items = result;

        return 1;
    }
}