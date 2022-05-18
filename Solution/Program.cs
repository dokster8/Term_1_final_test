// Написать программу, которая из имеющегося массива строк фомирует массив их строк, 
// длина которых меньше либо равна 3 символа.

int vvodChisla(string uslovieVvoda)
{
    int number = 0;
    Console.Write(uslovieVvoda);
    if (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Введите целое число! По умолчанию установлено значение 0.");
    }
    return number;
}

int razmer(string[] array, int s)
{
    int i = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k].Length < s) i++;
    }
    return i;
}

string[] araryFilter(string[] oldArray, int newArrayLength, int s)
{
    int count = 0;
    string[] newArray = new string[newArrayLength];
    for (int p = 0; p < oldArray.Length; p++)
    {
        if (oldArray[p].Length < s)
        {
            newArray[count] = oldArray[p];
            count++;
        }
    }
    return newArray;
}

string[] zapolnenieMassiva(string[] emptyArray)
{
    for (int m = 0; m < emptyArray.Length; m++)
    {
        Console.Write($"Введите {m + 1} элемент массива: ");
        emptyArray[m] = Console.ReadLine();
    }
    return emptyArray;
}

int parametr = vvodChisla("Введите искомый предел строки: ");
int n = vvodChisla("Введите планируемый размер массива: ");
string[] massStrok = new string[n];
massStrok = zapolnenieMassiva(massStrok);
// Console.WriteLine(araryFilter(massStrok, razmer(massStrok, n), parametr).Length);
Console.WriteLine(String.Join(", ", araryFilter(massStrok, razmer(massStrok, n), parametr)));