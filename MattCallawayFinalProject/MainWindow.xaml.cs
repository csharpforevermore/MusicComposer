using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Resources;
using MattCallawayFinalProject.Properties;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace MattCallawayFinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
                

            InitializeComponent();
            BitmapImage theBitmap = new BitmapImage();

            theBitmap.BeginInit();

            String basePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"assets\");
 
            String path = System.IO.Path.Combine(basePath, @"images\sheetmusic.png");
 
            theBitmap.UriSource = new Uri(path, UriKind.Absolute);

            theBitmap.EndInit();


            sheetImage.Source = theBitmap;

        }



        private void newTunerButtonClick(object sender, RoutedEventArgs e)
        {
            TunerWindow win = new TunerWindow();
            win.Show();
        }

        private void newBlankSheetButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
        }

        private void closeButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private Image draggedImage;
        private Point mousePosition;

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *png";
            dialog.InitialDirectory = @"C:\Users\Matthew\source\repos\MattCallawayFinalProject\MattCallawayFinalProject\bin\Debug\assets\images\notes";
            if ((bool)dialog.ShowDialog())
            {
                var bitmap = new BitmapImage(new Uri(dialog.FileName));
                var image = new Image { Source = bitmap };
                Canvas.SetLeft(image, 850);
                Canvas.SetTop(image, 550);
                canvas.Children.Add(image);
            }
        }
        private void CanvasMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var image = e.Source as Image;

            if (image != null && canvas.CaptureMouse())
            {
                mousePosition = e.GetPosition(canvas);
                draggedImage = image;
                Panel.SetZIndex(draggedImage, 1); 
            }
        }

        private void CanvasMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (draggedImage != null)
            {
                canvas.ReleaseMouseCapture();
                Panel.SetZIndex(draggedImage, 0);
                draggedImage = null;
            }
        }

        private void CanvasMouseMove(object sender, MouseEventArgs e)
        {
            if (draggedImage != null)
            {
                var position = e.GetPosition(canvas);
                var offset = position - mousePosition;
                mousePosition = position;
                Canvas.SetLeft(draggedImage, Canvas.GetLeft(draggedImage) + offset.X);
                Canvas.SetTop(draggedImage, Canvas.GetTop(draggedImage) + offset.Y);
            }
        }

    }
}
