int[] array= new int[12];

int[] MakeArray(int []arr)
{
    Random rnd=new Random();
    Console.Write("{ ");
    for (int i=0;i<12;i++)
    {
        arr[i]=rnd.Next(-9,10);
        Console.Write($"{arr[i]} ");
    } 
    Console.Write("}");
    return arr;
   
}

int[] arrray= MakeArray(array);
Console.WriteLine();
void Sum(int [] arar)
{
    int sumPozitive=default;
    int sumNegative=default;
    for (int i=0; i<12;i++)
    {
        if (arar[i]>0) sumPozitive=sumPozitive+array[i];
        else sumNegative=sumNegative+array[i];
    }
    Console.WriteLine($"Сумма положительных = {sumPozitive}");
    Console.WriteLine($"Сумма отрицательных = {sumNegative}");
}

Sum(arrray);