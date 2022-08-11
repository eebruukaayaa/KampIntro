using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBiligilendirmesiYap(List<IKrediManager> kredis)
        {
            foreach (var kredi in kredis)
            {
                kredi.Hesapla();
            }
        }
    }
}
