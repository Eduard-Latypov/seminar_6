// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
int positive_num;
print(inputNumber("Введите число!", out positive_num));
System.Console.WriteLine($"Количество введенных положительных чисел: {positive_num}");








int[] inputNumber(string str, out int count)
{
    count = 0;
    int number;
    string text;
    int[] numbers = { };
    System.Console.WriteLine("Наберите \"стоп\" или \"stop\" (регистр не важен) для остановки ввода чисел");
    while (true)
    {
        Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number > 0)
                count += 1;
            numbers = numbers.Append(number).ToArray();
        }
        else if (text.ToLower() == "stop" || text.ToLower() == "стоп")
        {
            return numbers;
        }
        else
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return numbers;

}


void print(int[] arr)
{
    System.Console.WriteLine($"[{String.Join(", ", arr)}]");
}


