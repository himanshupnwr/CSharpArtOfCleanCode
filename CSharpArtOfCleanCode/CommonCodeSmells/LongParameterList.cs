using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArtOfCleanCode.CommonCodeSmells
{
    public class DateRange
    {
        private DateTime _dateFrom;
        private DateTime _dateTo;

        public DateRange(DateTime dateFrom, DateTime dateTo)
        {
            this._dateFrom = dateFrom;
            this._dateTo = dateTo;
        }
        public DateTime DateFrom
        {
            get { return _dateFrom; }
        }
            
        public DateTime DateTo
        {
            get { return _dateTo;}
        }

    }
    public class LongParameterList
    {
        //Refactored the date range into a separate class to reduce the parameter list
        public IEnumerable<Reservation> GetReservations(
           DateRange dateRange,
           UserId user, int locationId,
           LocationType locationType, int? customerId = null)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(
            DateTime dateFrom, DateTime dateTo,
            UserId user, int locationId,
            LocationType locationType)
        {
            if (dateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateTime dateFrom, DateTime dateTo, ReservationDefinition sd)
        {
            if (dateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(DateTime dateFrom, DateTime dateTo, int locationId)
        {
            if (dateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class UserId
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
