using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Change_LayoutNetCoreMVC.Models
{
    public class Change_LayoutNetCoreMVCContext : DbContext
    {
        public Change_LayoutNetCoreMVCContext (DbContextOptions<Change_LayoutNetCoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Change_LayoutNetCoreMVC.Models.Member> Member { get; set; }
    }
}
