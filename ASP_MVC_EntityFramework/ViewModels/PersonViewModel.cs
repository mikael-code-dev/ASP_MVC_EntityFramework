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

        [Display(Name = "City:")]
        [Required(ErrorMessage = "Book name is Required")]
        public string City { get; set; }
    }
}
