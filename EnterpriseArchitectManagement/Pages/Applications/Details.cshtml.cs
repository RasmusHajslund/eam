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
    public class DetailsModel : PageModel
    {
        private readonly EnterpriseArchitectManagement.Data.EnterpriseArchitectManagementContext _context;

        public DetailsModel(EnterpriseArchitectManagement.Data.EnterpriseArchitectManagementContext context)
        {
            _context = context;
        }

      public Application Application { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Application == null)
            {
                return NotFound();
            }

            var application = await _context.Application.FirstOrDefaultAsync(m => m.ID == id);
            if (application == null)
            {
                return NotFound();
            }
            else 
            {
                Application = application;
            }
            return Page();
        }
    }
}
