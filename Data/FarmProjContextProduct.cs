using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FarmProj.Models;

namespace FarmProj.Data
{
    public class FarmProjContextProduct : DbContext
    {
        public FarmProjContextProduct (DbContextOptions<FarmProjContextProduct> options)
            : base(options)
        {
        }

        public DbSet<FarmProj.Models.Product> Product { get; set; } = default!;
        public DbSet<FarmProj.Models.Brand> Brand { get; set; } = default!;
    }
}
