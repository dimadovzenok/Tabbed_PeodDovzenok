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
    public partial class Juuli : ContentPage
    {
        public Juuli()
        {
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "July 2021", FontSize = 30 },
                new Rectangle(250, 20, 200, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 9 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "There are no holidays in this month", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            Content = absoluteLayout;
        }
    }
}