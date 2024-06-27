namespace AlgospringInsurance.Infrastructure
{
    public interface IFormFactory
    {
        TForm Create<TForm>() where TForm : Form;
    }
}
