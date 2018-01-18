using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
<<<<<<< HEAD
using System.Drawing;
=======
>>>>>>> a285b6823d67b5327e318b33e655448440a47b7e
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    static public class UploadPhoto
    {
<<<<<<< HEAD

       static public List<BitmapImage> images = new List<BitmapImage>();

        static public void GetUploadPhoto(string [] files)
        {
       
            for(int i=0; i<files.Length; i++)
            {
                 images.Add(new BitmapImage(new Uri(files[i])));
            } 
=======
        public static List<BitmapImage> images = new List<BitmapImage>();

>>>>>>> a285b6823d67b5327e318b33e655448440a47b7e
           
        }
         

 
    }
}