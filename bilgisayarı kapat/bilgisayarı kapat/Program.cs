using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;//bu kütüphane eklenmelidir.

namespace bilgisayarı_kapat
{
    class Program
    {

        static void kapat()
        {
            Process.Start("shutdown", "/s /t 0");//bilgisayarı kapatır
        }

        static void Main(string[] args)
        {
            kapat();
        }
    }
}
