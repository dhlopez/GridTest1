using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Diagnostics;
using System.Threading;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace GridTest1.View
{
    public partial class Menu : ContentPage, INotifyPropertyChanged
    {
        public Menu()
        {
            InitializeComponent();
            var patterImg = new TapGestureRecognizer();
            patterImg.Tapped += (sender, e) => StartPattern(sender);
            pattern.GestureRecognizers.Add(patterImg);
        }
       private void StartPattern(object sender)
        {
            Navigation.PushAsync(new DefaultGrid());
        }
    }
}
