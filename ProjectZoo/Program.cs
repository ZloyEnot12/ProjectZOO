
using System;
using ProjectZoo.Animals;

namespace ProjectZoo
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // Создание объектов классов животных
            Animal sova = new Bird(1, "Плотоядное", "Самка", "Сова", 2.3);
            Animal asianElephant = new Elephant(3, "Травоядное", "Самец", "Индийский слон", 4.9);
            Animal bulldog = new Dog(4, "Плотоядное", "Самец", "Бульдог", "Английский бульдог");

            // Инициализация массива состоящего из этих объектов
            Animal[] myZoo = new Animal[] { sova, asianElephant, bulldog };

            // Вывод данных об этих объектах 
            for( int i = 0; i < myZoo.Length; i++)
            {
                Console.WriteLine(myZoo[i]);
                Console.WriteLine(myZoo[i].move());
                Console.WriteLine();
            }

            
        }
    }
}
