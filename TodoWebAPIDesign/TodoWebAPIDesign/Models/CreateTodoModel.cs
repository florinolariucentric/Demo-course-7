using System.ComponentModel.DataAnnotations;

namespace TodoWebAPIDesign.Models
{
    public class CreateTodoModel
    {
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        public bool IsCompleted { get; set; }
    }
}
