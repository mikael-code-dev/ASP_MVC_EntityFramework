using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_EntityFramework.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        //public Person()
        //{

        //}

        //public Person(int id, string name, string phoneNumber, string city)
        //{
        //    Id = id;
        //    Name = name;
        //    PhoneNumber = phoneNumber;
        //    City = new City(city);
        //}
    }

}
