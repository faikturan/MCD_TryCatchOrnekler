using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_TryCatchOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a;
                Console.Write("Sayı gir: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Teşekkürler.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu!");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("HATA: " +ex.Message);
            }
            finally
            {
                Console.WriteLine("Burası Finally");
            }
            Console.ReadKey();
        }
    }
}
