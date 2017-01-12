using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Models
{
    public class Rent 
    {
        [Key]
        [Required]
        public int RentId { get; set; }
        public float Expense { get; set; }
        [Required]
        public DateTime DateOfHire { get; set; }
        public Nullable<DateTime> DateOfEnd { get; set; }
        public virtual User User { get; set; }
        public virtual Car Car { get; set; }
    }
}
