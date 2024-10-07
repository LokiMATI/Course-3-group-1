using System;
using static System.Convert;
using ConsoleTables;

namespace Lesson3Record;

class Program
{
    static void Main()
    {
        string filePath = "sales.csv";
        CSVRecordRW _CSVRecordRW = new CSVRecordRW();
        RecordMethods client_methods = new RecordMethods(_CSVRecordRW.ReadRecord(filePath));
        List<Record> records = client_methods.GetRecords();
        while (true)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1. Добавить продукт");
            Console.WriteLine("2. Удалить продукт");
            Console.WriteLine("3. Вывести список");
            Console.WriteLine("4. Дополнительная информация");
            Console.WriteLine("5. Выйти");
            Console.Write("Введите ваш выбор: ");
            switch (ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Write("Введите продукт: ");
                    string product = Console.ReadLine();
                    Console.Write("Введите регион: ");
                    string region = Console.ReadLine();
                    Console.Write("Введите цену: ");
                    decimal price = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Введите количество: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите год: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите месяц: ");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите день: ");
                    int day = Convert.ToInt32(Console.ReadLine());
                    DateOnly date = new DateOnly(year, month, day);
                    client_methods.AddRecord(filePath, (new Record(date, product, region, quantity, price)));
                    break;
                case 2:
                    Console.Write("Введите индекс: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    client_methods.DeleteRecord(filePath, index);
                    break;
                case 3:
                    Console.WriteLine("Вывод списка по:\n 1. дате\n 2. диапазону цен");
                    Console.Write("Введите ваш выбор: ");
                    switch(ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Write("Введите год: ");
                            int year_filter = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите месяц: ");
                            int month_filter = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите день: ");
                            int day_filter = Convert.ToInt32(Console.ReadLine());
                            DateOnly date_filter = new DateOnly(year_filter, month_filter, day_filter);
                            var table_date = new ConsoleTable("Product", "Region", "Quantity", "Price");
                            foreach (var record in records)
                            {
                                if (record.Date == date_filter)
                                table_date.AddRow(record.Product, record.Region, record.Quantity, record.Price);
                            }
                            table_date.Write();
                            break;
                        case 2:
                            Console.Write("Введите минимальную цену: ");
                            decimal min_price = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Введите максимальную цену: ");
                            decimal max_price = Convert.ToDecimal(Console.ReadLine());
                            var table_price = new ConsoleTable("Date", "Product", "Region", "Quantity", "Price");
                            foreach (var record in records)
                            {
                                if (record.Price >= min_price && record.Price <= max_price)
                                table_price.AddRow(record.Date, record.Product, record.Region, record.Quantity, record.Price);
                            }
                            table_price.Write();
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Дополнительная информация:");
                    Console.WriteLine("1. Общая сумма продаж");
                    Console.WriteLine("2. Среднее количество проданных товаров");
                    Console.WriteLine("3. Cумма продаж по продукту");
                    Console.WriteLine("4. Cумма продаж за период");
                    Console.Write("Введите ваш выбор: ");
                    switch (ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            decimal sum = 0;
                            foreach (var record in records)
                            {
                                sum += record.Quantity * record.Price;
                            }
                            Console.WriteLine("Общая сумма продаж: " + sum);
                            break;
                        case 2:
                            decimal quantity_sum = 0;
                            foreach (var record in records)
                            {
                                quantity_sum += record.Quantity;
                            }
                            Console.WriteLine("Среднее количество проданных товаров: " + quantity_sum / records.Count);
                            break;
                        case 3:
                            Console.Write("Введите продукт: ");
                            string product_filter = Console.ReadLine();
                            decimal sum_product = 0;
                            foreach (var record in records)
                            {
                                if (record.Product == product_filter){
                                    sum_product += record.Quantity * record.Price;
                                }
                            }
                            Console.WriteLine("Сумма продаж по продукту: " + sum_product);
                            break;
                        case 4:
                            Console.Write("Введите первую дату:");
                            DateOnly date_start = new DateOnly(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            Console.Write("Введите вторую дату:");
                            DateOnly date_end = new DateOnly(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            decimal sum_period = 0;
                            foreach (var record in records)
                            {
                                if (record.Date >= date_start && record.Date <= date_end){
                                    sum_period += record.Quantity * record.Price;
                                }
                            }
                            Console.WriteLine("Сумма продаж за период: " + sum_period);
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
            
        }
            
    }
}