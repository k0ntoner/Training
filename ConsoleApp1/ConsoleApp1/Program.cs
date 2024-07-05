
public class Program
{
    public static void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            // обмін елементів
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
    static void Main(string[] args)
    {
        int[] arr = { 6, 7, 1, 4, 10 };
        Program.InsertionSort(arr);
    }
}
