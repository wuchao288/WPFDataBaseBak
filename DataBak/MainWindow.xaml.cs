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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBak
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //调用页面的方法，业务代码通知页面代码ShowName为前台注册方法时的代名称
            //注册这个Show方法可以调用,ShowName为这个注册的名称，可以业务代里使用
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register<string>(this, "ShowPage", ShowPage);
        }
        public void ShowPage(string url)
        {
            MainPage.Source = new Uri(url, UriKind.Relative);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        Rect rcnormal;//
        private void Button_Click_Max(object sender, RoutedEventArgs e)
        {
            Rect rc = SystemParameters.WorkArea;//获取工作区大小
            rcnormal = new Rect(this.Left, this.Top, this.Width, this.Height);//保存下当前位置与大小
            if (this.Width>980)
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

                this.Width = rc.Width+28;
                this.Height = rc.Height+ 28;
            }
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void Button_Click_Min(object sender, RoutedEventArgs e)
        {
            if (this.WindowState==WindowState.Normal)
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
