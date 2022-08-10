int count = 0;
string[] array = { "Leonid", "78", "12)", "pro" };
System.Console.WriteLine("[" + string.Join(" , " , array) + "]");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}
