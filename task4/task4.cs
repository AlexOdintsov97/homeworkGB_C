Console.Write("первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // конвертация числа
Console.Write("второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int num_max = 0;
if  (number1 > num_max){
    num_max = number1 ;
}
if  (number2 > num_max){
    num_max = number2 ;
}
if  (number3 > num_max)
{
    num_max = number3 ;
}
Console.WriteLine(num_max);