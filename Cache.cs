using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class Cache<TKey,TValue>
    {

        private Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();
        private Dictionary<TKey, DateTime> time = new Dictionary<TKey, DateTime>();

        public void Add(TKey key, TValue value)
        {
            data[key] = value;
            time[key] = DateTime.Now.AddSeconds(10);
        }

        public TValue Get(TKey key)
        {
            if (Contains(key))
                return data[key];

            return default;
        }

        public void Remove(TKey key)
        {
            data.Remove(key);
            time.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (!data.ContainsKey(key))
                return false;

            if (DateTime.Now > time[key])
            {
                Remove(key);
                return false;
            }

            return true;
        }
    }
}

