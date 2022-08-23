//task 10
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine()); 
string sum(int number)
{
    if (number >= 100)
    {
    string numText = Convert.ToString(number) ;
    return "третья цифра--> " + numText[2];
    }
    else
    {
     return "-->Третьей цифры нету" ;
    }
        
    
}
Console.WriteLine(sum(number));
