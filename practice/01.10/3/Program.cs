Console.WriteLine("Введіть координати точок як х1, у1, х2, у2 по одному в стовпчик: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Довжина вектора становить : " + Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)));
