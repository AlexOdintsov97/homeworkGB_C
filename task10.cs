//task 10
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine()); 
string sum(int number)
{
    if (number >= 100 && number < 1000) 
    {
    number = number / 10;
    number = number % 10;
    return "второе число: " + number;   
    }
    else
    {
     return "введите трехзначное число " ;
    }
        
    
}
Console.WriteLine(sum(number));
