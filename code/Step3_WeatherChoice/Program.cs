Console.WriteLine("Выбеор одежды по погоде");
Console.Write("Введите текущую температуру(°C)");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >=20)
{
    Console.WriteLine("Наденте лёгкую одежду");
}
else
{
    Console.WriteLine("Наденте тёплую одежду");
}
Console.WriteLine("Хорошего дня!");
