namespace algorithms.console.Sort;

// Inserts each item in its proper place on the ordered part
public class InsertionSortImplementation(int[] items) : AlgorithmImplementationBase(items)
{
    public override int Execute()
    {
        // Start from the second position (first is considered ordered)
        for (int i = 1; i < Items.Length; i++) 
        {
            var current = Items[i];
            var j = i - 1;

            // If compared item is greater than current, shift compared item to the right
            while (j >= 0 && Items[j] > current)
            {
                Items[j + 1] = Items[j];
                j--;
            }

            // Sets current number to the correct position after shift greater to the right
            Items[j + 1] = current;
        }

        return 1;
    }
}