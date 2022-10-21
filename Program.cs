// See https://aka.ms/new-console-template for more information
int[] A = GetArray("Введите три координаты точки А: ");
int[] B = GetArray("Введите три координаты точки B: ");

int sumTotal = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
Console.WriteLine($"sumTotal: {sumTotal}");

double result = Math.Sqrt(sumTotal);
Console.WriteLine($"Растояние между точнами А({x1},{y1}) и B({x2},{y2}): {result}");

int[] GetArray (string message)
{
    int[] intArray = new int[3];
    Console.WriteLine(message);
    for (int i = 0; i < 3; i++)
        intArray[i] = Convert.ToInt32(Console.ReadLine());
    return intArray;
}