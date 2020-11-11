using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectZoo.Animals
{
    class Elephant : Animal, IAction
    {
        public double lengthTrunk;

        // Конструктор
        public Elephant(int age, string type, string individual, string name, double lengthOfTrunk) :
            base(age, type, individual, name)
        {
            lengthTrunk = lengthOfTrunk;
        }

        // Переопределение метода ToString для вывода общей информации о животном 
        public override string ToString()
        {
            return "Имя: " + Name + "\nЛет: " + Age + "\nТип: " + TypeOfFood + "\nПол: " + Individual +
                "\nДлина хобота: " + lengthTrunk;
        }

        // Абстрактный метод, переопределяемых в наследниках класса Animal
        public override string move()
        {
            return Name + " шагает";
        }

    }
}
