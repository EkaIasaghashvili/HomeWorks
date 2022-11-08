using HomeWork12.Proxy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Proxy
{
    public class Film
    {
        public void Action(IActivity activity)
        {
            activity.Movie();
        }
    }
}
