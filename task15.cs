Console.Write("введите число от 1 до 7 означающее дни недели: ");
int number = Convert.ToInt32(Console.ReadLine()); 
string weekend(int number)
{
    if (number >= 1 && number <= 5)
    {
        return "Нет это рабочий день";   
    }
    else if (number >=6 && number <= 7) 
    {
        return "Да это выходной";
    }
    else{
        return "нет такого дня недели ";
    }
}

Console.WriteLine(weekend(number));