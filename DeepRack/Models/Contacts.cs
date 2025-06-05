using System.ComponentModel.DataAnnotations;


namespace DeepRack.Models;

public class Contacts
{
    [Key]
    public int Id { get; set; }
    [Required] public string Name { get; set; }
    public string Email { get; set; }
    [Required] public string Phone { get; set; }
    public string Address { get; set; }
    public string Notes { get; set; }
}