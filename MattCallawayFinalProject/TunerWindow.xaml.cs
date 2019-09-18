using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MattCallawayFinalProject
{
    /// <summary>
    /// Interaction logic for TunerWindow.xaml
    /// </summary>
    public partial class TunerWindow : Window
    {
        public TunerWindow()
        {
            InitializeComponent();
            BitmapImage theBitmap = new BitmapImage();

            theBitmap.BeginInit();

            String basePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"assets\");

            String path = System.IO.Path.Combine(basePath, @"images\wood.jpg");

            theBitmap.UriSource = new Uri(path, UriKind.Absolute);

            theBitmap.EndInit();

            //sheetImage = new Image();

                woodImage.Source = theBitmap;
        }

        private void lowEButtonClick(object sender, RoutedEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            Tuner tune = new Tuner();
            sound = tune.getLowE();
            sound.Play();
        }
        private void aButtonClick(object sender, RoutedEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            Tuner tune = new Tuner();
            sound = tune.getAString();
            sound.Play();
        }
        private void dButtonClick(object sender, RoutedEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            Tuner tune = new Tuner();
            sound = tune.getDString();
            sound.Play();
        }
        private void gButtonClick(object sender, RoutedEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            Tuner tune = new Tuner();
            sound = tune.getGString();
            sound.Play();
        }
        private void bButtonClick(object sender, RoutedEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            Tuner tune = new Tuner();
            sound = tune.getBString();
            sound.Play();
        }
        private void highEButtonClick(object sender, RoutedEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            Tuner tune = new Tuner();
            sound = tune.getHighE();
            sound.Play();
        }

        private void closeTuner(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
