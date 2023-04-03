public static class Sorting
{
    public static int[] SortCounting(this int[] collection)
    {
        int size = collection.Length;

        int max = collection[0];
        for (int i = 1; i < size; i++)
            if (collection[i] > max) max = collection[i];

        int min = collection[0];
        for (int i = 1; i < size; i++)
            if (collection[i] < min) min = collection[i];
        
        Console.WriteLine(min);
        Console.WriteLine(max);

        int ofset = - min;

        int[] counter = new int[max + 1 + ofset];

        for (int i = 0; i < size; i++)
            counter[collection[i] + ofset]++;
        Console.WriteLine($"counter = [{String.Join(' ', counter)}]");
        int index = 0;
        for (int i = 0; i < max + 1 + ofset; i++)
            for (int j = 0; j < counter[i]; j++)
                collection[index++] = i - ofset;

        return collection;
    }
}