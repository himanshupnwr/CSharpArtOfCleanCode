using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArtOfCleanCode.CommonCodeSmells
{
    public class GetCustomersResult
    {
        public IEnumerable<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }
    public class OutputParameter
    {
        private const int PageIndex = 1;

        public void DisplayCustomers()
        {
            var result = GetCustomers(PageIndex);
            Console.WriteLine("Total customers: " + result.TotalCount);
            foreach (var c in result.Customers)
                Console.WriteLine(c);
        }

        public GetCustomersResult GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return new GetCustomersResult() { Customers= new List<Customer>(), TotalCount = totalCount };
        }
    }

    public class Customer
    {
    }
}
