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
    public partial class FadeTest : ContentPage, INotifyPropertyChanged
    {
        int userAnswer;
        List<Image> images;
        List<string> options;

        public FadeTest()
        {
            restartEvent();
        }

        public void  methodImg(object sender)
        {
            Image imageTapped = ((Image)sender);
            imageTapped.FadeTo(0, 800);
        }
        public void StartTimer(int interval)
        {
            
        }

        public static List<string> pattern = new List<string>();

        async void Pattern(int initial)
        {
            //list of all the options available to create a pattern
            
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
            if (initial == 1)
            {
                pattern.Add(options[GetNumber()]);
            }
            /*
            else
            {
                pattern.Add(options[GetNumber()]);
            }
            */
            
            foreach (string opt in pattern)
            {
                this.GridImg.IsEnabled = false;
                foreach (Image img in images)
                {
                    if (img.StyleId.Equals(opt))
                    {
                        img.Opacity = 1;
                        await Task.Delay(500);
                        img.Opacity = 0;
                        await Task.Delay(500);
                    }
                }
                this.GridImg.IsEnabled = true;
            }
            StartTimer(60);
        }
        Random rnd = new Random();
        public int GetNumber()
        {
            int optionNumber = rnd.Next(0, 5);
            return optionNumber;
        }
        public void hideAllImg()
        {
            foreach (Image img in images)
            {
                img.Opacity = 0;
            }
        }
        public void restartEvent()
        {
            userAnswer = 0;
            InitializeComponent();
            images = new List<Image>() { img1, img2};
            options = new List<string>() { "img1", "img2" };
            var imgTapEvent1 = new TapGestureRecognizer();
            var imgTapEvent2 = new TapGestureRecognizer();
            //List<Action> imgMethods = new List<Action>() { methodImg(List<Image>)};


            /*foreach (Image img in images)
            {
                imgTapEvent.Tapped += (sender, e) => methodImg(object sender, EventArgs args);
                img.GestureRecognizers.Add(imgTapEvent);
            }*/
            imgTapEvent1.Tapped += (sender, e) => methodImg(sender);
            imgTapEvent2.Tapped += (sender, e) => methodImg(sender);

            img1.GestureRecognizers.Add(imgTapEvent1);
            img2.GestureRecognizers.Add(imgTapEvent2);
            
            foreach (Image img in images)
            {
                /*
                if (img.StyleId != null && img.Opacity == 0)
                {
                    img.Opacity = 100;
                }
                */
                /*
                if (img.StyleId != null && img.Opacity == 1)
                {
                    img.Opacity = 0;
                }
                */
            }
            //StartTimer(int);
            //Pattern(3);
        }
        public void quitEvent(object sender)
        {

        }
    }
}
