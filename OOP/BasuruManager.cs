using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BasuruManager
    {
        //Method İnjection
        public void BasuruYap(ICrediManager crediManager,ILoggerServise loggerServise)
        {
            crediManager.Hesapla();
            loggerServise.Log();
        }
        

        public void KrediOnBilgilendirmeYap(List<ICrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }

}
