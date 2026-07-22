using algorithms.console.Sort;

namespace algorithms.console
{
    public static class Helper
    {
        public static int[] GenerateIntArray(int min = 1, int max = 1000, int size = 100) 
        {
            var random = new Random();
            return Enumerable.Range(1, size).Select(_ => random.Next(min, max)).ToArray();
        }

        public static int[] GenerateOrderedIntArray(int min = 1, int max = 1000, int size = 100)
        {
            var result = GenerateIntArray(min, max, size);
            var sort = new InsertionSortImplementation(result);
            sort.Execute();
            return sort.Items;
        }

        public static string ShowElements(int[] array) 
        {
            var stringArray = "";
            var tooLarge = array.Length > 5000;

            var length = tooLarge ? 1000 : array.Length;

            for(int i = 0; i < length; i++) 
                stringArray += array[i] + (array.Length - 1 == i ? "" : ", ");

            stringArray += tooLarge ? "..." : "";

            return stringArray;
        }
    }
}
