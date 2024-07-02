namespace AlgospringInsurance.Infrastructure.Contracts
{
    public interface IValidationProvider
    {
        bool ValidateAll(List<Func<bool>> validationFunctions);

        bool Required(Control control, ErrorProvider errorProvider);

        bool Length(int length, Control control, ErrorProvider errorProvider);

        bool MinLength(int minimumLength, Control control, ErrorProvider errorProvider);

        bool Email(Control control, ErrorProvider errorProvider);
    }
}
