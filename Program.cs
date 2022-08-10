int count = 0;
string[] array = { "Leonid", "78", "12)", "pro" };
System.Console.WriteLine("[" + string.Join(" , " , array) + "]");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}
System.Console.WriteLine(" Новый массив :");
string[] arrayNew = new string[count];
for (int i = 0; i < count; i++)
    {
        string length = array[i + 1];
        if (length.Length <= 3)
        {
            arrayNew[i] = length;
        }
     
    }

System.Console.WriteLine("[" + string.Join(" , ", arrayNew ) + "]");
