using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EnterpriseArchitectManagement.Data;
using EnterpriseArchitectManagement.Models;

namespace EnterpriseArchitectManagement.Pages.Applications
{
    public class IndexModel : PageModel
    {
        private readonly EnterpriseArchitectManagement.Data.EnterpriseArchitectManagementContext _context;

        public IndexModel(EnterpriseArchitectManagement.Data.EnterpriseArchitectManagementContext context)
        {
            _context = context;
        }

        public IList<Application> Application { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Application != null)
            {
                Application = await _context.Application.ToListAsync();
            }
        }
    }
}
