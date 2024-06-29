using Microsoft.Extensions.DependencyInjection;

namespace AlgospringInsurance.Infrastructure
{
    public class FormFactory : IFormFactory
    {
        private readonly IServiceProvider serviceProvider;

        public FormFactory(IServiceProvider services)
        {
            serviceProvider = services;
        }

        public TForm Create<TForm>() where TForm : Form => 
            serviceProvider.GetRequiredService<TForm>();
    }
}
