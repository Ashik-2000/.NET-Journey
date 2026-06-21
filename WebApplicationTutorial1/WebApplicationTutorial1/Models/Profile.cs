using System.ComponentModel.DataAnnotations;

namespace WebApplicationTutorial1.Models
{
    public class Profile
    {
        [Required]
        public string Name { get; init; } = String.Empty;
        [Range(25, 60)]
        public int Age { get; init; }
        public string City { get; init; } = string.Empty;
        public int Weight { get; init; }

        public override string ToString()
        {
            return $"Hi, {Name} from {City}. We, see you're {Age} years old and weigthts {Weight}kg. " +
                $"Legt's see what can we achive with that.";
        }
    }
}
