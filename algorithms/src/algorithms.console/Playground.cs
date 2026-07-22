namespace algorithms.console;

public static class Playground
{
    public static void Do() 
    {
        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("---------------------------------------------- Executing Playground -------------------------------------------------");

        var array = Helper.GenerateIntArray(1, 30, 30);
        Console.WriteLine($"Playing with: {Helper.ShowElements(array)}");
        
        Play(array);

        Console.WriteLine($"Output: {Helper.ShowElements(array)}");
    }

    private static void Play(int[] array) 
    {
       for (var i = 1; i < array.Length; i++)
       {
            var current = array[i];
            var j = i - 1;

            while (j >= 0 && array[j] > current) 
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = current;
       }
    }
}