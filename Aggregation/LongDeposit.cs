namespace Aggregation
{
    
    public class LongDeposit: Deposit
    {
        public LongDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount,  depositPeriod)
        {

        }

        public override decimal Income()
        {
           
            decimal sum = 0;
            decimal amountForPeriod = Amount;

            for (int i = 0; i < Period; i++)
            {
                if (i >= 6)
                {
                    decimal interest = amountForPeriod * 0.15m;
                    sum += interest;
                    amountForPeriod += interest;
                }
            }

            return sum;
        }
    }
    
}