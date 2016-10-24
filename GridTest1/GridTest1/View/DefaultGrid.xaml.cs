using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Diagnostics;
using System.Threading;
using Xamarin.Forms;

namespace GridTest1.View
{
    public partial class DefaultGrid : ContentPage, INotifyPropertyChanged
    {
        int i = 0;
        List<Image> images;

        public DefaultGrid()
        {
            InitializeComponent();
            images = new List<Image>() { img1, img2, img3, img4, img5, img6 };
            var imgTapEvent1 = new TapGestureRecognizer();
            var imgTapEvent2 = new TapGestureRecognizer();
            var imgTapEvent3 = new TapGestureRecognizer();
            var imgTapEvent4 = new TapGestureRecognizer();
            var imgTapEvent5 = new TapGestureRecognizer();
            var imgTapEvent6 = new TapGestureRecognizer();
            //List<Action> imgMethods = new List<Action>() { methodImg(List<Image>)};
            

            /*foreach (Image img in images)
            {
                imgTapEvent.Tapped += (sender, e) => methodImg(object sender, EventArgs args);
                img.GestureRecognizers.Add(imgTapEvent);
            }*/
            imgTapEvent1.Tapped += (sender, e) => methodImg(((Image)sender));
            imgTapEvent2.Tapped += (sender, e) => methodImg(((Image)sender));
            imgTapEvent3.Tapped += (sender, e) => methodImg(((Image)sender));
            imgTapEvent4.Tapped += (sender, e) => methodImg(((Image)sender));
            imgTapEvent5.Tapped += (sender, e) => methodImg(((Image)sender));
            imgTapEvent6.Tapped += (sender, e) => methodImg(((Image)sender));

            img1.GestureRecognizers.Add(imgTapEvent1);
            img2.GestureRecognizers.Add(imgTapEvent2);
            img3.GestureRecognizers.Add(imgTapEvent3);
            img4.GestureRecognizers.Add(imgTapEvent4);
            img5.GestureRecognizers.Add(imgTapEvent5);
            img6.GestureRecognizers.Add(imgTapEvent6);
            StartTimer();
        }
        void methodImg(Image img)
        {
            //string x = sender.StyleId;
            //if(img.StyleId.Equals("img1"))
            int imgName = Convert.ToInt16(img.Opacity);
            if (imgName > 0)
            {
                img.Opacity = 0;
            }
            if (imgName <= 0)
            {
                img.Opacity = 1;
            }
           
            /*
            foreach(Image img in images)
            {
                if (img.StyleId != null && img.Opacity == 0)
                {
                    img.Opacity = 100;
                }
                if (img.StyleId != null && img.Opacity == 100)
                {
                    img.Opacity = 0;
                }
            }
            */
        }
        /*
        void methodImg6()
        {
            if (img6.Opacity == 0)
                img6.Opacity = 100;
            else
                img6.Opacity = 0;
        }
        */
        public void StartTimer()
        {
            int number = 0;
            Device.StartTimer(TimeSpan.FromSeconds(1), () => {
                number++;
                if (number <= 60)
                {
                    //this.time.Text = number.ToString();
                    this.time.Text = TimeSpan.FromSeconds(number).ToString();
                    return true; 
                }
                return false;

            });
        }
    }
}
