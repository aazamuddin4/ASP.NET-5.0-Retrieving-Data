using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetrievingData.Model
{
    public class ConnectionDBClass:DbContext
    {
        public ConnectionDBClass(DbContextOptions<ConnectionDBClass> options):base(options)
        {

        }
        public DbSet<EmpClass> DimEmployee { get; set; }
    }
}
