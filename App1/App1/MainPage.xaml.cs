using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace App1
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private List<Quote> _quotes;
        public MainPage()
        {
            InitializeComponent();
            _quotes = Quote.GetQuotes();
            quotetext.Text = _quotes.First().Text;
           
        }

        int index = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
           if (index == _quotes.Count - 1) { index = -1; }
           index++;
           quotetext.Text = _quotes[index].Text;
        }
    }
}
