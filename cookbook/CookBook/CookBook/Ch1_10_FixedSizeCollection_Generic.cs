using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    public class Ch1_10_FixedSizeCollection_Generic<T>
    {
        public static int InstanceCount { get; set; }
        public int ItemCount { get; private set; }
        private T[] Items { get; set; }
        public override string ToString() =>
            $"There are {Ch1_10_FixedSizeCollection_Generic<T>.InstanceCount.ToString()} instances of {this.GetType().ToString()} and this instance contains {this.ItemCount} items...";

        public Ch1_10_FixedSizeCollection_Generic(int items)
        {
            Ch1_10_FixedSizeCollection_Generic<T>.InstanceCount++;
            Items = new T[items];
        }

        public void AddItem(T item)
        {
            if (ItemCount < Items.Length)
            {
                Items[ItemCount] = item;
                ItemCount++;
            }
            else
            {
                throw new Exception("Exceed max!");
            }
        }

        public T GetItem(int index)
        {
            return Items[index];
        }
    }
}
