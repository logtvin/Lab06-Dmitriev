int number;
int count = 0;
int count2 = 5;
int secret = 14;

do
{
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
    count++;
    if (number != secret && count < count2)
    {
        if (number < secret)
        {
            Console.WriteLine("Больше");
        }
        else if (number > secret)
        {
            Console.WriteLine("Меньше");
        }
    }
}
while (number != secret && count < count2);
if (number == secret)
{
    Console.WriteLine($"Угадал за: {count} попыток");
}
else
{
    Console.WriteLine($"Не угадал, не осталось попыток. Числом было {secret}");
}