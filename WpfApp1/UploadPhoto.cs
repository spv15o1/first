﻿using Microsoft.Win32;
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
<<<<<<< HEAD
<<<<<<< HEAD
            }
<<<<<<< HEAD
<<<<<<< HEAD
           // MessageBox.Show("Изображения добавлены");
=======
>>>>>>> 4c7bf536adc88847e59248a7c222cf0a1850a16e
=======
            MessageBox.Show("Изображения добавлены");
>>>>>>> parent of 9b2433b... Translation
=======
            } 
>>>>>>> parent of 0bcbd98... Add message box
=======
            } 
>>>>>>> parent of 0bcbd98... Add message box

           
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
           // MessageBox.Show("Изображения добавлены");
=======
>>>>>>> 4c7bf536adc88847e59248a7c222cf0a1850a16e
=======
            MessageBox.Show("Изображения добавлены");
>>>>>>> parent of 9b2433b... Translation
=======

>>>>>>> parent of 0bcbd98... Add message box
=======

>>>>>>> parent of 0bcbd98... Add message box
        }


    }
}