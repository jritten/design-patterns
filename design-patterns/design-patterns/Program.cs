using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public class Dependency
        {
            public void DoSomething()
            {
                Console.WriteLine("Did something");
            }

            public void DoSomethingElse()
            {
                Console.WriteLine("Did something else");
            }
        }

        public class Consumer
        {
            public void DoSomething(Dependency d)
            {
                d.DoSomething();
            }

            public void DoSomethingElse(Dependency d)
            {
                d.DoSomethingElse();
            }
        }
    }
}
