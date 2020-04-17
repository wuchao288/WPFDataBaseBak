using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBak.Model
{
    public class DataBaseInfo
    {
        //实例名
        public string Name { get; set; }
        //是否启用
        public bool IsEnable { get; set; }
        /// <summary>
        /// 连接方式
        /// </summary>
        public int ConType { get; set; }
        /// <summary>
        /// 服务器
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public string CreateX { get; set; }
    }
}
