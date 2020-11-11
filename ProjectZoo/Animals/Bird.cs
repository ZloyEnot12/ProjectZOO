using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectZoo.Animals
{
    class Bird : Animal, IAction
    {

        public double Wingspan { get; set; }

        // Конструктор
        public Bird(int age, string type, string individual, string name, double wingspan)
            : base(age, type, individual, name)
        {
            Wingspan = wingspan;
        }

        // Переопределение метода ToString для вывода общей информации о животном 
        public override string ToString() {

            return "Имя: " + Name + "\nЛет: " + Age + "\nТип: " + TypeOfFood + "\nПол: " + Individual +
                "\nРазмах крыла: " + Wingspan;
        }

        public override string move()
        {
            return Name + " летит";
        }

    }
}
