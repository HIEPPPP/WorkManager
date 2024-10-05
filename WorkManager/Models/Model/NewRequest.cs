using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManager.Models.Model
{
    [Table("NewRequest")]
    public class NewRequest
    {
        [Key]
        public int Id { get; set; }
        public string RequestType { get; set; }
        public string Department { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;    
        public bool IsHandled { get; set; } = false;
    }
}
