Console.Write("Введите 8 элементов  ");
string str = Convert.ToString(Console.ReadLine());

string GetList(string str){
    int len = str.Length;
    if (len <= 8){
        List<char> chars = new List<char>();
        chars.AddRange(str);
        return ("["+String.Join(", ", chars)+"]");   
    }
    else{
        return ("Вы ввели много символов");
    }
}
string getlist = GetList(str);
Console.Write(getlist);
