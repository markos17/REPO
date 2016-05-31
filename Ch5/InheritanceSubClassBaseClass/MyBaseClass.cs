using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSubClassBaseClass
{
    class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedThis)
        {
            Console.WriteLine("this is the base class:" + baseClassNeedThis.ToString());
        }
    }

    class MySubClass : MyBaseClass
    {
        public MySubClass(string baseClassNeedThis, int zmienna) : base(baseClassNeedThis)
        {
            Console.WriteLine("This is the subclass: " + baseClassNeedThis + " and " + zmienna);
        }
    }
}
