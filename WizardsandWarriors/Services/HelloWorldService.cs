using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardsandWarriors.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public void Hello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
