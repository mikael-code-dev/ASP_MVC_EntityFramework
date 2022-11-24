using ASP_MVC_EntityFramework.Models;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_EntityFramework.ViewModels
{
    public class PersonViewModel
    {
        //public int Id { get; set; } 

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name:")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone Number is Required")]
        [Display(Name = "Phone Number:")]
        public string PhoneNumber { get; set; } = string.Empty;

        public Country Country { get; set; }
        public int CountryId { get; set; }




        [Display(Name = "City:")]
        [Required(ErrorMessage = "City is Required")]
        public City? City { get; set; }

        [Display(Name = "City:")]
        [Required(ErrorMessage = "City is Required")]
        public int CityId { get; set; }



        [Display(Name = "Language:")]
        [Required(ErrorMessage = "Language is Required")]
        public Language? Language { get; set; }

        public int LanguageId { get; set; }
    }
}
