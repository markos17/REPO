using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7houseHideAndSeek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name, hot)
        {
            HidingPlaceName = hidingPlace;
        }

        public string HidingPlaceName { get; private set; }

        public override string Description
        {
            get
            {
                return base.Description + " some could hide " + HidingPlaceName + ",";
            }
        }
    }
}
