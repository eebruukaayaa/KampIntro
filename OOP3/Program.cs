// See https://aka.ms/new-console-template for more information

using OOP3;

IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasıtKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaeseLoggerService = new DatabaseLoggerService();
// 14.satırda kısa yolunu yaptım
ILoggerService fileLoggerService = new FileLoggerService();


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

List<IKrediManager> kredis = new List<IKrediManager>() {ıhtiyacKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBiligilendirmesiYap(kredis);

