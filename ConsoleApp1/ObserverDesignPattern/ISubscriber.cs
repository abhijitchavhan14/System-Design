using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObserverDesignPattern
{
    public interface ISubscriber
    {
        void Update(string videotitle);   
    }
}
