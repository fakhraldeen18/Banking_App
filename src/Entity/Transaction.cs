namespace sda_onsite_2_temperature_converter.src.Entity
{
    public class Transaction
    {

        private int _amount;
        private DateTime _date;

        public Transaction(int amount, DateTime? date = null)
        {
            _amount = amount;
            _date = date ?? DateTime.Now;

        }

        public int GetAmount()
        {
            return _amount;
        }
        public DateTime GetDate()
        {
            return _date;
        }

    }
}