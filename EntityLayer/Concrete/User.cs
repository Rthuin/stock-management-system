using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        
        [MaxLength(100)]
        public string? UserName { get; set; }

        
        [MaxLength(100)]
        public string? UserPassword { get; set; }

        [MaxLength(100)]
        public string? UserEmail { get; set; }

        public bool IsApproved { get; set; } // Admin onayı için alan
        public virtual ICollection<Stock> Stocks { get; set; }


    }
}
