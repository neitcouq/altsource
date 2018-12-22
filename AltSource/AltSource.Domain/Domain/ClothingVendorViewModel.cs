namespace AltSource.Domain
{
    public class ClothingVendorViewModel: BaseDomain
    {
        public int ClothingId { get; set; }
        //public virtual ClothingViewModel Clothing { get; set; }

        public decimal Price { get; set; }
        public int Unit { get; set; }
        public int VendorId { get; set; }
        //public virtual VendorViewModel Vendor { get; set; }
    }
}
