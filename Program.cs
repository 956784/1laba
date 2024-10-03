using System;
class Program
{
    static void Main(string[] args)
    {
        int stop = 1000;
        int min = 0;
        int min21 = 0;
        int min3 = 0;
        int min7 = 0;
        Random random = new Random();
        int[] numbers = new int[stop]; // Массив для хранения 1000 чисел
        // Заполняем массив случайными числами от 0 до 10000
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 10001); // Генерируем число от 0 до 10000 включительно
        }
        for (int i = 0; i < numbers.Length; i++) // Обходим все числа в массиве
        {
            if (numbers[i] < min)
            {
                min = numbers[i]; // Поиск минимального числа в массиве случайных чисел
            }
            if (numbers[i] < min21 && numbers[i] % 21 == 0)
            {
                min21 = numbers[i]; // Поиск минимального числа среди кратных 21
            }
            if (numbers[i] < min7 && numbers[i] % 7 == 0)
            {
                min7 = numbers[i]; // Поиск минимального числа среди кратных 7
            }
            if (numbers[i] < min3 && numbers[i] % 3 == 0)
            {
                min3 = numbers[i]; // Поиск минимального числа среди кратных 3
            }
        }
        int multi1 = min * min21; // Произведение минимального числа и минимального среди кратных 21 (первый случай)
        int multi2 = min3 * min7; // Произведение минимального числа среди кратных 3 и минимального среди кратных 7 (второй случай)
        if (multi1 > 0 && multi2 > 0) // Проверка наличия нужных значений
        {
            if (multi1 < multi2) // Выявление минимального числа из подходящих по условию значений R
            {
                Console.WriteLine($"Нужное число R: " + multi1); // Если первое значение меньше, то оно будет подходящим и выведется на экран
            }
            else
            {
                Console.WriteLine($"Нужное число R: " + multi2); // Иначе выведется второе значение
            }
        }
        else
        {
            Console.WriteLine(-1); // Если подходящих значенией нет, то выведется -1
        }
    }
}
