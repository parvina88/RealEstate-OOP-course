using Domain.Enum;

namespace Domain.Entities
{
    public class Apartment
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int EntranceId { get; set; }
        public double TotalArea { get; set; }
        public double LivingArea { get; set; }
        public decimal PricePerSquare { get; set; }
        public ApartmentType Type { get; set; }

    }
}
