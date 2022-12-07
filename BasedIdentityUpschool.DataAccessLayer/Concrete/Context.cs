using BasedIdentityUpschool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedIdentityUpschool.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        // Burada identity core eklenmeyince almak istediğimiz context yalan oluyor.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB ; initial catalog=UpSchoolDb01; integrated security = true;");

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //override hata mesajlarında kullandığımız da override 
    }
}
