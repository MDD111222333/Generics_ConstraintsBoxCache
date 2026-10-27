using System;

namespace Generics_ConstraintsBoxCache
{
    class Program
    {
        static void Main(string[] args)
        {
            ReferenceBox<string> refBox = new ReferenceBox<string>();
            Console.WriteLine($"новый ReferenceBox<string>: IsEmpty == {refBox.IsEmpty}");
            refBox.Set("Алина");
            Console.WriteLine($"после Set(\"Алина\"): IsEmpty == {refBox.IsEmpty}, Get() == \"{refBox.Get()}\"");

            ValueBox<int> valBox = new ValueBox<int>();
            Console.WriteLine($"новый ValueBox<int>: IsEmpty == {valBox.IsEmpty}");
            valBox.Set(25);
            Console.WriteLine($"после Set(25): IsEmpty == {valBox.IsEmpty}, Get() == {valBox.Get()}");

            ReferenceCache<string> refCache = new ReferenceCache<string>();
            string? refResult;
            bool refFound = refCache.TryGet(out refResult);
            Console.WriteLine($"TryGet на пустом ReferenceCache<string>: {refFound}, значение {refResult}");
            refCache.Set("КэшСтрока");
            refFound = refCache.TryGet(out refResult);
            Console.WriteLine($"TryGet на заполненном ReferenceCache<string>: {refFound}, корректное значение: {refResult}");

            ValueCache<double> valCache = new ValueCache<double>();
            double? valResult;
            bool valFound = valCache.TryGet(out valResult);
            Console.WriteLine($"TryGet на пустом ValueCache<double>: {valFound}");
            valCache.Set(7.2);
            valFound = valCache.TryGet(out valResult);
            Console.WriteLine($"TryGet на заполненном ValueCache<double>: {valFound}, корректное значение: {valResult}");

            /*
            ReferenceBox<int> invalidRefBox = new ReferenceBox<int>();
            ValueBox<string> invalidValBox = new ValueBox<string>();
            ReferenceCache<double> invalidRefCache = new ReferenceCache<double>();
            ValueCache<string> invalidValCache = new ValueCache<string>();
            */

            Console.WriteLine();
            Console.WriteLine("=== Интерактивный ввод данных для проверки ===");

            while (true)
            {
                try
                {
                    Console.Write("Введите целое число для ValueBox (или 'stop' для выхода): ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input) || input.Trim().ToLower() == "stop")
                    {
                        break;
                    }

                    int number = int.Parse(input);
                    ValueBox<int> customBox = new ValueBox<int>();
                    customBox.Set(number);
                    Console.WriteLine($"Создан ValueBox<int> со значением: {customBox.Get()}, IsEmpty: {customBox.IsEmpty}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не целое число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}   