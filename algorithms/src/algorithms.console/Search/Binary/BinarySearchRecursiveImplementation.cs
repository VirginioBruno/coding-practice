namespace algorithms.console.Search.Binary
{
    public class BinarySearchRecursiveImplementation(int[] items, int item) : AlgorithmImplementationBase(items, item)
    {
        public override int Execute()
        {
            var l = 0;
            var r = Items.Length - 1;
            return RecursiveExecute(Items, l, r, Item);
        }

        private int RecursiveExecute(int[] items, int l, int r, int x) 
        {
            //verify index before start algorithm
            if (r >= l)
            {
                // calculate midpoint of array by adding half of the difference between left and right to left
                // getting the difference (r - l) is needed to not cause an int overflow whether right is near to the maximum int possible
                int mid = l + (r - l) / 2;
                
                // if midpoint contains the element just return it
                if (items[mid] == x)
                    return mid;

                // if midpoint value is greater, the element calls the function again redefining the maximum index to the midpoint
                if (items[mid] > x)
                    return RecursiveExecute(items, l, mid - 1, x);

                // if midpoint value is less, the element calls the function again redefining the minimum index to the midpoint    
                return RecursiveExecute(items, mid + 1, r, x);
            }

            // the element is not in the array
            return -1;
        }        
    }
}
