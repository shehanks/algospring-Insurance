namespace AlgospringInsurance.Infrastructure
{
    public interface IValidationProvider
    {
        bool ValidateAll(List<Func<bool>> validationFunctions);

        bool Required(Control control, ErrorProvider errorProvider);

        bool Length(int minimumLength, Control control, ErrorProvider errorProvider);

        bool Email(Control control, ErrorProvider errorProvider);
    }
}
