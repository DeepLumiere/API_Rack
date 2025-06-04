using System.ComponentModel.DataAnnotations;

namespace DeepRack.Models;

public class Notes
{
    [Key] public int Id { get; set; }

    [Required] public string Title { get; set; }

    [Required] public string Author { get; set; }

    [Required] public DateTime Date { get; set; }

    [Required] public string Content { get; set; }
}