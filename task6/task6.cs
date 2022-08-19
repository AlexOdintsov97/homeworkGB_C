Console.Write("Является ли число четным? Введите чтобы проверить: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2 ==0)
{
    Console.WriteLine("Да, число: "+ number + " является четным");
}
else
 {
    Console.WriteLine("Нет, число: "+ number + " неявляется четным");
}