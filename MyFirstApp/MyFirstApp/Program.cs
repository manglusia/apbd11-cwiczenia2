// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");

static double GetAverage(int[]tab)
{
    double sum = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        sum += tab[i]*3;
    }

    return sum / tab.Length;
}

int[]arr = {1,2,3,4,5};
double average = GetAverage(arr);
Console.WriteLine(average);