using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_EntityFramework.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
