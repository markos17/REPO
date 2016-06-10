using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8DuckIEnumerable
{
    class Duck : Bird, IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;
        public string Name { get; set; }

        public int CompareTo(Duck other)
        {
            if (this.Size > other.Size)
                return 1;
            if (this.Size < other.Size)
                return -1;
            else return 0;
        }

        public override string ToString()
        {
            return "A " + Size + " inch " + Kind.ToString();
        }
    }
}
