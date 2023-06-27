namespace SecondProject.Repositories;
public class HousesRepository
{
    private readonly IDbConnection _db;
    public HousesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal House CreateHouse(House houseData)
    {
        string sql = @"
      INSERT INTO houses
      (bedroom, bathroom, price, yearmake, description)
      VALUES
      (@bedroom, @bathroom, @price, @yearmake, @description);
      SELECT * FROM houses WHERE id = LAST_INSERT_ID();
      ";
        House house = _db.Query<House>(sql, houseData).FirstOrDefault();
        return house;
    }

    internal List<House> GetAllHouses()
    {
        string sql = "SELECT * FROM  houses;";
        List<House> houses = _db.Query<House>(sql).ToList();
        return houses;
    }

    internal House GetHouseById(int houseId)
    {
        string sql = "SELECT * FROM houses WHERE id = @houseId;";
        House house = _db.Query<House>(sql, new { houseId }).FirstOrDefault();
        return house;
    }

    internal int RemoveHouse(int houseId)
    {
        string sql = "DELETE FROM houses WHERE id = @houseId LIMIT 1;";
        int rows = _db.Execute(sql, new { houseId });
        return rows;
    }

    internal void UpdateHouse(House updateData)
    {
        string sql = @"
        UPDATE houses SET
        bedroom = @bedroom,
        bathroom = @bathroom,
        price = @price,
        yearmake = @yearmake,
        description = @description
        WHERE id = @id;";
        _db.Execute(sql, updateData);
    }
}
