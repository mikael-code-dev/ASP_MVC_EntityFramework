using ASP_MVC_EntityFramework.Models;

namespace ASP_MVC_EntityFramework.ViewModels
{
    public class PeopleViewModel
    {
        public static List<Person> listOfPeople { get; set; } = new();

        public List<Person> temptList { get; set; } = new();

        public PersonViewModel PeopleCrudFunctions { get; set; } = new();
    }
}
