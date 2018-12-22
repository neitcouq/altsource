using System;
using System.Collections.Generic;
using System.Text;

namespace AltSource.Entity
{
    public class Vendor: BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ClothingVendor> ClothingVendors { get; set; }
        public virtual ICollection<ClothingRetail> ClothingRetails { get; set; }

    }
}
