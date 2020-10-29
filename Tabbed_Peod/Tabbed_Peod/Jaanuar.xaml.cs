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
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
        {
            Button btn1, btn2;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "January 2021", FontSize = 30 },
                new Rectangle(240, 20, 200, 60)
            );
            
            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 16 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The 1st: New Year", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The 7th: Nativity of Jesus", FontSize = 15 },
                new Rectangle(380, 200, 280, 60)
            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "More", FontSize = 10, BackgroundColor = Color.FromHex("#FF3300") },
                new Rectangle(315, 143, 60, 35)
            );
            absoluteLayout.Children.Add(
                btn2 = new Button { Text = "More", FontSize = 10, BackgroundColor = Color.FromHex("#FF3300") },
                new Rectangle(315, 193, 60, 35)
            );
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("New Year", "New Year is the time or day at which a new calendar year begins and the calendar's year count increments by one." +
                "\nMany cultures celebrate the event in some manner and the 1st day of January is often marked as a national holiday.", "OK");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Nativity of Jesus", "The nativity of Jesus, nativity of Christ, birth of Christ or birth of Jesus is described in the Biblical gospels of Luke and Matthew." +
                " The two accounts agree that Jesus was born in Bethlehem in Judea, his mother Mary was betrothed to a man named Joseph, who was descended from King David and was not his biological father, and that his birth was caused by divine intervention.", "OK");
        }
    }
}