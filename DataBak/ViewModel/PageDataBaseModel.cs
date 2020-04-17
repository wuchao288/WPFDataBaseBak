using DataBak.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBak.ViewModel
{
    public class PageDataBaseModel: ViewModelBase
    {
        private List<DataBaseInfo> _ListDataBaseInfo;

        public List<DataBaseInfo> ListDataBaseInfo
        {
            get => _ListDataBaseInfo;
            set => _ListDataBaseInfo = value;
        }

    }
    
}
