using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }


        private void ImagePanel_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                UploadPhoto.GetUploadPhoto(files);
                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                //HandleFileOpen(files[0]);
                
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            UploadPhoto.OpenFile();

            this.FillImageList();
        }
<<<<<<< HEAD

        private void FillImageList()
        {
            foreach (var image in UploadPhoto.images)
            {
                string fileName = System.IO.Path.GetFileName(image.ToString());

                this.ImageList.Items.Add(fileName);
                this.ImageList.Tag = System.IO.Path.GetDirectoryName(image.ToString());
            }
        }

        private void ImageList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string image = this.ImageList.SelectedItem as string;

            string path = this.ImageList.Tag + @"\" + image;
            Process.Start(path);
        }

        private void MenuItem_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

=======
>>>>>>> parent of 9b2433b... Translation
    }
}
