using System;
using System.Collections.Generic;
using System.Linq;

namespace Organizer
{
    internal class Sorting
    {
        private readonly string someEvent = "yes";
        public void SortedNote()
        {
            using (NoteContext db = new NoteContext())
            {
                Console.WriteLine("You want sorted our data base?");
                string ask = Console.ReadLine()?.ToLower();
                    while (someEvent == ask)
                    {
                        Console.WriteLine("How are you want sorted our notes: date, name, id");
                    string searchCriteria = Console.ReadLine()?.ToLower();
                        switch (searchCriteria)
                        {
                            case "id":
                                IEnumerable<Note> sortedNodeId = db.Notes.OrderBy(note => note.Id);
                                ShowSort(sortedNodeId);                                
                            break;
                            case "name":
                                IEnumerable<Note> sortedNodeName = db.Notes.OrderBy(note => note.Name);
                                ShowSort(sortedNodeName);
                                break;
                            case "date":
                                IEnumerable<Note> sortedNodeDate = db.Notes.OrderBy(note => note.Date);
                                ShowSort(sortedNodeDate);
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("Do you want sorted again");
                        ask = Console.ReadLine();
                    }
            }
        }
        public void ShowSort(IEnumerable<Note> sort)
        {
                foreach (Note note in sort)
                {
                    Console.WriteLine($"{note.Id}. {note.Name} = {note.Text} : {note.Date}");
                }
        }
    }
}
