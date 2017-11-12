using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Organizer
{
    internal class Manage : IManage
    {
        public readonly string _stateAsk = "yes";
        private int _id;
        public void Add()
        {
            using (NoteContext db = new NoteContext())
            { 
                IDbSet<Note> _notes = db.Notes;
                Console.WriteLine("Do you want create new note");
                string someChoose = Console.ReadLine();
                if (someChoose.ToLower() == _stateAsk)
                {
                    Console.WriteLine("Write name note");
                    string _name = Console.ReadLine();

                    Console.WriteLine("Write text note");
                    string _text = Console.ReadLine();

                    db.Notes.Add(new Note()
                    {
                        Name = _name,
                        Text = _text,
                        Date = DateTime.UtcNow
                    });
                    db.SaveChanges();
                    GetNote();
                }               
            }
        }

        public void Delete()
        {
           Console.WriteLine("How you want delete element ");
            
            int _id;
            int.TryParse(Console.ReadLine(),out _id);
            using (NoteContext db = new NoteContext())
            {
                IDbSet<Note> notes = db.Notes;
                Note noteForDelete = notes.FirstOrDefault(note => note.Id == _id);
                if (noteForDelete != null)
                {
                    db.Entry(noteForDelete).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("This index empty");
                }
                GetNote();
            }
        }

        public void Edit()
        {
            int _id;
            int.TryParse(Console.ReadLine(), out _id);
            Console.WriteLine("Do you want edit note?");
            string someChoose = Console.ReadLine();
            if (someChoose.ToLower() == _stateAsk)
                using (NoteContext db = new NoteContext())
            {
                Note noteForEdit = db.Notes.FirstOrDefault(note => note.Id == _id);
                if (noteForEdit != null)
                {
                    Console.WriteLine("Edit name");
                    string name = Console.ReadLine();
                    noteForEdit.Name = name;

                    Console.WriteLine("Edit text");
                    string text = Console.ReadLine();
                    noteForEdit.Name = text;

                    noteForEdit.Date = DateTime.UtcNow;
                    db.Entry(noteForEdit).State = EntityState.Modified;
                        db.SaveChanges();
                }
                GetNote();
            }
        }

        public void GetNote()
        {
            using (NoteContext db = new NoteContext())
            {
                Console.WriteLine("Show all Notes");
                string someState = Console.ReadLine();
                if (someState.ToLower() == _stateAsk)
                {
                    foreach (var note in db.Notes)
                    {
                        Console.WriteLine($"{note.Id}.{note.Name} = {note.Text} : {note.Date}");
                    }
                }
            }  
        }
    }
}
