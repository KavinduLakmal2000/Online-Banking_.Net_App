using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet__1.Models
{
	public class Transaction
	{
		[Key]
        
        public int transactionID { get; set; }

		[Column(TypeName = "nvarchar(12)")]
		[DisplayName("Transaction Name")]
		[Required(ErrorMessage ="This field is required!")]
		public string transactionName { get; set; }

		[Column(TypeName = "nvarchar(100)")]
        [DisplayName("Transaction Type")]
        [Required(ErrorMessage = "This field is required!")]
        public string transactionType { get; set; }

		[Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required!")]
		[MaxLength(12, ErrorMessage ="Maximum 12 Characters only!")]
        public string bankName { get; set; }


	}
}
