namespace Domain.Entities
{
    public class Entrance
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string CeilingHeight { get; set; }  // высота потолка
        public int BuildingId { get; set; }
        public int NumberFloor { get; set; }
        public int NumberApartmentPerFloor { get; set; }
        public bool HasLift { get; set; }

    }
}
