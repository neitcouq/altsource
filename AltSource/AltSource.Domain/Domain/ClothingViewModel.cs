using System;
using static AltSource.Entity.Enums.Enums;

namespace AltSource.Domain
{
    public class ClothingViewModel: BaseDomain
    {
        public Size Size { get; set; }
        public Color Color { get; set; }
        public ClothingType Type { get; set; }
        public int StockUnit { get; set; }
        public decimal Price { get; set; }
    }
}
