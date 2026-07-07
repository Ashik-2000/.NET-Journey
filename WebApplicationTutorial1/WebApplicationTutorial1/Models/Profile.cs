using System.ComponentModel.DataAnnotations;

namespace WebApplicationTutorial1.Models
{
    public class Profile
    {
        public string Name { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string Phone { get; init; } = string.Empty;
        public DateOnly Birth { get; init; }
        public int Gender { get; init; }
        public decimal Height { get; init; }
        public decimal Weight { get; init; }
        public string? EmergencyName { get; init; }
        public string? EmergencyPhone { get; init; }
        public string Division { get; init; } = string.Empty;
        public string City { get; init; } = string.Empty;
        public string Address { get; init; } = string.Empty;
        public int FitnesssGoal { get; init; }
        public int Membership { get; init; }
        public string? MedicalNote { get; init; }

        public override string ToString()
        {
            return $"Name = {Name}" +
                $"Email = {Email}" +
                $"Phone = {Phone}" +
                $"Date of Birth = {Birth}" +
                $"Gender = {Gender}" +
                $"Height (ft) = {Height}" +
                $"Weight (Kg) = {Weight}" +
                $"Emergency Name = {EmergencyName}" +
                $"Emergency Phone = {EmergencyPhone}" +
                $"Division = {Division}" +
                $"City = {City}" +
                $"Address = {Address}" +
                $"Fitness Goal = {FitnesssGoal}" +
                $"Membership Plan = {Membership}" +
                $"Mediacal Note = {MedicalNote}";
        }
    }
}
