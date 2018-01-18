using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace WpfApp1
{
    public class List : IView
    {
        private List<Image> Images
        {
            get;
            set;
        }

        public bool Init(TabItem[] tab)
        {
            throw new NotImplementedException();
        }
    }

    public class Slider : IView
    {
        private List<Image> Images
        {
            get;
            set;
        }

        public bool Init(TabItem[] tab)
        {
            throw new NotImplementedException();
        }
    }

    public class Canvas : IView
    {
        private List<Image> Images
        {
            get;
            set;
           
        }

        public bool Init(TabItem[] tab)
        {
            throw new NotImplementedException();
        }
    }

    public class Tile : IView
    {
        private List<Image> Images
        {
            get;
            set;
        }

        public bool Init(TabItem[] tab)
        {
            throw new NotImplementedException();
        }
    }
}