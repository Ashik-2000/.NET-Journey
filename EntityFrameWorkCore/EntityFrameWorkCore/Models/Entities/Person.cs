using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkCore.Models.Entities;

public class Person
{
    [Key]
    public Guid PersonId { get; set; }
    [StringLength(40)]
    public string PersonName { get; set; } = string.Empty;
    [StringLength(40)]
    public string Email { get; set; } = string.Empty;
    public DateTime DateofBirth { get; set; }
    public string? Gender { get; set; }
    public Guid? CountryId { get; set; }
    [StringLength(100)]
    public string Address { get; set; } = string.Empty;
    public bool RecievedNewsLetters { get; set; }
    public Country? Country { get; set; }
}
