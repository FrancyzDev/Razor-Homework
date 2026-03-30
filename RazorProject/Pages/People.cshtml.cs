using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1.Interfaces;
using Razor1.Models;

namespace Razor1.Pages
{
    public class PeopleModel : PageModel
    {
        private readonly IPersonService _personService;

        public PeopleModel(IPersonService personService)
        {
            _personService = personService;
        }

        public List<Person> People { get; set; } = new();

        public async Task OnGetAsync()
        {
            var people = await _personService.GetAllPersonsAsync();
            People = people.ToList();
        }
    }
}