using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Organizer
{
    class NoteContext : DbContext
    {
        public NoteContext() : base("NoteDb")
        { }
        public DbSet<Note> Notes { get; set; }
    }
}
