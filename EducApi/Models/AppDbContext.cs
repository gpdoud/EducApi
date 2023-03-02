using Microsoft.EntityFrameworkCore;

namespace EducApi.Models;

public class AppDbContext : DbContext {

    public DbSet<Major> Majors { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }


}
