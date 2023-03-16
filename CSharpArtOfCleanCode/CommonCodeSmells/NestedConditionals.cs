using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArtOfCleanCode.CommonCodeSmells
{
    public class CustomerCondition
    {
        public int LoyaltyPoints { get; set; }

        public bool IsGoldCustomer()
        {
            return LoyaltyPoints > 100;
        }
    }

    public class ReservationCondition
    {
        public ReservationCondition(CustomerCondition customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public DateTime From { get; set; }
        public CustomerCondition Customer { get; set; }
        public bool IsCanceled { get; set; }

        public void Cancel()
        {
            // If reservation already started throw exception
            if (IsAlreadyStarted() || IsCancellationPeriodOver())
            {
                throw new InvalidOperationException("It's too late to cancel.");
            }
            // Gold customers can cancel up to 24 hours before
            IsCanceled = true;
        }

        private bool IsAlreadyStarted()
        {
            return DateTime.Now > From;
        }

        private bool IsCancellationPeriodOver()
        {
            return (Customer.IsGoldCustomer() && LessThan(24)) || (!Customer.IsGoldCustomer() && LessThan(48));
        }

        private bool LessThan(int maxHours)
        {
            return (From - DateTime.Now).TotalHours < maxHours;
        }
    }
}
