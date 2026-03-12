//Начало 
Console.WriteLine("Калькулятор чаевых");
//Объявление переменных и ввод данных
Console.Write("Введите сумму счета (руб): ");
double bill = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите процент чаевых (например, 10): ");
double tipPercent = Convert.ToDouble(Console.ReadLine());
//Вычисления 
double tipAmount = bill * (tipPercent / 100);
double totalAmount = bill + tipAmount;
//ВЫвод результата
Console.WriteLine("\nРезультат:");
Console.WriteLine($"Сумма счёта: {bill} руб");
Console.WriteLine($"Чаевые ({tipPercent}%): {tipAmount} руб");
Console.WriteLine($"Итого к оплате: {totalAmount} руб");
//Конец
Console.WriteLine("Спасибо за использование калькулятора!");
