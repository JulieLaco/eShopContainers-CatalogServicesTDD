using CatalogServicesTDD.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogServicesTDD.Context
{
    public class CatalogContext : DbContext
    {
        public CatalogContext()
        {
        }

        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
    }
}
