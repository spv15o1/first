using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    static public class UploadPhoto
    {
        public static List<BitmapImage> images = new List<BitmapImage>();

        static public void OpenFile()
        {
   
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd.ShowDialog();
            foreach(var v in ofd.FileNames)
            {
                images.Add(new BitmapImage(new Uri(v)));
               
            }
           
        }
    }
}