Console.Write("Введите число которое нужно возвести в степень: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int GetNumber(int number1, int number2)
{   
    int sum = 1;
    for (int i=1; i<=number2; i++)
    {
        sum = sum * number1;
    }  
return sum;

}
int getnumber = GetNumber(number1, number2);
Console.WriteLine(getnumber);