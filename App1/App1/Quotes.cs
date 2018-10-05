using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{     
    //salam  commit1jjjj hiiuuiibui
    class Quote
    {   
        public string Author { get; set; }
        public string Text { get; set; }

        static public  List<Quote> GetQuotes()
        {
            var quotes = new List<Quote>();
            quotes.Add(new Quote{ Author = "Insanlar", Text = "Salam Ne varx ne yox" } );
            quotes.Add(new Quote { Author = "Heyvanlar", Text = "Myau MYau" });
            quotes.Add(new Quote { Author = "Robotlar", Text = "020651650230320203" });

            return quotes;
        }
    }
}
