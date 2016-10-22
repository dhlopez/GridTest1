using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GridTest1.View
{
    public partial class DefaultGrid : ContentPage
    {
        public DefaultGrid()
        {
            InitializeComponent();
            var imgTapEvent = new TapGestureRecognizer();
            imgTapEvent.Tapped += (sender, e) => methodImg1();
            img1.GestureRecognizers.Add(imgTapEvent);
        }

        async void methodImg1()
        {
            await DisplayAlert("Title","Method methodImg1 was clicked","OK");
        }
    }
}
