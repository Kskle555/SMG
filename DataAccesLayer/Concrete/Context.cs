using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context : IdentityDbContext <AppUser,AppRole,int>     /* IdentityDbContext context sınıfından miras alır. İkisini de kullanabilirsin*/  /*DbContext*/
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-01QE6IC;database=Smg_Yazilim; integrated security=true;");
        }



     
        public DbSet<Admin> Admins { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }
        public DbSet<Stock> Stocks { get; set; }


    }
}
