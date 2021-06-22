using System;

namespace OOP
{
    class FileLoggerService : ILoggerServise
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
