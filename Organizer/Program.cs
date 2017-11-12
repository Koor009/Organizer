using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Organizer
{
    class Program
    { 
        static void Main(string[] args)
        {
            using (NoteContext db = new NoteContext())
            {
                //db.Notes.Add(new Note { Name = "NoteMe", Text = "Get salery", Date = new DateTime(2015, 7, 20, 18, 30, 25) });
                //db.Notes.Add(new Note { Name = "ANoteMeAgain", Text = "Get ny friend salery", Date = new DateTime(2017, 3, 16, 18, 10, 25) });
                db.SaveChanges();
                var note = db.Notes;
                foreach (var nt in note)
                {
                    Console.WriteLine($"{nt.Id}.{nt.Name} = {nt.Text} : {nt.Date}");
                } 
                
            }
            Console.WriteLine("Do you want to do operation(yes/no): 1-delete,  2-modif 3-add");
            string someAction = Console.ReadLine();
            if (someAction.ToLower() == "yes")
            {
                Operation operation = new Operation();
                operation.SomeOperation();
            } 




        }
    }
}
