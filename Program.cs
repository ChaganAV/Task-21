// See https://aka.ms/new-console-template for more information
int[] A = GetArray("Введите три координаты точки А: ");
int[] B = GetArray("Введите три координаты точки B: ");

int sumTotal = (B[0]-A[0])*(B[0]-A[0])+(B[1]-A[1])*(B[1]-A[1])+(B[2]-A[2])*(B[2]-A[2]);
Console.WriteLine($"sumTotal: {sumTotal}");

double result = Math.Sqrt(sumTotal);
Console.WriteLine($"Растояние между точнами А({A[0]},{A[1]},{A[2]}) и B({B[0]},{B[1]},{B[2]}): {result}");

int[] GetArray (string message)
{
    int[] intArray = new int[3];
    Console.WriteLine(message);
    for (int i = 0; i < 3; i++)
        intArray[i] = Convert.ToInt32(Console.ReadLine());
    return intArray;
}