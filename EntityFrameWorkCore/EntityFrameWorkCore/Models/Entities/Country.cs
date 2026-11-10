using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkCore.Models.Entities;

public class Country
{
    [Key]
    public Guid CountyId { get; set; }
    public string CountryName { get; set; } = string.Empty;
}
