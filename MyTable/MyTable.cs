﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyTable
{
    public delegate void ChangedEventHandler(int sizeOfTale);
    class MyTable
    {
        public event ChangedEventHandler Changed;
        int DEFAULT_VALUE;
        int currentSize;
        
        public int CurrentSize
        {
            get
            {
                return currentSize;
            }
        }
        int indexOfLast;
        public int IndexOfLast
        {
            get
            {
                return indexOfLast;
            }
        }
        int[] tab;

        public MyTable()
        {
            DEFAULT_VALUE = -1;
            currentSize = 0;
            Monitor.Enter(tab);
        }

        //dokończyć
        public void LockedAdd(int value)
        {
            while (!Monitor.TryEnter(tab))
            {
                Add(value);
            }
        }

        //dokończyć
        public void UnlockedAdd(int value)
        {

        }

        public void Add (int value)
        {
            if (currentSize == 0)
            {
                tab = new int[1];
                currentSize = 1;
                tab[0] = value;
                indexOfLast = 0;
            }
            else
            {
                if (indexOfLast + 1 == currentSize)
                {
                    int newCurrentSize = currentSize * 2;
                    int[] temp = new int[newCurrentSize];
                    for (int i = 0; i < currentSize; i++)
                    {
                        temp[i] = tab[i];
                    }
                    temp[currentSize] = value;
                    tab = temp;
                    currentSize = newCurrentSize;
                }
                else
                {
                    tab[indexOfLast + 1] = value;
                }

                indexOfLast++;
            }
            Changed?.Invoke(indexOfLast + 1);
        }

        public int Get (int index)
        {
            --index;
            if (index <= indexOfLast)
            {
                return tab[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Set(int index, int value)
        {
            --index;
            if (index >= currentSize)
            {
                int newCurrentSize = index + 1;
                int[] temp = new int[newCurrentSize];
                for (int i = 0; i < currentSize; i++)
                {
                    temp[i] = tab[i];
                }
                temp[index] = value;
                for (int i = currentSize + 1; i < newCurrentSize; i++)
                {
                    temp[i] = DEFAULT_VALUE;
                }
                tab = temp;
                currentSize = newCurrentSize;
                indexOfLast = index;

                Changed?.Invoke(indexOfLast + 1);
            }
            else
            {
                tab[index] = value;
            }
        }
    }
}
