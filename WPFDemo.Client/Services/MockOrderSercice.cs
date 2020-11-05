using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFDemo.Client.Services
{
    class MockOrderSercice : IOrderService
    {
        public void PlaceOrder(List<string> dishes)
        {
            string localpath = Path.Combine(Environment.CurrentDirectory, @"order.txt");
            File.WriteAllLines(localpath, dishes.ToArray());
        }
    }
}
