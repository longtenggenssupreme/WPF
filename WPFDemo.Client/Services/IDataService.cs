using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDemo.Client.Models;

namespace WPFDemo.Client.Services
{
    /// <summary>
    /// 获取数据接口
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        List<Dish> GetDishList();
    }
}
