using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using STOREPHONE.Models;

namespace STOREPHONE.Data
{
    public class STOREPHONEContext : DbContext
    {
        public STOREPHONEContext (DbContextOptions<STOREPHONEContext> options)
            : base(options)
        {
        }

        public DbSet<STOREPHONE.Models.phone> phone { get; set; } = default!;
    }
}
