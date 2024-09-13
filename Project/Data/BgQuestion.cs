using System.ComponentModel.DataAnnotations;

namespace Project.Data
{
	public class BgQuestion
	{
		public int Id { get; set; }

		[MaxLength(100)]
		public string Text { get; set; } = string.Empty;
		public IEnumerable<string> Options { get; set; } = new List<string>();
		[MaxLength(100)]
		public string CorrectOption { get; set; } = string.Empty;
	}
}
