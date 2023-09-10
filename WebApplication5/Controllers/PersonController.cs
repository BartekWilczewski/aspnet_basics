using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    public class PersonController : Controller
    {
        private Repository<Person> _repository;
        public PersonController() 
        {
            _repository = new Repository<Person>();
            _repository.Add(new Person()
            {
                Id = 1,
                Age = 1,
                FirstName = "Anna",
                LastName = "Nowak",
                EmailAddress = "aa@wp.pl"
            });
            _repository.Add(new Person()
            {
                Id = 2,
                Age = 35,
                FirstName = "Jan",
                LastName = "Kowalski",
                EmailAddress = "jkow@o2.pl"
            });
        }

        public IActionResult Index()
        {
            ViewBag.Message = "This is my message";
            
            return View(_repository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_repository.FindById(id));
        }
    }
}
