using Microsoft.EntityFrameworkCore;

namespace ProduktCyfrowy;

public class RoomContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=Database\Rooms.db");
}

public class Room
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Reservations { get; set; }
    public bool ComputersAvailable { get; set; }
    public int NumberOfSeats { get; set; }
    public string RoomSupervisor { get; set; }
}
