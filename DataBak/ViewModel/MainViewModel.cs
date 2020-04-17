using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Windows.Input;


namespace DataBak.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>

    public class Modules
    {
        private string name;

        public string Name
        {
            get => name;
            set =>
                name = value;

        }

        public string Code { get; set; }

        public string Url { get; set; }

    }
    public class MainViewModel : ViewModelBase
    {
        private string currentName;

        private List<Modules> listModules;

        public List<Modules> ListModules
        {
            get => listModules;
            set => listModules = value;

        }

        public MainViewModel() {
            NavCommand = new RelayCommand<string>(t=> OpenPage(t));
            ListModules = new List<Modules>() { };
            ListModules.Add(new Modules() {
                Name="首 页",
                Code= "\ue501",
                Url= "/View/PageHome.xaml"
            });
            ListModules.Add(new Modules()
            {
                Code = "\ue560",
                Name = "任 务",
                Url = "/View/PageTask.xaml"
            });
            ListModules.Add(new Modules()
            {
                Code = "\ue6f4",
                Name = "实 例",
                Url = "/View/PageDataBase.xaml"
            });
            ListModules.Add(new Modules()
            {
                Code = "\ue501",
                Name = "日 志",
                Url = "/View/PageLog.xaml"
            });
            ListModules.Add(new Modules()
            {
                Code = "\ue582",
                Name = "恢 复",
                Url = "/View/PageRecovery.xaml"
            });
            ListModules.Add(new Modules()
            {
                Code = "\ue6a0",
                Name = "工 具",
                Url = "/View/PageTool.xaml"
            });
            ListModules.Add(new Modules()
            {
                Code = "\ue6b3",
                Name = "设 置",
                Url = "/View/PageSetting.xaml"
            });
        }

        private object cPage;


        public GalaSoft.MvvmLight.Command.RelayCommand<string> NavCommand { get; set; }


        public  void OpenPage(string pagename)
        {
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Send(pagename, "ShowPage");
        }

      

        public object CPage {
            get => cPage;
            set
            {
                cPage = value;
                RaisePropertyChanged();
            }
        }

        public string CurrentName {
            get => currentName;
            set
            {
                currentName = value;
                RaisePropertyChanged();
            }
        }
    }


   
}