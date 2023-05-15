using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsandWarriors.Services
{
    public interface IServiceLocator
    {
        void Register<TInterface, TImpl>()
            where TInterface : notnull
            where TImpl : TInterface, new();

        void Register<T>(T service)
            where T : notnull;
        T? GetService<T>();
    }
}
