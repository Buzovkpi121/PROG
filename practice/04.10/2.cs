Console.WriteLine("Введіть значення температури води: ");
double a1 = Convert.ToDouble(Console.ReadLine());
if (a1 == 100)
{
    Console.WriteLine("Рідкий або газоподібний");
}
else if (a1 == 0)
{
    Console.WriteLine("Рідкий або твердий");
}
else if (a1 < 0)
{
    Console.WriteLine("Твердий");
}
else if (0 < a1 & a1 < 100)
{
    Console.WriteLine("Рідкий");
}
else
{
    Console.WriteLine("Газоподібний");
}