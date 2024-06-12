using Microsoft.EntityFrameworkCore;
using ProduktCyfrowy.Migrations;

namespace ProduktCyfrowy;

public class RoomContext : DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=Database\Rooms.db").UseLazyLoadingProxies();
}

public class Room
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool ComputersAvailable { get; set; }
    public int NumberOfSeats { get; set; }
    public Guid? SupervisorId { get; set; }

    public virtual ICollection<Reservation>? Reservations { get; set; } = new HashSet<Reservation>();
    public virtual User? Supervisor { get; set; }

    public string SupervisorFullName()
    {
        return Supervisor is not null ? Supervisor.FirstName + " " + Supervisor.LastName : "";
    }
}

public class Reservation
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid RoomId { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }

    public virtual User? User { get; set; }
    public virtual Room? Room { get; set; }

    public Reservation(Guid id, Guid userId, Guid roomId, DateTime dateFrom, DateTime dateTo)
    {
        Id = id;
        UserId = userId;
        RoomId = roomId;
        DateFrom = dateFrom;
        DateTo = dateTo;
    }
}



public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string PasswordSalt { get; set; }
    public Guid RoleId { get; set; }

    public virtual Role? Role { get; set; }
    public virtual ICollection<Reservation>? Reservations { get; set; } = new HashSet<Reservation>();


}

public class Role
{
    public Guid Id { get; set; }
    public string Name { get; set; }

}

