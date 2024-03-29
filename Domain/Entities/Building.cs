using Domain.Enum;

namespace Domain.Entities
{
    public class Building
    {
        public Building(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Building(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public Building(int id, string name, string address, Materials material) : this(id, name, address)
        {
            Material = material;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public Materials Material { get; set; }


        public string GetName(int id)
        {
            return Name;
        }
    }
}
