//Начало
Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую температуру (℃): ");
int temperature = Convert.ToInt32(Console.ReadLine());
//Условие (ветвление)
if (temperature >= 20)
{
    //Условие Истинно (ДА)
    Console.WriteLine("Наденьте легкую одежду");
}
else
{
    //Условие ЛОЖНО (Нет)
    Console.WriteLine("Наденьте теплую одежду");
}
Console.WriteLine("Хорошего дня");