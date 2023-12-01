using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ExamCCI_2023.Pages.Student
{
    public class DetailsModel : PageModel
    {
        private readonly Model.ApplicationDbContext _context;

        public DetailsModel(Model.ApplicationDbContext context)
        {
            _context = context;
        }

        public Model.Student Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                Student = student;
            }
            return Page();
        }
    }
}

