namespace algorithms.console.Sort;

public class SelectionSortImplementation(int[] items) : AlgorithmImplementationBase(items)
{
    public override int Execute()
    {
        for (int i = 0; i < Items.Length; i++)
        {
            var minimumValueIndex = i;

            for (int j = i; j < Items.Length; j++)
            {
                if (Items[j] < Items[minimumValueIndex]) 
                    minimumValueIndex = j;
            }

            if (minimumValueIndex != i) 
                (Items[minimumValueIndex], Items[i]) = (Items[i], Items[minimumValueIndex]);
        }

        return 1;
    }
}