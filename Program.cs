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

try 
{
    Console.WriteLine("Задайте размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array1 = FillArray(size);
    string[] array2 = new string[size];
    Console.WriteLine($"Array1: [{String.Join(", ", array1)}]");
} 
catch
{
    Console.WriteLine("Ошибочка! Вы не правильно задали размер массива!");
}