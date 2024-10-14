using BasicOrderSystem.Models;
using BasicOrderSystem.WebContracts.Bases;

namespace BasicOrderSystem.WebContracts
{
    public class GetOrdersResponse : ResponseBase
    {
        public IList<Order> Orders { get; set; }
    }
}
