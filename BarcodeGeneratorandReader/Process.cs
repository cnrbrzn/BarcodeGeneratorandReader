using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGeneratorandReader
{
    public class Process
    {
        static TYPE type = TYPE.PHARMACODE;
        public static Barcode CreateAndSaveBarcode(string data)
        {
            Barcode barcode = new Barcode(data, type);
            barcode.Encode(type, data);
            barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barkod oluşturuldu ve kaydedildi, saklanan data -> {0}", data);
            return barcode;
        }
        public static string ReadBarcode(Barcode barcode)
        {
            return "Barkod değeri = " + barcode.RawData;
        }
    }
}
