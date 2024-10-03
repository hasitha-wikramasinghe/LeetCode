Console.WriteLine("Application starting");

int[] intArray = { 1, 2, 3, 4 };
double[] doubleArray = { 1.0, 2.0, 3.0, 4.0 };
string[] stringArray = { "one", "two", "three", "four" };

DisplayData(intArray);
DisplayData(doubleArray);
DisplayData(stringArray);

static void DisplayData<T>(T[] array)
{
    foreach (T item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}