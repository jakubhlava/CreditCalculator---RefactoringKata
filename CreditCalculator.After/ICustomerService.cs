namespace CreditCalculator.After;

public interface ICustomerService
{
    bool AddCustomer(
        string firstName,
        string lastName,
        string email,
        DateTime dateOfBirth,
        int companyId);
}