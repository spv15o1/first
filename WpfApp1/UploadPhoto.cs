using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

using System.Drawing;

using System.Windows.Media.Imaging;

namespace WpfApp1
{
    static public class UploadPhoto
    {

       static public List<BitmapImage> images = new List<BitmapImage>();

        static public void GetUploadPhoto(string [] files)
        {
       
            for(int i=0; i<files.Length; i++)
            {
                 images.Add(new BitmapImage(new Uri(files[i])));
            }
            if (images.Count != 0)
            {
                MessageBox.Show("Изображения добавлены");
            }

        }
        static public void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd.ShowDialog();
            foreach (var v in ofd.FileNames)
            {
                images.Add(new BitmapImage(new Uri(v)));

            }
            if (images.Count!=0)
            {
                MessageBox.Show("Изображения добавлены");
            }
        }


    }
}