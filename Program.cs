
string[] origArray = GetStringArray();
int count = HowManyLessThanTreeLetters(origArray);
//Console.WriteLine(count);
string[] newArray = LessThanTreeLettersPartArray(origArray, count);
Console.WriteLine($"[{String.Join(", ", origArray)}] -> [{String.Join(", ", newArray)}]");




string[] GetStringArray()
{
    Console.WriteLine("Сколько слов будет в массиве?");
    int strLength = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите слова: ");
    string[] originArray = new string[strLength];
    for (int i = 0; i < strLength; i++)
    {
        originArray[i] = Console.ReadLine()!;
    }
    return originArray;
}

int HowManyLessThanTreeLetters(string[] originArray)
{
    int count = 0;
    for (int i = 0; i < originArray.Length; i++)
    {
        if (originArray[i].Length <4)
        {
            count++;
        }
    }
    return count;
}

string[] LessThanTreeLettersPartArray(string[] originArray, int newLenght)
{
    string[] newPartArray = new string[newLenght];
    int k = 0;
    for (int i = 0; i < originArray.Length; i++)
    {
        if (originArray[i].Length <= 3)
        {
            newPartArray[k] = originArray[i];
            k++;
        }
    }
    return newPartArray;
}

