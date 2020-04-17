﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace DataBak
{
    /// <summary>
    /// BaseWin.xaml 的交互逻辑
    /// </summary>
    public partial class BaseWin : Window
    {
        public BaseWin()
        {
            InitializeComponent();
            this.Style = (Style)App.Current.Resources["BaseWindowStyle"];
        }
    }
}
