using DirectFerries.Services;

namespace Xunit_Tests
{
    public class CustomerServiceTests
    {
        [Fact]
        public void VowelCount()
        {
            var customerService = new CustomerService();
            var vowels = customerService.VowelCount("luca");

            Assert.Equal(2, vowels);
        }

        [Fact]
        public void VowelCount_NoName()
        {
            var customerService = new CustomerService();
            var vowels = customerService.VowelCount("");

            Assert.Equal(0, vowels);
        }

        [Fact]
        public void CalculatAge()
        {
            var customerService = new CustomerService();
            var age = customerService.CalculateAge(new DateTime(1963, 1, 1));

            Assert.Equal(60, age);
        }

        [Fact]
        public void GetDaysBeforeBirthday_DOB_After()
        {
            var customerService = new CustomerService();
            var days = customerService.GetDaysBeforeBirthday(new DateTime(1963, 6, 1), new DateTime(2023, 6, 6));

            Assert.Equal(361, days);
        }

        [Fact]
        public void GetDaysBeforeBirthday_DOB_Before()
        {
            var customerService = new CustomerService();
            var days = customerService.GetDaysBeforeBirthday(new DateTime(1963, 6, 7), new DateTime(2023, 6, 6));

            Assert.Equal(1, days);
        }
    }
}