using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch15DelegateRestaurantWinForm
{
    class Suzanne
    {
        public GetSecretIngredient MySecretIngredient
        {
            get
            {
                return new GetSecretIngredient(SuzanneSecretIngredient);
            }
        }

        private string SuzanneSecretIngredient(int amount)
        {
            return amount.ToString() + " kilo żelatyny";
        }
    }

    class Amy
    {
        public GetSecretIngredient AmySecretIngredientMethod
        {
            get
            {
                return AmySecretIngredient;
            }
        }

        private string AmySecretIngredient(int amount)
        {
            if (amount < 10)
            {
                return amount + " puszek sardynki -- więcej!";
            }
            else
            {
                return amount + " puszek sardynki";

            }
        }
    }
}
