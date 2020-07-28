namespace Aggregation
{
    //TODO: Define public class "BaseDeposit" that inherits from "Deposit".
    public class BaseDeposit: Deposit
    {
        public BaseDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod)
        {

        }

        public override decimal Income()
        {
            decimal sum = 0;
            decimal amountForPeriod = Amount;

            for(int  i = 0; i < Period; i++)
            {
                decimal interest = amountForPeriod * 0.05m;
                sum += interest;
                amountForPeriod += interest;
            }

            return sum;
        }
    }

    //TODO: Define constructor that calls constructor of a base class.

    //TODO: Override method "Income" of base class according to the task. 
}