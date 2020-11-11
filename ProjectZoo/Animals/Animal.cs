using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectZoo.Animals
{
    abstract class Animal : IAction
    {
        public int Age { get; }
        public string TypeOfFood { get; }
        public string Individual { get; }

        public string Name { get; }

        // Конструкторы
        public Animal()
        {
            Age = 0;
            TypeOfFood = "Тип пищи не указан";
            Individual = "Пол не указан";
            Name = "Наименование не указано";
        }
        public Animal(int age, string type, string individual, string name)
        {
            Age = age;
            TypeOfFood = type;
            Individual = individual;
            Name = name;
        }

        // Абстрактный метод на основе интерфейса
        public abstract string move();

    }
}
