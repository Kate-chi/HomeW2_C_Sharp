Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 1000)
{
    while(num > 1000)
    {
        num /= 10;
    }

    FindThirdNum(num);
}
else if(num > 99)
{
    FindThirdNum(num);
}
else
{
    Console.Write("В вашем числе нет третьей цифры");
}

void FindThirdNum(int a)
{
    Console.WriteLine($"Третья цифра вашего числа = {num % 10}");
}