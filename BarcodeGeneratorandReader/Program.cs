//3rd party barcode kütüphaneleri kullanarak barcode üreten bunu client'ın bilgisayarında bir lokasyona kaydeden. Daha sonra da barcode'u okuyabilen bir console uygulaması yazınız.

//Kullanılması gereken teknikler:

//Console Application
//Import 3rd Party Library
//Dosyaya Yazma
//Dosyadan Okuma

using BarcodeGeneratorandReader;
using BarcodeLib;
using System.Drawing;

Console.WriteLine("Bir barkod değeri giriniz: ");
Barcode barcode = Process.CreateAndSaveBarcode(Console.ReadLine());
Console.WriteLine(Process.ReadBarcode(barcode));