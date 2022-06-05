using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnterpriseArchitectManagement.Models;

namespace EnterpriseArchitectManagement.Data
{
    public class EnterpriseArchitectManagementContext : DbContext
    {
        public EnterpriseArchitectManagementContext (DbContextOptions<EnterpriseArchitectManagementContext> options)
            : base(options)
        {
        }

        public DbSet<EnterpriseArchitectManagement.Models.Application>? Application { get; set; }
    }
}
