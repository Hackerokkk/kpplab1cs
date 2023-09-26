using System;
using System.Collections.Generic;

namespace lab1
{
    class Toy
    {
        public string Name { get; set; }
        public int CostInKopecks { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }

        // Додайте властивості для інших характеристик іграшок (розмір, кількість, вага, кількість конструкцій)

        public Toy(string name, int costInKopecks, int minAge, int maxAge)
        {
            Name = name;
            CostInKopecks = costInKopecks;
            MinAge = minAge;
            MaxAge = maxAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо список для зберігання іграшок
            List<Toy> toys = new List<Toy>();

            // Додавання іграшок до списку (використовуємо окремі поля для віку)
            toys.Add(new Toy("Кубики", 150, 2, 5));
            toys.Add(new Toy("Кубики", 180, 1, 3));
            toys.Add(new Toy("Лялька", 220, 3, 7));
            toys.Add(new Toy("М'яч", 120, 2, 5));
            toys.Add(new Toy("Конструктор", 250, 4, 10));

            int maxCostInKopecks = 200;
            int minAge = 2;

            // Виводимо перелік підходящих кубиків
            Console.WriteLine($"Перелік кубиків, що підходять дитині {minAge} років з вартістю до {maxCostInKopecks} грн:");

            foreach (Toy toy in toys)
            {
                if (toy.Name == "Кубики" && IsAgeInRange(toy.MinAge, toy.MaxAge, minAge) && toy.CostInKopecks <= maxCostInKopecks)
                {
                    Console.WriteLine($"Назва: {toy.Name}, Вартість: {toy.CostInKopecks} копійок");
                }
            }
        }

        // Метод для перевірки, чи вік підходить за вказаним діапазоном
        private static bool IsAgeInRange(int minAge, int maxAge, int age)
        {
            return age >= minAge && age <= maxAge;
        }
    }
}