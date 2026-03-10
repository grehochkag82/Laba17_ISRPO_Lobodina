Console.WriteLine("Вывод элементов массива");
int[] grades = { 5, 4, 5, 3, 4 };
Console.WriteLine("Массив оценок студента:");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Элемент с индексом [{i}] = {grades[i]}");
}
Console.WriteLine("\nКонец программы.");