Console.WriteLine("Введите несколько чисел через запятую: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array  = new int [number];
void mas(int number)
{
       for (int i = 0; i < number; i++) 
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
} 


int Num (int [] array)
{
    
    int col = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        col++;
    }
    return col;
}

mas(number);
Console.WriteLine($"Количество чисел больше 0 = {Num(array)}");