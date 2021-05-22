using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TransitioningContentControlTest001.UserControls
{
    /// <summary>
    /// Interaction logic for Content1UserControl.xaml
    /// </summary>
    public partial class Content1UserControl : UserControl
    {
        public Content1UserControl()
        {
            System.Diagnostics.Debug.WriteLine("Content1UserControl constructor.");
            InitializeComponent();
        }
    }
}
