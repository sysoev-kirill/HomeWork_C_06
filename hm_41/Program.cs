// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа через запятые: ");
string text = Console.ReadLine();
int[] array = text.Split(',').Select(int.Parse).ToArray();

int GetPositiveNum(int[] arr)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > 0) count++;
   }
   return count;
}

int result = GetPositiveNum(array);
Console.WriteLine($"{text} -> {result}");