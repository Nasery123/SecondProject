namespace SecondProject.Services;


public class HousesService
{
    private readonly HousesRepository _repo;
    public HousesService(HousesRepository repo)
    {
        _repo = repo;
    }

    internal House CreateHouse(House houseData)

    {
        House house = _repo.CreateHouse(houseData);
        return house;
    }

    internal List<House> GetAllHouses()
    {
        List<House> houses = _repo.GetAllHouses();
        return houses;
    }

    internal House GetHouseById(int houseId)
    {
        House house = _repo.GetHouseById(houseId);
        if (house == null) throw new Exception($"house does not exist at Id : {houseId}");
        return house;
    }

    internal string RemoveHouse(int houseId)
    {
        House house = GetHouseById(houseId);
        int rows = _repo.RemoveHouse(houseId);
        if (rows > 1) throw new Exception("make sure you touch only one row. thank you");
        return "you successfully deleted the house";
    }


    internal House UpdateHouse(House updateData)
    {
        House original = GetHouseById(updateData.Id);

        original.bedroom = updateData.bedroom != null ? updateData.bedroom : original.bedroom;
        original.bathroom = updateData.bathroom != null ? updateData.bathroom : original.bathroom;
        original.price = updateData.price != null ? updateData.price : original.price;
        original.yearmake = updateData.yearmake != null ? updateData.yearmake : original.yearmake;
        original.description = updateData.description != null ? updateData.description : original.description;


        _repo.UpdateHouse(original);
        return original;

    }
}
