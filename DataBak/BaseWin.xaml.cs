using System;
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
        Rect rcnormal;//
        private void Button_Click_Max(object sender, RoutedEventArgs e)
        {
            Rect rc = SystemParameters.WorkArea;//获取工作区大小
            rcnormal = new Rect(this.Left, this.Top, this.Width, this.Height);//保存下当前位置与大小
            if (this.Width > 980)
            {

                this.Width = 980;
                this.Height = 600;
                this.Left = (rc.Width / 2) - (980 / 2);
                this.Top = (rc.Height / 2) - (600 / 2);
            }
            else
            {


                this.Left = -14;//设置位置
                this.Top = -14;

                this.Width = rc.Width + 28;
                this.Height = rc.Height + 28;
            }
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void Button_Click_Min(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }
    }
}
