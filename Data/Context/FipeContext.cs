using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    internal class FipeContext : DbContext
    {
        #region
        public DbSet<FipeInfo> fipeInfo { get; set; }
        
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("host=localhost; Port=5436; Database=postgres; UserId=postgres; Password=123456");
        }
    }


}
