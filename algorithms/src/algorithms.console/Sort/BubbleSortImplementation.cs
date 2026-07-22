namespace algorithms.console.Sort;

public class BubbleSortImplementation(int[] items) : AlgorithmImplementationBase(items)
{
    public override int Execute()
    {
        for (int i = 0; i < Items.Length - 1; i++)
        {
            var hasSwap = false;

            for (int j = 0; j < Items.Length - i - 1; j++)
            {
                if (Items[j] > Items[j + 1]) 
                {
                    (Items[j + 1], Items[j]) = (Items[j], Items[j + 1]);
                    hasSwap = true;
                }
            }

            if (!hasSwap)
                break;
        }

        return 1;
    }
}