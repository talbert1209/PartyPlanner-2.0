namespace PartyPlanner_2._0
{
    public class Party
    {
        private const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        public virtual decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople >= 100)
                    totalCost += 100M;

                return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
            return costOfDecorations;
        }
    }
}