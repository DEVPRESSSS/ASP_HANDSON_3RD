using System.ComponentModel.DataAnnotations;

namespace ASP_HANDS_ON_3RDYEAR.Models
{
    public class Calculator
    {

        [Required]
        public double fisrtNumber { get; set; }
        [Required]
        public double SecondNumber { get; set; }

        public double Result {  get; set; }

    }
}
