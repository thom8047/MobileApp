using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrain.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bemer : ContentPage
    {
        private Display Data()
        {
            var displayObject = new Display();
            return displayObject;
        }
        public Bemer()
        {
            InitializeComponent();
            var data = this.Data();
            var stack = BemerStack;
            var scroll = new ScrollView();
            var bemer_forms = new List<String> { "L.I.S.T.", "C.O.F.F.E.E. " };

            data.GetMainPage(scroll, stack, bemer_forms);
        }
    }
}