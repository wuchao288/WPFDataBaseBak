using DataBak.Model;
using DataBak.ViewModel;
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

namespace DataBak.View
{
    /// <summary>
    /// PageDataBase.xaml 的交互逻辑
    /// </summary>
    public partial class PageDataBase : Page
    {
        public PageDataBase()
        {
            InitializeComponent();
            var model = new PageDataBaseModel();
            model.ListDataBaseInfo = new List<DataBaseInfo>();

            model.ListDataBaseInfo.Add(new DataBaseInfo() {
                CreateX = DateTime.Now.ToString(),
                ConType = 1,
                IsEnable = false,
                Name = "test",
                Server = "."
            });
            model.ListDataBaseInfo.Add(new DataBaseInfo()
            {
                CreateX = DateTime.Now.ToString(),
                ConType = 1,
                IsEnable = true,
                Name = "test1",
                Server = "."
            });
            this.DataContext = model;
        }
    }
}
