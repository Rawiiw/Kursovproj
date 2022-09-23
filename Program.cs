using System;
using System.Threading;
using System.Threading.Tasks;
using pob;

namespace Pobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(pob.pobot());
        }
    }
}
