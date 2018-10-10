namespace PartyPlanner_2._0
{
    public class DinnerParty : Party
    {
        
        public bool HealthyOption { get; set; }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson();
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal cost;
            if (HealthyOption)
            {
                cost = 5.00M;
            }
            else
            {
                cost = 20.00M;
            }

            return cost;
        }
    }
}