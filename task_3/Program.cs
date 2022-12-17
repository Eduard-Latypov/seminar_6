


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8





Console.Clear();
int num_1 = 0, num_2 = 1;
int temp;
int num = inputNumber("Введите число: ");

for (int i = 0; i < num; i++)
{
    System.Console.Write(num_1 + " ");
    temp = num_1;
    num_1 = num_2;
    num_2 = temp + num_2;

}









int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}