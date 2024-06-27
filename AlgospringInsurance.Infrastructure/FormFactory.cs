using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public TForm Create<TForm>() where TForm : Form
        {
            return serviceProvider.GetRequiredService<TForm>();
        }
    }
}
