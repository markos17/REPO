using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7house
{
    class Outside : Location
    {
        private bool hot;

        public Outside(string name, bool hot) 
            : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                if (hot)
                {
                    return base.Description + "\n It's very hot here";
                }
                else
                {
                    return base.Description;
                }
            }
        }
    }
}
