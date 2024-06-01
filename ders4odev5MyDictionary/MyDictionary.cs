using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders4odev5MyDictionary
{
    public class MyDictionary<Key, Value>

    {
        List<Key> keys;
        List<Value> values;
        public MyDictionary()
        {
            keys = new List<Key>();
            values = new List<Value>();
        }
        public void Add(Key key, Value value)
        {
            keys.Add(key);
            values.Add(value);
        }


        public void Clear()
        {
            keys.Clear();
            values.Clear();
        }
        public List<Key> GetKeys() { return keys; }
        public List<Value> GetValues() { return values; }

    }
}