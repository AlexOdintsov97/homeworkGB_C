Console.Write("первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // конвертация числа
Console.Write("второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int num_max = 0;
if  (number1 > num_max){
    num_max = number1 ;
}
else  
{
    num_max = number2 ;
}
Console.WriteLine(num_max);