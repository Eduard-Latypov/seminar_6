//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


const int SIZE = 10;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;
int[] myArray = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
int[] myArray_copy = CopyArray(myArray);
print(myArray);
print(myArray_copy);
int[] new_myArray_copy = myArray[..];
myArray[0] = 2000;
System.Console.WriteLine($"new[{String.Join(", ", new_myArray_copy)}]");

int[] array = Print(myArray);
System.Console.WriteLine($"[{String.Join(", ", array)}]");
int[] FillArray(int SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
    int[] arr = new int[SIZE];
    for (int i = 0; i < SIZE; i++)
    {
        arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE);
    }
    return arr;
}


int[] CopyArray(int[] arr)
{
    int[] myArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        myArray[i] = arr[i];
    }
    return myArray;
}



int[] Print(int[] arr)
{
    int[] myArray = { };
    foreach (var item in arr)
    {
        myArray = myArray.Append(item).ToArray();
    }
    return myArray;
}


void print(int[] arr)
{
    System.Console.WriteLine($"[{String.Join(", ", arr)}]");
}

string text = "hello world";
string str = text[6..];
System.Console.WriteLine(str);




