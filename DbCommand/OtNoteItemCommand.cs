using opentools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opentools.DbCommand
{
    public class OtNoteItemCommand
    {

        // Add note to db
        public static void AddNoteItemDb(OtNoteItem otNoteItem)
        {
            using (var db = new OtNoteItemContext())
            {
                db.Add(otNoteItem);
                db.SaveChanges();
            }
        }

        // Load note item from db
        public static List<OtNoteItem> GetAllNoteItemDb()
        {
            using (var db = new OtNoteItemContext())
            {
                return db.OtNoteItem.OrderBy(i => i.Id).ToList();   
            }
        }

        // Removing note item
        public static void RmNoteItemDb(OtNoteItem otNoteItem)
        {
            using (var db = new OtNoteItemContext())
            {
                db.Remove(otNoteItem);
                db.SaveChanges();
            }
        }



    }
}
