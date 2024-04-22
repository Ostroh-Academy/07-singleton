using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class MobileAppSingleton
    {
        private static MobileAppSingleton instance;

        public string SomeData { get; set; }

        private MobileAppSingleton()
        {
            SomeData = "Initial data";
        }

        public static MobileAppSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new MobileAppSingleton();
            }
            return instance;
        }
    }
}
