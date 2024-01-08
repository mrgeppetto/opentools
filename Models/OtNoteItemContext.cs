using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opentools.Models
{
    public class OtNoteItemContext : DbContext
    {
        public DbSet<OtNoteItem> OtNoteItem {  get; set; }
        public string path = @"./Database/otnotes.db";
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={path}");

    }
}
