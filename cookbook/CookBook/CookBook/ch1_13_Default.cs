using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    class ch1_13_Default<T>
    {
        private T _data; //= default(T);

        public bool IsDefault()
        {
            T temp = default(T);
            return temp.Equals(_data);
        }

        public bool IsDefault(T arg)
        {
            T temp = default(T);
            return temp.Equals(arg);
        }

        public void SetData(T val)
        {
            _data = val;
        }
    }
}
