using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    //Класс узел. Представляет одиночный объект в списке
    //Data  - хранит данные любого типа. Next - ссылка на следующий объект
    public class Node<T>
    {  
      public  Node<T> Next { get; set; }
      public  T Data { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}
