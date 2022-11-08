using HomeWork12.Proxy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Proxy
{
    public class DoublingActor : IActivity
    {
        private MainActor _mainActor;

        public DoublingActor(MainActor mainActor)
        {
            _mainActor = mainActor;
        }

        public void Movie()
        {
            _mainActor.Movie();
            Console.WriteLine(" ... With Danger Activity");
        }
    }
}
