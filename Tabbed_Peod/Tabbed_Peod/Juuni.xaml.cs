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
    public partial class Juuni : ContentPage
    {
        public Juuni()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "June 2021", FontSize = 30 },
                new Rectangle(250, 20, 200, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 9 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The 1st: Children Protection Day", FontSize = 15 },
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
            DisplayAlert("Children Protection Day", "Child protection is the safeguarding of children from violence, exploitation, abuse, and neglect." +
                " Article 19 of the UN Convention on the Rights of the Child provides for the protection of children in and out of the home." +
                " One of the ways to ensure this is by giving them quality education, the fourth of the United Nations Sustainable Development Goals, in addition to other child protection systems.", "OK");
        }
    }
}