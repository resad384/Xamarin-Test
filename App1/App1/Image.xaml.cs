using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Image : ContentPage
    {
        public Image()
        {
            InitializeComponent();


            imageframe.Source = new UriImageSource
            {
                Uri = new Uri("https://picsum.photos/200/300/?random"),
                CachingEnabled = false
            };


        }
    }
}