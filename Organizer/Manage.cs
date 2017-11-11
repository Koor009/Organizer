using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Organizer
{
    class Manage
    {
        public void Added()
        {
            using (NoteContext db = new NoteContext())
            {
                var note = db.Notes; 
                Console.WriteLine("Do you want create new note");
                string someChoose = Console.ReadLine();
                if (someChoose.ToLower() == "yes")
                {
                    Console.WriteLine("Write name note");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write text note");
                    string text = Console.ReadLine();

                    db.Notes.Add(new Note() { Name = name, Text = text, Date = DateTime.UtcNow });
                    db.SaveChanges();
                }
                Console.WriteLine("Show all Notes");
                string someState = Console.ReadLine();
                if (someState.ToLower() == "yes")
                {
                    foreach (var nt in note)
                    {
                        Console.WriteLine($"{nt.Id}.{nt.Name} = {nt.Text} : {nt.Date}");
                    }
                }
            }    
        }
        public void Edited()
        {
            Console.WriteLine("How you want delete element ");
            int chooseId =int.Parse(Console.ReadLine());
            using (NoteContext db = new NoteContext())
            {
                var note = db.Notes;
                Note noteForDelete = note.FirstOrDefault(n=>n.Id==chooseId);
                if (noteForDelete != null)
                {
                    db.Entry(noteForDelete).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("This index empty");
                }
                Console.WriteLine("Show all Notes");
                string someState = Console.ReadLine();
                if (someState.ToLower() == "yes")
                {
                    foreach (var nt in note)
                    {
                        Console.WriteLine($"{nt.Id}.{nt.Name} = {nt.Text} : {nt.Date}");
                    }
                }
            }
        }
        public void ModifiedText()
        {
            Note nodeForModification;
            Console.WriteLine("Select to change Id");
            int chooseId = int.Parse(Console.ReadLine());
            
            using (NoteContext db = new NoteContext())
            {
                var note = db.Notes;
                nodeForModification = note.FirstOrDefault(nots => nots.Id == chooseId);
                Console.WriteLine("Select to change Text");
                string chooseText = Console.ReadLine();
                nodeForModification.Text = chooseText;
                db.SaveChanges();
                Console.WriteLine("Show all Notes");
                string someState = Console.ReadLine();
                if (someState.ToLower() == "yes")
                {
                    foreach (var nt in note)
                    {
                        Console.WriteLine($"{nt.Id}.{nt.Name} = {nt.Text} : {nt.Date}");
                    }
                }
            }
        }
        public void ModifiedName()
        {
            Note nodeForModification;
            Console.WriteLine("Select to change Id");
            int chooseId = int.Parse(Console.ReadLine());

            using (NoteContext db = new NoteContext())
            {
                var note = db.Notes;
                nodeForModification = note.FirstOrDefault(nots => nots.Id == chooseId);
                Console.WriteLine("Select to change Name");
                string chooseText = Console.ReadLine();
                nodeForModification.Name = chooseText;
                db.SaveChanges();
                Console.WriteLine("Show all Notes");
                string someState = Console.ReadLine();
                if (someState.ToLower() == "yes")
                {
                    foreach (var nt in note)
                    {
                        Console.WriteLine($"{nt.Id}.{nt.Name} = {nt.Text} : {nt.Date}");
                    }
                }
            }
        }
        public void ModifiedDate()
        {
            Note nodeForModification;
            Console.WriteLine("Select to change Id");
            int chooseId = int.Parse(Console.ReadLine());

            using (NoteContext db = new NoteContext())
            {
               
                var note = db.Notes;
                nodeForModification = note.FirstOrDefault(nots => nots.Id == chooseId);
                Console.WriteLine("Select to change Text");
                string choose = Console.ReadLine();
                Console.WriteLine("Set Year");
                int dateYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Set Month");
                int dateMonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Set Day");
                int dateDay = int.Parse(Console.ReadLine());
                Console.WriteLine("Set Hour");
                int dateHour = int.Parse(Console.ReadLine());
                Console.WriteLine("Set Minutes");
                int dateMinutes = int.Parse(Console.ReadLine());
                Console.WriteLine("Set Second");
                int dateSecond = int.Parse(Console.ReadLine());
                nodeForModification.Date = new DateTime(dateYear,dateMonth,dateDay,dateHour,dateMinutes,dateSecond);
                db.SaveChanges();
                Console.WriteLine("Show all Notes");
                string someState = Console.ReadLine();
                if (someState.ToLower() == "yes")
                {
                    foreach (var nt in note)
                    {
                        Console.WriteLine($"{nt.Id}.{nt.Name} = {nt.Text} : {nt.Date}");
                    }
                }
            }
        }
    }
}
