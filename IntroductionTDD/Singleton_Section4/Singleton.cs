using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Section4
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        static Singleton()
        {
            _instance = new Singleton();
        }

        public static Singleton Instance
        {
            get { return _instance; }
        }
    }
}
