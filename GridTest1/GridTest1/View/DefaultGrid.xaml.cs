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
    public partial class DefaultGrid : ContentPage, INotifyPropertyChanged
    {
        int userAnswer;
        List<Image> images;
        List<string> options;

        public DefaultGrid()
        {
            restartEvent();
        }

        public async Task methodImg(object sender)
        {
            Image imageTapped = ((Image)sender);
            if (imageTapped.StyleId != pattern[userAnswer])
            {
                start.Text = "you lose";
            }
            else
            {
                imageTapped.Opacity = 1;
                Task.Delay(10);
                imageTapped.Opacity = 0;
                userAnswer++;
            }
            if (pattern.Count <= userAnswer)
            {
                start.Text = "you win";
                //this.GridImg.IsEnabled = false;
                //this.contentView.IsVisible = true;
                userAnswer = 0;
                hideAllImg();
                await Task.Delay(2000);
                //this.Win.IsVisible = false;
                
                Pattern(1);
                
            }
            //Pattern(3);
            //StartTimer(6);
            //await Task.Delay(2500);
            
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
                    return true; 
                }
                return false;
            });
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
                start.Text += opt;
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
            images = new List<Image>() { img1, img2, img3, img4, img5, img6 };
            options = new List<string>() { "img1", "img2", "img3", "img4", "img5", "img6" };
            var imgTapEvent1 = new TapGestureRecognizer();
            var imgTapEvent2 = new TapGestureRecognizer();
            var imgTapEvent3 = new TapGestureRecognizer();
            var imgTapEvent4 = new TapGestureRecognizer();
            var imgTapEvent5 = new TapGestureRecognizer();
            var imgTapEvent6 = new TapGestureRecognizer();
            var startEvent = new TapGestureRecognizer();

            var restart = new TapGestureRecognizer();
            var quit = new TapGestureRecognizer();
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

            restart.Tapped += (sender, e) => restartEvent(sender);
            quit.Tapped += (sender, e) => quitEvent(sender);

            img1.GestureRecognizers.Add(imgTapEvent1);
            img2.GestureRecognizers.Add(imgTapEvent2);
            img3.GestureRecognizers.Add(imgTapEvent3);
            img4.GestureRecognizers.Add(imgTapEvent4);
            img5.GestureRecognizers.Add(imgTapEvent5);
            img6.GestureRecognizers.Add(imgTapEvent6);
            start.GestureRecognizers.Add(startEvent);

            Restart.GestureRecognizers.Add(restart);
            Restart.GestureRecognizers.Add(quit);

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
            Pattern(3);
        }
        public void quitEvent(object sender)
        {

        }
    }
}
