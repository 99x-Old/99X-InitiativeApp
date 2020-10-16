using System.ComponentModel.DataAnnotations;

namespace InitiativeApp.API.Models
{
    public class Comment
    {
		[Key]
        public int CommentId { get; set; }
		public string CommentContent { get; set; }	
		public int ActionId { get; set; }
    }
}