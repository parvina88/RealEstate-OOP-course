using Domain.Entities;

namespace Domain.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
         private List<Building> _buildings;

        public BuildingRepository()
        {
            _buildings = new List<Building>();
        }

        public bool AddBuilding(Building building)
        {
            if (building == null)
            {
                return false;
            }

            _buildings.Add(building);
            return true;
        }

        public bool DeleteBuilding(int buildingId)
        {
            var building = GetById(buildingId);

            if (building == null)
            {
                return false;
            }

            _buildings.Remove(building);
            return true;
        }

        public List<Building> GetAll()
        {
            return _buildings;
        }

        public Building GetById(int id)
        {
            return _buildings.Find(x => x.Id == id);
        }

        public bool UpdateBuilding(Building building)
        {
            var existingBuilding = _buildings.FirstOrDefault(b  => b.Id == building.Id);

            if (existingBuilding == null)
            {
                return false;
            }

            existingBuilding.Name = building.Name;
            existingBuilding.Address = building.Address;
            existingBuilding.Material = building.Material;
            return true;
        }
    }
}
