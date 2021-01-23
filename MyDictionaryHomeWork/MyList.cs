using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHomeWork
{
    class MyList<T>
    {
        
        T[] item;
        T[] tempArray;
        public MyList()//Constructor
        {
            item = new T[0];
        }
        public void Add(T items)
        {
            tempArray = item;
            item = new T[item.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                item[i] = tempArray[i];
            }
        }
    }
}

