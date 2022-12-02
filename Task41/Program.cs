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



string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
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