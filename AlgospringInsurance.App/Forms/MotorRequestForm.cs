using AlgospringInsurance.Infrastructure.Contracts;

namespace AlgospringInsurance.App.Forms
{
    public partial class MotorQuoteRequestForm : Form
    {
        private readonly IValidationProvider validationProvider;

        public MotorQuoteRequestForm(IValidationProvider validationProvider)
        {
            this.validationProvider = validationProvider;
            InitializeComponent();
        }

        #region Control Events

        private void LoadDataButtonClick(object sender, EventArgs e)
        {
            if (!IsValidUserInput())
                return;
        }

        private void MobileNoTextChanged(object sender, EventArgs e) => 
            ValidateMobileNo();

        private void MobileNumberKeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        #endregion

        #region Validations

        private bool IsValidUserInput() =>
            validationProvider.ValidateAll(new List<Func<bool>>()
            {
                () => ValidateMobileNo()
            });

        private bool ValidateMobileNo() =>
            validationProvider.Required(MobileNo, MobileNoErrorProvider) &&
            validationProvider.Length(10, MobileNo, MobileNoErrorProvider);

        #endregion
    }
}
