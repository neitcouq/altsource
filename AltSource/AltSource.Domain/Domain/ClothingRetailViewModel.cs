namespace AltSource.Domain
{
    public class ClothingRetailViewModel: BaseDomain
    {
        public int ClothingVendorId { get; set; }
        //public virtual ClothingVendorViewModel ClothingVendor { get; set; }
        public int VendorId { get; set; }
        //public virtual VendorViewModel Vendor { get; set; }
        public decimal Price { get; set; }
    }
}
