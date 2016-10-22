using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GridTest1.View
{
    public partial class DefaultGrid : ContentPage, INotifyPropertyChanged
    {
        int i = 0;
        public DefaultGrid()
        {
            InitializeComponent();
            var imgTapEvent = new TapGestureRecognizer();
            imgTapEvent.Tapped += (sender, e) => methodImg1();
            img1.GestureRecognizers.Add(imgTapEvent);
        }

        void methodImg1()
        {
            i++;
            this.d10.Text = i.ToString();
            //await DisplayAlert("Title", i+"", "OK");
        }
    }
}
