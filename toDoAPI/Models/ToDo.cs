using System.ComponentModel.DataAnnotations;

namespace toDoAPI.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string? ToDoName { get; set; }
    }
}
