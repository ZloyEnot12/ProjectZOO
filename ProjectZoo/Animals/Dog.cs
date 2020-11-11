using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectZoo.Animals
{
    class Dog : Animal, IAction
    {
        public string Breed { get; set; }

        // Конструктор
        public Dog(int age, string type, string individual, string name, string breed) :
            base(age, type, individual, name)
        {
            Breed = breed;
        }

        // Переопределение метода ToString для вывода общей информации о животном 
        public override string ToString()
        {
            return "Имя: " + Name + "\nЛет: " + Age + "\nТип: " + TypeOfFood + "\nПол: " + Individual +
                "\nПорода: " + Breed;
        }
        public override string move()
        {
            return Name + " бежит";
        }


    }
}
