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
            private Dependency d;
            public Consumer(Dependency d)
            {
                this.d = d;
            }
            public void DoSomething()
            {
                d.DoSomething();
            }

            public void DoSomethingElse()
            {
                d.DoSomethingElse();
            }
        }

        public class Dependency1
        {
            public void DoSomething()
            {
                Console.WriteLine("Did something");
            }
        }

        public class Dependency2
        {
            public void DoSomethingElse()
            {
                Console.WriteLine("Did something else");
            }
        }

        public class Consumer2
        {
            public void DoSomething(Dependency1 d)
            {
                d.DoSomething();
            }

            public void DoSomethingElse(Dependency2 d)
            {
                d.DoSomethingElse();
            }
        }
    }
}
