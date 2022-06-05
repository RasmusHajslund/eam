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
    public class DeleteModel : PageModel
    {
        private readonly EnterpriseArchitectManagement.Data.EnterpriseArchitectManagementContext _context;

        public DeleteModel(EnterpriseArchitectManagement.Data.EnterpriseArchitectManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Application == null)
            {
                return NotFound();
            }
            var application = await _context.Application.FindAsync(id);

            if (application != null)
            {
                Application = application;
                _context.Application.Remove(Application);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
