using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               // int a = int.Parse(null);
               // int b = int.Parse("test");
                int c = int.Parse("-20000000000");
            }
            catch(ArgumentNullException ex)
            {
                System.Console.WriteLine("Boş değer girdiniz");
                System.Console.WriteLine(ex);
                
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Veri tipi uygun değil");
                System.Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("Çok küçük bir değer girdiniz");
                System.Console.WriteLine(ex);
            }
            finally
            {
                System.Console.WriteLine("İşlem başarıyla tamamlandı");
            }
        }
    }
}
