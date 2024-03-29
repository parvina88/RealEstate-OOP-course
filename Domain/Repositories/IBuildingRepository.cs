using Domain.Entities;

namespace Domain.Repositories
{
    public interface IBuildingRepository
    {
        List<Building> GetAll();
        Building GetById(int id);
        bool AddBuilding(Building building);
        bool UpdateBuilding(Building building);
        bool DeleteBuilding(int buildingId);
    }
}
