using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty_first_version
{
    class DinnerParty : Party
    {
        public DinnerParty()
        {

        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecoration;
        }

        //    public const int CostOfFoodPerPerson = 25;
        // private int numberOfPeople;
        //    public int NumberOfPeople { get; set; }
        //     public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        //   public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        //public void SetHealthyOption(bool healthyOption)
        //{
        //    if (healthyOption)
        //    {
        //        CostOfBeveragesPerPerson = 5.00M;
        //    }
        //    else  
        //    {
        //        CostOfBeveragesPerPerson = 20.00M;
        //    }
        //}

        private decimal CalculateCostOfBeveragesPerPerson()
        {

            if (HealthyOption)
            {
                return 5.00M;
            }
            else
            {
                return 20.00M;
            }
        }

        //private decimal CalculateCostOfDecorations()
        //{
        //    if (this.FancyDecorations)
        //    {
        //       return (NumberOfPeople * 15.00M) + 50M;
        //    }
        //    else
        //    {
        //        return (NumberOfPeople * 7.50M) + 30M;
        //    }
        //}

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                // decimal totalCost = CalculateCostOfDecorations() 
                totalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;

                if (this.HealthyOption)
                {
                    totalCost *= .95M;
                }

                return totalCost;

            }
        }
        //public decimal CalculateCost()
        //{
        //    decimal totalCost = CostOfDecorations +
        //           ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
        //               * NumberOfPeople);

        //    if (this.HealthyOption)
        //    {
        //        return totalCost * .95M;
        //    }
        //    else
        //    {
        //        return totalCost;
        //    }
        //}
    }
}
