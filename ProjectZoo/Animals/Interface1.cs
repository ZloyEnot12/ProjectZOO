using System;
using System.Collections.Generic;
using System.Text;


/* Интерфейс, описывающий действия, которые могут выполнять животные. На данный момент оно одно и 
 соответствует типу движения определенного животного */
namespace ProjectZoo.Animals
{
    interface IAction
    {
        public string move();
        
    }
}
