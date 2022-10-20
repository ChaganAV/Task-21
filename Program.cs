// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координаты двух точек, сначала А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Тепер координаты точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

int sumTotal = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
Console.WriteLine($"sumTotal: {sumTotal}");

double result = Math.Sqrt(sumTotal);
Console.WriteLine($"Растояние между точнами А({x1},{y1}) и B({x2},{y2}): {result}");