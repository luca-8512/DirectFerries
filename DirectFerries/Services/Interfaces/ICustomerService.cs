namespace DirectFerries.Services
{
    public interface ICustomerService
    {
        int VowelCount(string name);
        int CalculateAge(DateTime dob);
        int GetDaysBeforeBirthday(DateTime dob, DateTime today);
    }
}
