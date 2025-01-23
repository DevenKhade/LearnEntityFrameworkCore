using Microsoft.EntityFrameworkCore;

namespace EFCoreWebApi.Data
{
    public class AppDbContext :DbContext
    {
        // make constructore of class and give them options value from  child to parent
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            

        }
    }
}
