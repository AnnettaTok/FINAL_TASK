/*
Необходимо написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равано 3 символам. 
Пепрвоначальный массив можно ввести с клавиатуры, либо задть на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллециями, лучше обойтись исключительно массивами.

Примеры:
[hello, 2, world, :-)] --> [2, :-)]
[1234, 1567, -2, computer science] -->  [-2]
[Russia, Denmark, Kazan] --> []

*/

int ArrayLen(string[] array)
{
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) count++;
        }
        return count;
    }
}

string[] GenerateNewArray(string[] array, int count)
{
    string[] newArray = new string[count];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newArray.Length - count] = array[i];
            count--;
        }
    }
    return newArray;
}

void Printarray(string[] array, int number)
{
    System.Console.WriteLine("Исходный массив: " + "[{0}]", string.Join(", ", array));
    System.Console.WriteLine("Итоговый массив: " + "[{0}]", string.Join(", ", GenerateNewArray(array, number)));
}


string[] strarray = { "hello", "2", "world", ":-)" };
string[] strarray2 = { "1234", "1567", "-2", "computer science", };
string[] strarray3 = { "Russia", "Denmark", "Kazan" };


int arrLen = ArrayLen(strarray);
Printarray(strarray, arrLen);
int arrLen2 = ArrayLen(strarray2);
Printarray(strarray2, arrLen2);
int arrLen3 = ArrayLen(strarray3);
Printarray(strarray3, arrLen3);