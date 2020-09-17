using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Simona.Models
{
    public class MDJBC: DbContext
    {

        public MDJBC(DbContextOptions<MDJBC> options) : base(options)
        {
        }

        public DbSet<MCustomer> customers { get; set; }
    }
}
