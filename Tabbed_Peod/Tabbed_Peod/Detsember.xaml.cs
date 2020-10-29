using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed_Peod
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detsember : ContentPage
    {
        public Detsember()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "December 2021", FontSize = 30 },
                new Rectangle(230, 20, 240, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 9 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The 25th: Christmas", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "More", FontSize = 10, BackgroundColor = Color.FromHex("#FF3300") },
                new Rectangle(315, 143, 60, 35)
            );
            btn1.Clicked += Btn1_Clicked;
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Christmas", "Christmas (or Feast of the Nativity) is an annual festival commemorating the birth of Jesus Christ, observed primarily on December 25 as a religious and cultural celebration among billions of people around the world." +
                " A feast central to the Christian liturgical year, it is preceded by the season of Advent or the Nativity Fast and initiates the season of Christmastide, which historically in the West lasts twelve days and culminates on Twelfth Night; in some traditions, Christmastide includes an octave." +
                " Christmas Day is a public holiday in many of the world's nations, is celebrated religiously by a majority of Christians, as well as culturally by many non-Christians, and forms an integral part of the holiday season centered around it.", "OK");
        }
    }
}