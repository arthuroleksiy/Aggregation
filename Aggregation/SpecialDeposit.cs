namespace Aggregation
{
    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal amount, int period) : base(amount, period)
        {

        }
        
        public override decimal Income()
        {
            decimal sum = 0;
            decimal amountForPeriod = Amount;
            decimal specialPercent = 0.01m;

            for (int i = 0; i < Period; i++)
            {
                decimal interest = amountForPeriod * specialPercent;
                sum += interest;
                amountForPeriod += interest;
                specialPercent += 0.01m;
            }

            return sum;
        }
    }
    
   

}