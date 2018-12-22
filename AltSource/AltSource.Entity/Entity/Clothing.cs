using static AltSource.Entity.Enums.Enums;

namespace AltSource.Entity
{
    public class Clothing: BaseEntity
    {
        public Size Size { get; set; }
        public Color Color { get; set; }
        public ClothingType Type { get; set; }
        public int StockUnit { get; set; }
        public decimal Price { get; set; }
        
    }
}
