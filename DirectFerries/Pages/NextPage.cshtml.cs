using DirectFerries.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DirectFerries.Pages
{
    public class NextPageModel : PageModel
    {
        private readonly ICustomerService _customerService;
        public string Name { get; set; } = String.Empty;
        public DateTime DOB { get; set; }
        public int Vowel { get; set; }
        public int Age { get; set; }
        public int DaysBeforeBirthday { get; set; }
        public DateTime RunupDOB { get; set; }

        public NextPageModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public void OnGet([FromRoute] string name, [FromRoute] DateTime dob)
        {
            Name = name;
            DOB = dob;

            var customerService = new CustomerService();
            Vowel = customerService.VowelCount(Name);
            Age = customerService.CalculateAge(DOB);
            DaysBeforeBirthday = customerService.GetDaysBeforeBirthday(DOB, DateTime.Today);

            if (DOB < DateTime.Today)
                RunupDOB = new DateTime(DateTime.Today.AddYears(1).Year, DOB.Month, DOB.Day);
            else
                RunupDOB = DOB;
        }
    }
}
