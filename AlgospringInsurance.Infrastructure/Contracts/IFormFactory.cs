namespace AlgospringInsurance.Infrastructure.Contracts
{
    public interface IFormFactory
    {
        TForm Create<TForm>() where TForm : Form;
    }
}
