using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xam_Test2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        int numberX = 0;
        int numberY = 0;
        int numberZ = 0;

        

        private void Plus(object sender, EventArgs e)
        {
            numberX = int.Parse(Xnum.Text);
            numberY = int.Parse(Ynum.Text);
            numberZ = numberX + numberY;

            Znum.Text = Convert.ToString(numberZ);
        }

        private void Minus(object sender, EventArgs e)
        {
            numberX = int.Parse(Xnum.Text);
            numberY = int.Parse(Ynum.Text);
            numberZ = numberX - numberY;
            Znum.Text = Convert.ToString(numberZ);
        }

        private void Place(object sender, EventArgs e)
        {
            Xnum.Text = Znum.Text;
        }
    }
}
