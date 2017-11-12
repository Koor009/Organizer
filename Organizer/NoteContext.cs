using System.Data.Entity;

namespace Organizer
{
    internal class NoteContext : DbContext
    { 
        public NoteContext() : base("NoteDb")
        { }
        public DbSet<Note> Notes { get; set; }
    }
}
