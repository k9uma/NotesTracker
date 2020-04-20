using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NotesTracker.Data;
using NotesTracker.Models;

namespace NotesTracker.Pages.Notes
{
    public class IndexModel : PageModel
    {
        private readonly NotesTracker.Data.NotesTrackerContext _context;

        public IndexModel(NotesTracker.Data.NotesTrackerContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; }

        public async Task OnGetAsync()
        {
            Note = await _context.Note.ToListAsync();
        }
    }
}
