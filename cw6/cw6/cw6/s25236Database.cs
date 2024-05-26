using Microsoft.EntityFrameworkCore;

namespace cw6;

public class s25236Database : DbContext
{
    public s25236Database()
    {
    }
    public s25236Database(DbContextOptions<s25236Database> options) :base(options)
    {
    }
}