Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int i = 0;
  int length = cube.Length;
  while (i <  length){
    cube[i] = Convert.ToInt32(Math.Pow(i, 3));
    i++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int i = 1;
  while(i < count){
    Console.Write(coll[i]+ " ");
    i++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
