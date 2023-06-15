using Microsoft.EntityFrameworkCore;

namespace CodeFirstFirmaERD.Data
{
    public class DataContext : DbContext
    {
        //konstruktor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //tulemuste nägemiseks dbset
        public DbSet<Firma> Firmas => Set<Firma>();

    }
}
