Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 6)
{
    Console.Write("Введенный день является рабочим :(");
}
else if(num > 7)
{
    Console.Write("Упс, вы ввели неверный день");
}
else
{
    Console.Write("Введенный день является выходным :)");
}