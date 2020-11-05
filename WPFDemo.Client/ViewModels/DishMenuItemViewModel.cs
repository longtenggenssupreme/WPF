using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDemo.Client.Models;

namespace WPFDemo.Client.ViewModels
{
    class DishMenuItemViewModel:NotificationObject
    {
        public Dish Dish { get; set; }

        private bool isselected;

        public bool isSelected
        {
            get { return isselected; }
            set
            {
                isselected = value;
                this.RaisePropertyChanged("isSelected");
            }
        }


    }
}
