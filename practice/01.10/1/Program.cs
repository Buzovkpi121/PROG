Console.WriteLine("Введіть 4 числа через 'Enter' у стовпчик ");
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int a3 = Convert.ToInt32(Console.ReadLine());
int a4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мінімальне число: " + Math.Min(a1, Math.Min(a2, Math.Min(a3, a4))));
