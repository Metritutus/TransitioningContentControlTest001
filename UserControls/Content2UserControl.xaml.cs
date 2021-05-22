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
    /// Interaction logic for Content2UserControl.xaml
    /// </summary>
    public partial class Content2UserControl : UserControl
    {
        public Content2UserControl()
        {
            System.Diagnostics.Debug.WriteLine("Content2UserControl constructor.");
            InitializeComponent();
        }
    }
}
