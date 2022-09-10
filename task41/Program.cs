// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("введите числа через пробел");
string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); //считывает строку, когда видит пробел отделяет выражение и записывает в массив строк
                                                                              
int CounterPozitiveNumber(string[] array1) 
{ 
    int count = 0;
    foreach (string var in array1)
    {
        if(int.Parse(var) > 0)
        {
            count += 1;
        }
    }
    return count; 
}

Console.WriteLine($"количество чисел больше нуля: {CounterPozitiveNumber(array)}");