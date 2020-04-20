using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotesTracker.Models;

namespace NotesTracker.Data
{
    public class NotesTrackerContext : DbContext
    {
        public NotesTrackerContext (DbContextOptions<NotesTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<NotesTracker.Models.Note> Note { get; set; }
    }
}
