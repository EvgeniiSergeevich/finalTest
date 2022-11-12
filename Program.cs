string[] FillArray(int size) 
{
    string[] array = new string[size];
    Console.WriteLine($"Введите {size} элементов массива");
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] ThreeSymbols(string[] array) 
{
    int j = 0;
    string[] threeSymb = new string[array.Length];
    
       for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            threeSymb[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref threeSymb, j);
    return threeSymb;
}

try 
{
    Console.WriteLine("Задайте размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array1 = FillArray(size);
    Console.WriteLine($"Исходный массив: [{String.Join(", ", array1)}]");
    string[] array2 = ThreeSymbols(array1);
    Console.WriteLine($"Итоговый массив: [{String.Join(", ", array2)}]");
} 
catch
{
    Console.WriteLine("Ошибочка! Вы не правильно задали размер массива!");
}