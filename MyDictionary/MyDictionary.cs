using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            //Buraya keylerin eşsiz olması için kontrol yapısı gelecek!

            K[] tempKeyArray = keys;
            V[] tempValueArray = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValueArray[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        

        public void Count()
        {
            Console.WriteLine(keys.Length);           
        }

        public void ShowList()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Id:" + keys[i] + " Name: " + values[i]);
            }
        }
    }
}
