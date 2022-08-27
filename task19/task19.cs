Console.Write("Введите число: ");
string? num = Console.ReadLine();

void CheckingNum(string num)
{
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"Ваше число: {num} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {num} - не палиндром.");
}

if (num!.Length == 5){
  CheckingNum(num);
}
else Console.WriteLine($"Введи правильное число");
