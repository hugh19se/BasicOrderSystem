using BasicOrderSystem.Models;
using BasicOrderSystem.WebContracts.Bases;

namespace BasicOrderSystem.WebContracts
{
    public class GetCustomersResponse : ResponseBase
    {
        public IList<Customer> Customers { get; set; }
    }
}
