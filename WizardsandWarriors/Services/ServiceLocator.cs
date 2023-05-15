using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsandWarriors.Services
{
    internal class ServiceLocator : IServiceLocator
    {
        private readonly Dictionary<Type, object> _services = new();
        public T? GetService<T>()
        {
            _services.TryGetValue(typeof(T), out var result);
            return (T?)result;
        }
        public void Register<TInterface, TImpl>()
            where TInterface : notnull
            where TImpl : TInterface, new()
        {
            Register<TInterface>(new TImpl());
        }
        public void Register<T>(T service) where T : notnull
        {
            _services[typeof(T)] = service;
        }
    }
}
