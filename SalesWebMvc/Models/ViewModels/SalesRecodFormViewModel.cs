namespace SalesWebMvc.Models.ViewModels
{
    public class SalesRecodFormViewModel
    {
        public ICollection<Seller> Sellers { get; set; }
        public SalesRecord SalesRecord { get; set; }

    }
}
