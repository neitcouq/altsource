namespace AltSource.Entity
{
    public class ClothingRetail: BaseEntity
    {
        public int ClothingVendorId { get; set; }
        public virtual ClothingVendor ClothingVendor { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
        public decimal Price { get; set; }
    }
}
