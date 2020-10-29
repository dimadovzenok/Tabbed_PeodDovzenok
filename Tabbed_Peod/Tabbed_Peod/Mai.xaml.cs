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
    public partial class Mai : ContentPage
    {
        public Mai()
        {
            Button btn1, btn2;
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "May 2021", FontSize = 30 },
                new Rectangle(250, 20, 200, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 12 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );

            absoluteLayout.Children.Add(
                new Label { Text = "The 1st: International Workers' Day", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The 9th: Victory Day", FontSize = 15 },
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
            DisplayAlert("International Workers' Day", "International Workers' Day, also known as Labour Day in some countries and often referred to as May Day, is a celebration of labourers and the working classes that is promoted by the international labour movement and occurs every year on May Day (1 May)." +
                " While it may belong to a tradition of spring festivals, the date was chosen in 1889 for political reasons by the Marxist International Socialist Congress, which met in Paris and established the Second International as a successor to the earlier International Workingmen's Association." +
                " They adopted a resolution for a" + "great international demonstration" + "in support of working-class demands for the eight-hour day." +
                " The date had been chosen by the American Federation of Labor to continue an earlier campaign for the eight-hour day in the United States, which had culminated in the Haymarket affair, which occurred in Chicago on 4 May 1886." +
                " May Day subsequently became an annual event." +
                " The 1904 Sixth Conference of the Second International, called on" + "all Social Democratic Party organisations and trade unions of all countries to demonstrate energetically on the First of May for the legal establishment of the eight-hour day, for the class demands of the proletariat, and for universal peace.", "OK");
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Victory Day", "Victory Day is a holiday that commemorates the surrender of Nazi Germany in 1945." +
                " It was first inaugurated in the 15 republics of the Soviet Union, following the signing of the German Instrument of Surrender late in the evening on 8 May 1945 (after midnight, thus on 9 May Moscow Time)." +
                " The Soviet government announced the victory early on 9 May after the signing ceremony in Berlin." +
                " Although the official inauguration occurred in 1945, the holiday became a non-labour day only in 1965, and only in certain Soviet republics.", "OK");
        }
    }
}