using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var  customeManager = CustomerManager.CreateAsSingleton();           
            customeManager.Save();
        }
    }
    class CustomerManager
    {
        private static CustomerManager _customerManager;
        static object _lockObject = new object();
        public CustomerManager()
        {

        }
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
                return _customerManager;
            }
        }
        public void Save()
        {
            Console.WriteLine("Saved!!");
            Console.Read();
        }
    }
}
