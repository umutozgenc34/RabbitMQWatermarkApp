using Microsoft.EntityFrameworkCore;

namespace RabbitMQ.WatermarkApp.Models;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}
