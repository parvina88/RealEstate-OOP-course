using Domain.Entities;
using Domain.Repositories;

var building = new Building(1, "JK Somoniyoin");

IBuildingRepository repository = new BuildingRepository();


var added = repository.AddBuilding(building);
Console.WriteLine(added);

var buildings = repository.GetAll();

foreach (var item in buildings)
{
    Console.WriteLine($"{item.Id} {item.Name }");
}

var newBuilding = new Building(2, "Дом 2", "Россия");

var updated = repository.UpdateBuilding(newBuilding);

Console.WriteLine(updated);
var delete = repository.DeleteBuilding(1);
Console.WriteLine(delete);

foreach (var item in buildings)
{
    Console.WriteLine($"{item.Id} {item.Name}");
}
