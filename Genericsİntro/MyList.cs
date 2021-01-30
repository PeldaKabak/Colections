﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    class MyList<T>
    {
        T[] items;
        //constructor 

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tepmArray = items;
            items = new T[items.Length+1];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = tepmArray[i];

            }

            items[items.Length - 1] = item;
        }
    }
}
