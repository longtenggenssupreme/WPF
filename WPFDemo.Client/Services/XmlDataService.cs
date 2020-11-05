using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDemo.Client.Models;
using System.IO;
using System.Xml.Linq;

namespace WPFDemo.Client.Services
{
    class XmlDataService : IDataService
    {
        public List<Dish> GetDishList()
        {
            string localPath = Path.Combine(Environment.CurrentDirectory, @"Data\Data.xml");
            XDocument xdoc = XDocument.Load(localPath);
            var eleList = xdoc.Descendants(nameof(Dish));
            List<Dish> dishList = new List<Dish>();
            foreach (var item in eleList)
            {
                Dish temp = new Dish();
                temp.Name = item.Element(nameof(Dish.Name)).Value;
                temp.Category = item.Element(nameof(Dish.Category)).Value;
                temp.Comment = item.Element(nameof(Dish.Comment)).Value;
                temp.Score =double.Parse(item.Element(nameof(Dish.Score)).Value);
                dishList.Add(temp);
            }            
            return dishList;
        }
    }
}
