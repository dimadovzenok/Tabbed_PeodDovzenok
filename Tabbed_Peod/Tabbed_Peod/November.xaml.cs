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
    public partial class November : ContentPage
    {
        public November()
        {
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "November 2021", FontSize = 30 },
                new Rectangle(230, 20, 240, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 10 days", FontSize = 15 },
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