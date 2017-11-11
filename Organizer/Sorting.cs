using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Organizer
{
    class Sorting
    {
        public void SortedNote()
        {
            using (NoteContext db = new NoteContext())
            {
                var note = db.Notes;
                Console.WriteLine("You want sorted our data base?");
                string someEvent = Console.ReadLine();

                if (someEvent == "Yes" || someEvent == "yes")
                {
                    while (someEvent == "Yes" || someEvent == "yes")
                    {
                        Console.WriteLine("How are you want sorted our notes: Date, Name, Id");
                        string searchCriteria = Console.ReadLine();
                        switch (searchCriteria)
                        {
                            case "Id":
                            case "id":
                                var sortedNodeId = note.OrderBy(n => n.Id);
                                Console.WriteLine();
                                foreach (Note item in sortedNodeId)
                                {
                                    Console.WriteLine($"{item.Id}.{item.Name} = {item.Text} : {item.Date}");
                                }
                                break;
                            case "Name":
                            case "name":
                                var sortedNodeName = note.OrderBy(n => n.Name);
                                Console.WriteLine();
                                foreach (Note item in sortedNodeName)
                                {
                                    Console.WriteLine($"{item.Id}.{item.Name} = {item.Text} : {item.Date}");
                                }
                                break;
                            case "Date":
                            case "date":
                                var sortedNodeDate = note.OrderBy(n => n.Date);
                                Console.WriteLine();
                                foreach (Note item in sortedNodeDate)
                                {
                                    Console.WriteLine($"{item.Id}.{item.Name} = {item.Text} : {item.Date}");
                                }
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("Do you want sorted again");
                        someEvent = Console.ReadLine();
                    
                    }
                }
            }
        }
    }
}
