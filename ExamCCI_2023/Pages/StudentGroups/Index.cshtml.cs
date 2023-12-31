﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Model;

namespace ExamCCI_2023.Pages.StudentGroups
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<StudentGroup> StudentGroup { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.StudentGroups != null)
            {
                StudentGroup = await _context.StudentGroups.ToListAsync();
            }
        }
    }
}
