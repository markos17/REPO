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
                return new GetSecretIngredient(AmySecretIngredient);
            }
        }

        private string AmySecretIngredient(int amount)
        {
            if (amount < 10)
            {
                return amount.ToString() + " puszek sardynki -- więcej!";
            }
            else
            {
                return amount.ToString() + " puszek sardynki";

            }
        }
    }
}
