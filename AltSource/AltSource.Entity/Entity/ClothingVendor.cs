namespace AltSource.Entity
{
    public class ClothingVendor: BaseEntity
    {
        public int ClothingId { get; set; }
        public virtual Clothing Clothing { get; set; }

        //Same as Clothing.Price, duplicate to avoid join query in the future ex: report
        public decimal Price { get; set; }
        public int Unit { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
