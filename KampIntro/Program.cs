// See https://aka.ms/new-console-template for more information
string kategoriEtiketi = "kategori";
int ogrenciSayısı = 32000;
double faizOranı = 1.45;
bool sistemeGirişYapmişMi = false;
double dolarDun = 7.35;
double dolarBugun = 7.35;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if(dolarBugun>dolarDun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("Değişmedi butonu");
}




if (sistemeGirişYapmişMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}
Console.WriteLine(kategoriEtiketi);
