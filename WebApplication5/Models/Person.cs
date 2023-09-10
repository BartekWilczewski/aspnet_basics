using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Person : BaseEntity
    {
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Wiek")]
        public int Age { get; set; }
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
    }
}
