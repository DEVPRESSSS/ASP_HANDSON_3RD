using System.ComponentModel.DataAnnotations;

namespace ASP_HANDS_ON_THIRDYEAR.Models
{
    public class Convert
    {
        [Required]
        public double Peso { get; set; }
        [Required]

        public double Dollar { get; set; }
        public double Convertion { get; set;}

    }
}
