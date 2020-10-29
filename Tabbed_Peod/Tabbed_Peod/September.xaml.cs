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
    public partial class September : ContentPage
    {
        public September()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "September 2021", FontSize = 30 },
                new Rectangle(220, 20, 240, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 8 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "The 1st: Knowledge Day", FontSize = 15 },
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
            DisplayAlert("Knowledge Day", "Knowledge Day, often simply called 1 September, is the day when the school year traditionally starts in Russia and many other former Soviet republics as well as other countries in the former Eastern Bloc (excluding Romania which falls on September 11 and the former East Germany varies in a coordinated fashion.) and Israel.", "OK");
        }
    }
}