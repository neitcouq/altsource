using System.Collections.Generic;

namespace AltSource.Domain
{
    public class VendorViewModel: BaseDomain
    {
        public string Name { get; set; }
        public virtual ICollection<ClothingVendorViewModel> ClothingVendors { get; set; }
    }
}
