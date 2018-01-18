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
           
        }
         

 
    }
}