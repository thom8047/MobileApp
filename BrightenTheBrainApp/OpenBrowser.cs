using System;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Text;

namespace BrightenTheBrainApp
{
    class OpenBrowser
    {
        public async void Open(Uri url)
        {
            try
            {
                await Browser.OpenAsync(url);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
