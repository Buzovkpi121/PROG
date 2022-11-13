Console.WriteLine("Введіть три сторони трикутника");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double p = (a + b + c)/2;
Console.WriteLine("Площа становить: " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));