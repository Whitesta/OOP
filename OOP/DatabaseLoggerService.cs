using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class DatabaseLoggerService : ILoggerServise
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
