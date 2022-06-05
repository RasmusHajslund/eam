using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EnterpriseArchitectManagement.Data;
using EnterpriseArchitectManagement.Models;

namespace EnterpriseArchitectManagement.Pages.Applications
{
    public class CreateModel : PageModel
    {
        private readonly EnterpriseArchitectManagement.Data.EnterpriseArchitectManagementContext _context;

        public CreateModel(EnterpriseArchitectManagement.Data.EnterpriseArchitectManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Application Application { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Application == null || Application == null)
            {
                return Page();
            }

            //var emptyStudent = new Student();
            var emptyApplication = new Application();
            if (await TryUpdateModelAsync<Application>(
                emptyApplication,
                "Application", // Prefix for form value.
                s=> s.Name, s=>s.Description, s=>s.GoLiveDate))
            {
                _context.Application.Add(Application);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
