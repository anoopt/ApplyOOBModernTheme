using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyOOBModernTheme
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "user@tenant.onmicrosoft.com";
            string password = "password";
            string siteUrl = "https://tenant.sharepoint.com/sites/somesite";
            OOBTheme themeToApply = OOBTheme.Green;

            try
            {
                OOBModernThemeHelper.ApplyTheme(siteUrl, themeToApply, userName, password);
                Console.WriteLine($"Applied theme {themeToApply.ToString()} to {siteUrl}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error " + ex.Message);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
