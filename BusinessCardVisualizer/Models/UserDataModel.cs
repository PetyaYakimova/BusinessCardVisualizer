using System.ComponentModel.DataAnnotations;

namespace BusinessCardVisualizer.Models
{
	public class UserDataModel
	{
		[Required(ErrorMessage = "Name is required.")]
		[StringLength(50, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 50 characters.")]
		public string Name { get; set; } = null!;

		[Required(ErrorMessage = "Position is required.")]
		[StringLength(20, MinimumLength = 2, ErrorMessage = "Position must be between 2 and 20 characters.")]
		public string Position { get; set; } = null!;

		[Required(ErrorMessage = "Phone is required.")]
		[StringLength(20, MinimumLength = 8, ErrorMessage = "Phone must be between 8 and 20 characters.")]
		public string Phone { get; set; } = null!;

		[StringLength(50, ErrorMessage = "Email must be no more than 50 characters.")]
		[EmailAddress(ErrorMessage = "Email must be in valid format.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Company is required.")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Company must be between 2 and 50 characters.")]
		public string Company { get; set; } = null!;
	}
}
