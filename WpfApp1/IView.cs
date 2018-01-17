using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace WpfApp1
{
    public interface IView
    {
        /// <remarks></remarks>
        bool Init(TabItem[] tab);
    }
}