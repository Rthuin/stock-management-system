using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Stock
	{
		[Key]
		public int StockID { get; set; }

	
		[MaxLength(50)]
		public string? StockCode { get; set; }

		
		[ForeignKey("Product")]
		[MaxLength(50)]
		public string? ProductCode { get; set; }

		[Required]
		[ForeignKey("Admin")]
		public int AdminID { get; set; } // Admin who added the stock

		[ForeignKey("User")]
		public int UserID { get; set; }

        public DateTime Date { get; set; }

        [Required]
		public int Quantity { get; set; }

		public virtual Product Product { get; set; }
		public virtual Admin Admin { get; set; }
		public virtual User User{ get; set; }
	}
}
