// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("введите количество чисел");
int n = int.Parse(Console.ReadLine());
                                                                              
int CounterPozitiveNumber(int n1) 
{ 
    int[] array = new int[n1];
    int count = 0;
    for (int i = 0; i < n1; i++)
    {
        Console.WriteLine("введите число");
        array[i] = int.Parse(Console.ReadLine());
        if(array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine($"количество чисел больше нуля: {CounterPozitiveNumber(n)}");