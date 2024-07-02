using System.Text.RegularExpressions;
using AlgospringInsurance.Infrastructure.Contracts;

namespace AlgospringInsurance.Infrastructure
{
    public sealed class ValidationProvider : IValidationProvider
    {
        public bool ValidateAll(List<Func<bool>> validationFunctions)
        {
            var results = new List<bool>();

            foreach (var action in validationFunctions)
                results.Add(action.Invoke());

            return !results.Any(x => !x);
        }

        public bool Required(Control control, ErrorProvider errorProvider)
        {
            bool valid = false;

            if (string.IsNullOrWhiteSpace(control.Text))
                errorProvider.SetError(control, $"Required field.");
            else
            {
                errorProvider.SetError(control, string.Empty);
                valid = true;
            }

            return valid;
        }

        public bool Length(int length, Control control, ErrorProvider errorProvider)
        {
            bool valid = false;

            if (string.IsNullOrWhiteSpace(control.Text) || control.Text.Length != length)
                errorProvider.SetError(control, $"Length should be {length}.");
            else
            {
                errorProvider.SetError(control, string.Empty);
                valid = true;
            }

            return valid;
        }

        public bool MinLength(int minimumLength, Control control, ErrorProvider errorProvider)
        {
            bool valid = false;

            if (string.IsNullOrWhiteSpace(control.Text) || control.Text.Length < minimumLength)
                errorProvider.SetError(control, $"Minimum Length should be {minimumLength}.");
            else
            {
                errorProvider.SetError(control, string.Empty);
                valid = true;
            }

            return valid;
        }

        public bool Email(Control control, ErrorProvider errorProvider)
        {
            var valid = false;

            if (!Regex.IsMatch(control.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                errorProvider.SetError(control, $"Invalid email address.");
            else
            {
                errorProvider.SetError(control, string.Empty);
                valid = true;
            }

            return valid;
        }
    }
}
