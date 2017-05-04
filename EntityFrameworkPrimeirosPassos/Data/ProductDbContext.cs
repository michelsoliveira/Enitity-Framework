using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("Name=ProductDb")
        {
            Database.SetInitializer<ProductDbContext>(new CreateDatabaseIfNotExists<ProductDbContext>());
        }
    }
}
