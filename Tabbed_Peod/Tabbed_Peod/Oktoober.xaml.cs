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
    public partial class Oktoober : ContentPage
    {
        public Oktoober()
        {
            Button btn1;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "October 2021", FontSize = 30 },
                new Rectangle(240, 20, 200, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 10 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "The 3rd: World Teacher's Day", FontSize = 15 },
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
            DisplayAlert("World Teacher's Day", "World Teachers' Day, also known as International Teachers Day, is an international day held annually on 5 October." +
                " Established in 1994, it commemorates the signing of the 1966 UNESCO/ILO Recommendation concerning the Status of Teachers, which is a standard-setting instrument that addresses the status and situations of teachers around the world." +
                " This recommendation outlines standards relating to education personnel policy, recruitment, and initial training as well as the continuing education of teachers, their employment, and working conditions." +
                " World Teachers' Day aims to focus on" + "appreciating, assessing and improving the educators of the world" + "and to provide an opportunity to consider issues related to teachers and teaching.", "OK");
        }
    }
}