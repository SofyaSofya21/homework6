// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string numbers = ReadString("Введите любое количество чисел через запятую: ");
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    switch (numbers[i])
    {
        case '-':
            i = IndexOfNextComma(numbers, i);
            break;
        case '0':
            i = IndexOfNextComma(numbers, i);
            break;
        case ' ':
            break;
        default:
            count++;
            i = IndexOfNextComma(numbers, i);
            break;
    }
}

Console.WriteLine($"Количество положительных чисел во введенном ряде чисел: {count}.");



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

bool CheckValueInArray(string text, char find)
{
    bool freeOfValue = true;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == find)
        {
            freeOfValue = false;
            break;
        }
    }
    return freeOfValue;
}

string RemoveFromArrayValue(string text, char removeValue)
{
    int i = 0;
    string arrayNew = "";
    int removePosIndex = IndexOf(text, removeValue);
    for (i = 0; i < arrayNew.Length; i++)
    {
        if (i >= removePosIndex)
            arrayNew += text[i + 1];
        else
            arrayNew += text[i];
    }
    return arrayNew;
}

int IndexOf(string array, char find)
{
    int i = 0;
    int position = -1;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            position = i;
            break;
        }
    }
    return position;
}

// долистать до запятой
int IndexOfNextComma (string text, int index)
{
while (text[index] != ',')
            {
                if(index<text.Length-1)
                    index++;
                else
                    break;
            }
return index;
}