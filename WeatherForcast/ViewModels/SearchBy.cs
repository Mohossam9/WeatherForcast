using System.ComponentModel.DataAnnotations;

namespace WeatherForcast.Models
{
    public class SearchBy
    {
        [Required]
        [RegularExpression("[a-z A-Z]{3,}", ErrorMessage = "Invalid City Name Should Be English Only With More Than 2 characters")]

        [MaxLength(30, ErrorMessage = "Invalid City Name Should Be Less Than 30 Characters")]        
        public string Name { get; set; }    
    }
}
