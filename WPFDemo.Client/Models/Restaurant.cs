using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo.Client.Models
{
    /// <summary>
    /// 餐馆 信息
    /// </summary>
    public class Restaurant
    {
        private string  name;
        /// <summary>
        /// 餐馆 名称
        /// </summary>
        public string  Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        /// <summary>
        /// 餐馆 地址
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string phone;
        /// <summary>
        ///  餐馆 电话
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }



    }
}
