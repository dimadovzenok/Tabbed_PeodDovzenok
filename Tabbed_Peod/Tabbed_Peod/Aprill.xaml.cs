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
    public partial class Aprill : ContentPage
    {
        public Aprill()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "April 2021", FontSize = 30 },
                new Rectangle(250, 20, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 8 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The 1st: April Fool's Day", FontSize = 15 },
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
            DisplayAlert("April Fool's Day", "April Fools' Day or April Fool's Day is an annual custom on April 1 consisting of practical jokes and hoaxes." +
                " Jokesters often expose their actions by shouting" + "April Fools!" + "at the recipient." +
                " Mass media can be involved in these pranks, which may be revealed as such the following day." +
                " The day is not a public holiday in any country except Odessa in Ukraine, where the first of April is an official city holiday." +
                " The custom of setting aside a day for playing harmless pranks upon one's neighbor has been relatively common in the world historically.", "OK");
        }
    }
}