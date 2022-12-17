// Вам дан массив (который будет иметь длину не менее 3, но может быть очень большим), содержащий целые числа. Массив либо полностью состоит из нечетных целых чисел, либо полностью состоит из четных целых чисел, за исключением одного целого числа N. Напишите метод, который принимает массив в качестве аргумента и возвращает этот «выброс» N.

// [2, 4, 0, 100, 4, 11, 2602, 36]
// Should return: 11 

// [160, 3, 1719, 19, 11, 13, -21]
// Should return: 160

// int[] sorted_rev = myList.OrderByDescending(i => i).ToArray(); 

// int func(int[] nums)
// {
//     int count_even = 0, count_odd = 0, index_even = 0, index_odd = 0;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         if (nums[i] % 2 == 0)
//         {
//             count_even += 1;
//             index_even = i;
//         }
//         else
//         {
//             count_odd += 1;
//             index_odd = i;
//         }

//     }
//     if (count_even == 1)
//         return nums[index_even];
//     return nums[index_odd];

// }
// int[] arr = { 160, 3, 1719, 19, 11, 13, -21 };
// System.Console.WriteLine(func(arr));





// На этот раз ни истории, ни теории. В приведенных ниже примерах показано, как написать функцию accum:

// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"


// string Accum(string s)
// {
//     string text = Convert.ToString(s[0]).ToUpper();
//     for (int i = 1; i < s.Length; i++)
//     {
//         text += "-";
//         text = text + Convert.ToString(s[i]).ToUpper() + string.Concat(Enumerable.Repeat(Convert.ToString(s[(i)]).ToLower(), (i)));

//     }
//     return text;
// }

// System.Console.WriteLine(Accum("abcd"));



// Вам будет дан массив целых чисел. Ваша задача состоит в том, чтобы взять этот массив и найти индекс N, где сумма целых чисел слева от N равна сумме целых чисел справа от N. Если нет такого индекса, который мог бы это сделать, верните - 1. Например: Допустим, вам дан массив {1,2,3,4,3,2,1}: Ваша функция вернет индекс 3, потому что на 3-й позиции массива сумма левой части индекса ({1,2,3}) и сумма правой части индекса ({3,2, 1}) оба равны 6. Давайте посмотрим на другой. Вам дан массив {1,100,50,-51,1,1}: Ваша функция вернет индекс 1, потому что в 1-й позиции массива сумма левой части индекса ({1}) и сумма правой части индекса ({50,-51,1,1 }) оба равны 1. Последний: Вам дан массив {20,10,-80,10,10,15,35} В индексе 0 левая сторона {} Правая сторона {10,-80,10,10,15,35} Они оба равны 0 при сложении. (Пустые массивы равны 0 в этой задаче) Индекс 0 — это место, где левая и правая стороны равны.


// int FindEvenIndex(int[] arr)
// {
//     int result = -1;
//     if (arr.Length == 0 || arr[1..].Sum() == 0)
//     {
//         result = 0;
//     }
//     else
//     {
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[..i].Sum() == arr[(i + 1)..].Sum())
//             {
//                 result = i;
//                 break;
//             }
//         }
//     }
//     return result;
// }
// int[] myArray = { 20, 10, -80, 10, 10, 15, 35 };
// System.Console.WriteLine(FindEvenIndex(myArray));



// Нарциссическое число (или число Армстронга) — это положительное число, представляющее собой сумму собственных цифр, каждая из которых возведена в степень количества цифр в данном основании. В этом Ката мы ограничимся десятичными числами (с основанием 10). Например, возьмем 153 (3 цифры), что является самовлюбленным: 1^3 5^3 3^3 = 1 + 125 + 27 = 153 или 1652 (4 цифры), что не является: 1^4 6^4 5^4 2^4 = 1 + 1296 + 625 + 16 = 1938

// bool Narcissistic(int value)
// {
//     int num = value;
//     int len = Convert.ToString(value).Length;
//     int result = 0;
//     for (int i = 1; i < len; i++)
//     {
//         result = result + (int)Math.Pow((value % 10), len);
//         value = value / 10;
//     }
//     result = result + (int)Math.Pow(value, len);
//     return (result == num);
// }

// System.Console.WriteLine(Narcissistic(153));

// char[] letters = { 'A', 'B', 'C' };
// string alphabet = new string(letters);
// System.Console.WriteLine(alphabet);
// string text = "pregnant";
// for (int i = 0; i < text.Length; i++)
// {
//     System.Console.Write(text[(text.Length - 1) - i]);
// }

// string x = "ZX Spectrum";
// x = x.Remove(2, 1);
// x = x.Insert(2, "-");
// Console.WriteLine(x);
// x = x.Remove(1, 1);
// x = x.Insert(1, "W");
// System.Console.WriteLine(x);
// x = x.Remove(5);
// System.Console.WriteLine(x);

// string text_1 = "pRivet";
// string text_2 = "gIv";
// if (text_1.ToLower().Contains(text_2.ToLower()))
//     System.Console.WriteLine("yes");
// else
//     System.Console.WriteLine("no");


// Даны два массива строк a1 и a2, которые возвращают отсортированный массив r в лексикографическом порядке строк a1, которые являются подстроками строк a2. 
//Пример 1: a1 = ["арп", "живой", "сильный"] a2 = ["живой", "живой", "арфа", "резкий", "армстронг"] возвращает ["arp", "live", "strong"] 
//Пример 2: a1 = ["брезент", "мыши", "бык"] a2 = ["живой", "живой", "арфа", "резкий", "армстронг"] возвращает []




// string[] inArray(string[] array1, string[] array2)
// {
//     string[] arr = { };
//     for (int i = 0; i < array1.Length; i++)
//     {
//         for (int j = 0; j < array2.Length; j++)
//         {
//             if (array2[j].Contains(array1[i]))
//             {
//                 arr = arr.Append(array1[i]).ToArray();
//                 break;
//             }
//         }
//     }
//     Array.Sort(arr);
//     return arr;
// }


// string[] array = { "arp", "live", "strong" };
// string[] array2 = { "lively", "alive", "harp", "sharp", "armstrong" };
// string[] new_array = inArray(array, array2);
// foreach (var item in new_array)
// {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine(new_array.Length);



// int[] arr = { };
// for (int i = 1; i < 10; i++)
// {
//     arr = arr.Append(i).ToArray();
// }
// foreach (var item in arr)
// {
//     System.Console.WriteLine(item);
// }


// АХРЕНЕННАЯ ЗАДАЧА!!!!!!!


// В супермаркете очередь к кассам самообслуживания. Ваша задача — написать функцию для расчета общего времени, необходимого всем покупателям для оформления заказа! вход клиенты: массив положительных целых чисел, представляющих очередь. Каждое целое число представляет покупателя, а его значение — количество времени, которое ему требуется для оформления заказа. n: положительное целое число, количество касс. выход Функция должна возвращать целое число — общее требуемое время.
// Важный Пожалуйста, ознакомьтесь с примерами и пояснениями ниже, чтобы убедиться, что вы правильно поняли задачу :)
// время очереди([5,3,4], 1) должно вернуть 12 потому что, когда есть 1 касса, общее время равно сумме времен время очереди([10,2,3,3], 2) должно вернуть 10 потому что здесь n=2 и 2-й, 3-й и 4-й люди в очередь заканчивается до того, как закончит 1-й человек. время очереди([2,3,10], 2) должно вернуть 12
// Уточнения Существует только ОДНА очередь, обслуживающая множество касс, и Порядок очереди НИКОГДА не меняется, и Первый человек в очереди (то есть первый элемент в массиве/списке) переходит к кассе, как только она освобождается. Н.Б. Вы должны предположить, что все входные данные теста будут действительными, как указано выше. P.S. Ситуацию в этом ката можно сравнить с идеей пула потоков, более связанной с информатикой, в отношении одновременного запуска нескольких процессов.



// int QueueTime(int[] customers, int n)
// {
//     int[] time = new int[n];
//     for (int i = 0; i < customers.Length; i++)
//     {
//         int min_idx = Array.IndexOf(time, time.Min());
//         time[min_idx] += customers[i];
//     }
//     return time.Max();
// }


// int[] people = { 5, 3, 4 };
// int result = QueueTime(people, 2);
// System.Console.WriteLine(result);








// Решение в группах задач:
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.





int num_1 = inputNumber("Введите 1-ое число: ");
int num_2 = inputNumber("Введите 2-ое число: ");
int num_3 = inputNumber("Введите 3-ое число: ");
func(num_1, num_2, num_3);




void func(int num_1, int num_2, int num_3)
{
    if ((num_1 > (num_2 + num_3)) || (num_2 > (num_1 + num_3)) || (num_3 > (num_1 + num_2)))
        System.Console.WriteLine("Треугольника с такими сторонами не существует!");
    else
        System.Console.WriteLine("Есть такой треугольник!");
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



