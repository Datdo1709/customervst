using VSTCustomer.Models;

namespace VSTCustomer.ViewModels
{
    public class OrderVM
    {
        public required IEnumerable<ORDERED> Orders { get; set; }
        public required Pagination Pagination { get; set; }

    }
}
