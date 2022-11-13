bool b = true;
string c;
while (b == true) {   
    Console.WriteLine("Введіть початкове значення даних електролічільника");
    int p = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введіть кінцеве значення");
    int k = Convert.ToInt32(Console.ReadLine());
    if (k-p <= 250 & k-p>=0)
    {
        Console.WriteLine("До сплати"+(k-p)*1.44+" грн");
    }
    else if (k-p>250)
    {
        Console.WriteLine("До сплати" + (((k - p - 250) * 1.68 + 250*1.44)) +" грн");
    }
    else
    {
        Console.WriteLine("Не крути лічильник!");
    }
    Console.WriteLine("Бажаєте продовжити? Введіть \"N\", якщо хочете завершити");
    c = Console.ReadLine();
    if (c == "N")
    {
        b = false;
    }

}
//2 zadacha//
Console.WriteLine("\n\nВведіть Номер місяця");
byte a = Convert.ToByte(Console.ReadLine());
if (a==12 || a==1 || a == 2)
{
    Console.WriteLine("Зима");
}
if (a == 3 || a == 5 || a == 4)
{
    Console.WriteLine("Весна");
}
if (a == 6 || a == 8 || a == 7)
{
    Console.WriteLine("Літо");
}
if (a == 9 || a == 10 || a == 11)
{
    Console.WriteLine("Осінь");
}