using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    public class Ch1_10_FixedSizeCollection
    {
        public static int InstanceCount { get; set; }
        public int ItemCount { get; private set; }
        private object[] Items { get; set; }
        public override string ToString() =>
            $"There are {Ch1_10_FixedSizeCollection.InstanceCount.ToString()} instances of {this.GetType().ToString()} and this instance contains {this.ItemCount} items...";

        public Ch1_10_FixedSizeCollection(int maxItems)
        {
            Ch1_10_FixedSizeCollection.InstanceCount++;
            this.Items = new object[maxItems];
        }

        public int AddItem(object item)
        {
            if (ItemCount < Items.Length)
            {
                Items[ItemCount] = item;
                return ItemCount++;
            }
            throw new Exception("Exceed maximum items in collection.");
        }

        public object GetItem(int index)
        {
            if (index >= Items.Length && index >= 0)
                throw new ArgumentOutOfRangeException(nameof(index));
            return Items[index];
        }
    }
}
