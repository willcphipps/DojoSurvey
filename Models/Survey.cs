using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required (ErrorMessage = "Name Must be more than 2 characters")]
        [MinLength (2)]
        public string Name { get; set; }
        [Required(ErrorMessage="Must Choose Location!")]
        [MinLength(3)]
        public string Location { get; set; }
        [Required(ErrorMessage="Must Choose Favorite Language!")]
        [MinLength(3)]
        public string Language { get; set; }
        [Required (ErrorMessage = "Name Must be more than 2 characters")]
        [MaxLength (20)]
        public string Message { get; set; }
    }
}