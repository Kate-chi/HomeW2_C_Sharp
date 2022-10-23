Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int secondNum = num / 10 % 10;

Console.WriteLine($"Вторая цифра числа {num} = {secondNum}");