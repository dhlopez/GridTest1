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
            var imgTapEvent1 = new TapGestureRecognizer();
            var imgTapEvent2 = new TapGestureRecognizer();
            var imgTapEvent3 = new TapGestureRecognizer();
            var imgTapEvent4 = new TapGestureRecognizer();
            var imgTapEvent5 = new TapGestureRecognizer();
            var imgTapEvent6 = new TapGestureRecognizer();
            //List<Action> imgMethods = new List<Action>() { methodImg(List<Image>)};
            List<Image> images = new List<Image>() { img1, img2, img3, img4, img5, img6};

            /*foreach (Image img in images)
            {
                imgTapEvent.Tapped += (sender, e) => methodImg(object sender, EventArgs args);
                img.GestureRecognizers.Add(imgTapEvent);
            }*/
            imgTapEvent1.Tapped += (sender, e) => methodImg1();
            imgTapEvent2.Tapped += (sender, e) => methodImg2();
            imgTapEvent3.Tapped += (sender, e) => methodImg3();
            imgTapEvent4.Tapped += (sender, e) => methodImg4();
            imgTapEvent5.Tapped += (sender, e) => methodImg5();
            imgTapEvent6.Tapped += (sender, e) => methodImg6();

            img1.GestureRecognizers.Add(imgTapEvent1);
            img2.GestureRecognizers.Add(imgTapEvent2);
            img3.GestureRecognizers.Add(imgTapEvent3);
            img4.GestureRecognizers.Add(imgTapEvent4);
            img5.GestureRecognizers.Add(imgTapEvent5);
            img6.GestureRecognizers.Add(imgTapEvent6);
        }

        void methodImg()
        {
            i++;
            Opacity = 0;
            //this.d10.Text = i.ToString();
            //await DisplayAlert("Title", i+"", "OK");
        }
        void methodImg1()
        {
            i++;
            if (img1.Opacity == 0)
                img1.Opacity = 100;
            else
                img1.Opacity = 0;
            //this.d10.Text = i.ToString();
            //await DisplayAlert("Title", i+"", "OK");
        }
        void methodImg2()
        {
            if (img2.Opacity == 0)
                img2.Opacity = 100;
            else
                img2.Opacity = 0;
            //this.d10.Text = i.ToString();
            //await DisplayAlert("Title", i+"", "OK");
        }
        void methodImg3()
        {
            if (img3.Opacity == 0)
                img3.Opacity = 100;
            else
                img3.Opacity = 0;
            //this.d10.Text = i.ToString();
            //await DisplayAlert("Title", i+"", "OK");
        }
        void methodImg4()
        {
            i++;
            if (img4.Opacity == 0)
                img4.Opacity = 100;
            else
                img4.Opacity = 0;
            //this.d10.Text = i.ToString();
            //await DisplayAlert("Title", i+"", "OK");
        }
        void methodImg5()
        {
            if (img5.Opacity == 0)
                img5.Opacity = 100;
            else
                img5.Opacity = 0;
            //this.d10.Text = i.ToString();
            //await DisplayAlert("Title", i+"", "OK");
        }
        void methodImg6()
        {
            if (img6.Opacity == 0)
                img6.Opacity = 100;
            else
                img6.Opacity = 0;
            //this.d10.Text = i.ToString();
            //await DisplayAlert("Title", i+"", "OK");
        }
    }
}
