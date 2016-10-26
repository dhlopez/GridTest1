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
            var startEvent = new TapGestureRecognizer();
            //List<Action> imgMethods = new List<Action>() { methodImg(List<Image>)};


            /*foreach (Image img in images)
            {
                imgTapEvent.Tapped += (sender, e) => methodImg(object sender, EventArgs args);
                img.GestureRecognizers.Add(imgTapEvent);
            }*/
            imgTapEvent1.Tapped += (sender, e) => methodImg(sender);
            imgTapEvent2.Tapped += (sender, e) => methodImg(sender);
            imgTapEvent3.Tapped += (sender, e) => methodImg(sender);
            imgTapEvent4.Tapped += (sender, e) => methodImg(sender);
            imgTapEvent5.Tapped += (sender, e) => methodImg(sender);
            imgTapEvent6.Tapped += (sender, e) => methodImg(sender);
            startEvent.Tapped += (sender, e) => methodImg(sender);

            img1.GestureRecognizers.Add(imgTapEvent1);
            img2.GestureRecognizers.Add(imgTapEvent2);
            img3.GestureRecognizers.Add(imgTapEvent3);
            img4.GestureRecognizers.Add(imgTapEvent4);
            img5.GestureRecognizers.Add(imgTapEvent5);
            img6.GestureRecognizers.Add(imgTapEvent6);
            start.GestureRecognizers.Add(startEvent);

            foreach (Image img in images)
            {
                /*
                if (img.StyleId != null && img.Opacity == 0)
                {
                    img.Opacity = 100;
                }
                */
                if (img.StyleId != null && img.Opacity == 1)
                {
                    img.Opacity = 0;
                }
            }
            //StartTimer(int);
            
        }

        void methodImg(object sender)
        {
            //Pattern(3);
            img2.Opacity = 1;
            StartTimer(6);
            img4.Opacity = 1;

            //string x = sender.StyleId;
            //if(img.StyleId.Equals("img1"))

            /*
            int imgName = Convert.ToInt16(img.Opacity);
            if (imgName > 0)
            {
                img.Opacity = 0;
            }
            if (imgName <= 0)
            {
                img.Opacity = 1;
            }
            */
        }
        public void StartTimer(int interval)
        {
            int number = 0;
            Device.StartTimer(TimeSpan.FromSeconds(interval), () => {
                number++;
                if (number <= interval)
                {
                    //this.time.Text = number.ToString();
                    this.time.Text = TimeSpan.FromSeconds(number).ToString();
                    img3.Opacity = 1;
                    return true; 
                }
                return false;

            });
        }

        public static List<string> pattern = new List<string>();

        void Pattern(int initial)
        {
            List<string> options = new List<string>() { "img1", "img2", "img3", "img4", "img5", "img6" };
            //List<string> pattern = new List<string>();
            //populate pattern list

            //while (true)
            if (pattern.Count == 0)
            {
                for (int l = 0; l < initial; l++)
                {
                    pattern.Add(options[GetNumber()]);
                }
            }
            else
            {
                pattern.Add(options[GetNumber()]);
            }
            
            foreach (string opt in pattern)
            {
                foreach(Image img in images)
                if (img.StyleId.Equals(opt))
                {
                    img.Opacity = 1;
                    StartTimer(5);
                    //img.Opacity = 0;
                }
            }
            if (i >= 3)
            {
                //start game
            }
        }
        public int GetNumber()
        {
            Random rnd = new Random();
            int optionNumber = rnd.Next(0, 5);
            return optionNumber;
        }
    }
}
