using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] _key;
        T2[] _value;
        T1[] tempKey;
        T2[] tempValue;
        public MyDictionary()
        {
            _key = new T1[0];
            _value = new T2[0];
        }
        public void Add(T1 itemKey, T2 itemValue)
        {
            tempKey = _key;
            tempValue = _value;
            _key = new T1[_key.Length + 1];
            _value = new T2[_value.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
                _value[i] = tempValue[i];
            }
            _key[_key.Length - 1] = itemKey;
            _value[_value.Length - 1] = itemValue;
        }

        public int Length
        {
            get { return _key.Length; }
        }
        public T1[] Key
        {
            get { return _key; }
        }
        public T2[] Value
        {
            get { return _value; }
        }
    }

}
