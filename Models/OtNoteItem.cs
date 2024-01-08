using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opentools.Models
{
    public class OtNoteItem
    {
        public int Id { get; set; }
        public string OtNoteName { get; set; } = string.Empty;
        public string OtNoteDescription {  get; set; } = string.Empty;
        public DateTime OtCreateTime { get; set; }
        public DateTime OtCompletedTime { get; set; }
        public bool OtIsActive { get; set; }
    }
}
