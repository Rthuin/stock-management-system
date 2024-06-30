using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Admin
	{
		[Key]
		public int AdminID { get; set; }

		[Required]
		[MaxLength(100)]
		public string AdminName { get; set; }

		[Required]
		[MaxLength(100)]
		public string AdminPassword { get; set; }

		[MaxLength(100)]
		public string AdminEmail { get; set; }

		[Required]
		[MaxLength(50)]
		public string AdminRole { get; set; } // Admin role, e.g., "Admin", "Manager"

		public ICollection<Stock> Stocks { get; set; }
    }
}
