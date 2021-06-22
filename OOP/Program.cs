using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
       
            ICrediManager konutKrediManager = new KonutKrediManager();

            ICrediManager tasitKrediManager = new TasitKrediManager();

            ILoggerServise databaseloggerservise = new DatabaseLoggerService();
            ILoggerServise fileloggerServise = new FileLoggerService();


            BasuruManager basuru = new BasuruManager();
            basuru.BasuruYap(konutKrediManager, fileloggerServise );

            List<ICrediManager> krediler = new List<ICrediManager>() {ıhtiyacKrediManager,tasitKrediManager    };
           // basuru.KrediOnBilgilendirmeYap(krediler);
        }
    }
}
