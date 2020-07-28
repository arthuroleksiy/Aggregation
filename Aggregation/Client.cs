namespace Aggregation
{

    public class Client
    {
        private readonly Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                if(deposits[i] == null)
                {
                    deposits.SetValue(deposit, i);
                    return true;
                }
            }

            return false;
        }

        public decimal TotalIncome()
        {
            decimal totalResult = 0; ;
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null)
                {
                    totalResult += deposits[i].Income();
                }
            }

            return totalResult;
        }

        public decimal MaxIncome()
        {
            int maximumIncome = 0;

            for (int i = 0; i < deposits.Length; i++ ) 
            {

                if (deposits[i] != null)
                {

                    if (deposits[maximumIncome].Income() <= deposits[i].Income())
                        maximumIncome = i;
                }
            }

            return deposits[maximumIncome].Income();
        }

        public decimal GetIncomeByNumber(int number)
        {
            if (deposits[number - 1] == null)
                return 0;

            return deposits[number - 1].Income();
        }
       
    }
}