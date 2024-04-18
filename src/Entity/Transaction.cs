using System.IO.Pipes;

namespace sda_onsite_2_temperature_converter.src.Entity
{
    public class Transaction
    {

        private string _amount;
        private DateTime _date;

        public Transaction(string amount, DateTime? date = null)
        {
            _amount = amount;
            _date = date ?? DateTime.Now;
            
        }
    }
}