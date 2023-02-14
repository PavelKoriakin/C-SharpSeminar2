int Prompt(string msg)
{
    System.Console.Write($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int del = Prompt("Введите делитель  ");
int num = Prompt("Введите число  ");
int ost = num % del;
if(ost == 0)
{
    System.Console.WriteLine($"{num} является кратным числу {del}");
}
else
{
    System.Console.WriteLine($"{num} не кратное {del}, остаток равен {ost}");
}
