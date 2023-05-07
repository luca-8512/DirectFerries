namespace DirectFerries.Services
{
    public class CustomerService : ICustomerService
    {
        public int VowelCount(string name)
        {
            int total = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                {
                    total++;
                }
            }

            return total;
        }

        public int CalculateAge(DateTime dob)
        {
            return DateTime.Today.Year - dob.Year;
        }

        public int GetDaysBeforeBirthday(DateTime dob, DateTime today)
        {
            dob = new DateTime(DateTime.Today.Year, dob.Month, dob.Day);

            if (dob < today)
                dob = dob.AddYears(1);

            return (dob - today).Days;
        }
    }
}
