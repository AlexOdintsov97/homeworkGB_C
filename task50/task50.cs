Console.WriteLine("введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];
FillArrayRandomNumbers(numbers);

PrintArray(numbers);
Parse(numbers, 5);
void Parse(int[,] array, int num)
        {
            var dimension1 = numbers.GetUpperBound(0);
            var dimension2 = numbers.GetUpperBound(1);

            for (int i = 0; i <= dimension1; i++)
            {
                for (int j = 0; j <= dimension2; j++)
                {
                    if (numbers[i, j] == num)
                        Console.WriteLine($"[{i},{j}]");
                }
            }
        }

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}