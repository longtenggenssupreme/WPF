using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFDemo.Client.Models;
using WPFDemo.Client.Services;

namespace WPFDemo.Client.ViewModels
{
    class MainWindowViewModel:NotificationObject
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }

        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                this.RaisePropertyChanged("Count");
            }
        }

        private Restaurant restaurant;

        public Restaurant Restaurant
        {
            get { return restaurant; }
            set
            {
                restaurant = value;
                this.RaisePropertyChanged("Restaurant");
            }
        }

        private List<DishMenuItemViewModel> dishMenu;

        public List<DishMenuItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set
            {
                dishMenu = value;
                this.RaisePropertyChanged("DishMenu");
            }
        }

        public MainWindowViewModel()
        {
            this.LoadRestaurant();
            this.LoadDishMenu();
            this.PlaceOrderCommand = new DelegateCommand(new Action(this.PlaceOrderCommandExecute));
            this.SelectMenuItemCommand = new DelegateCommand(new Action(this.SelectMenuItemExecute));
        }

        public void LoadRestaurant() {
            this.Restaurant = new Restaurant();
            this.Restaurant.Name = "至尊龙骑餐馆";
            this.Restaurant.Address = "南京市雨花区软件大道888号6栋8弄8巷8街";
            this.Restaurant.Phone = "7758521 or 1681688888";
        }

        public void LoadDishMenu() {
            XmlDataService ds = new XmlDataService();
            var dishes = ds.GetDishList();
            this.DishMenu = new List<DishMenuItemViewModel>();
            foreach (var item in dishes)
            {
                DishMenuItemViewModel menu = new DishMenuItemViewModel();
                menu.Dish = item;
                this.DishMenu.Add(menu);
            }
        }

        private void PlaceOrderCommandExecute() {
            var selectDishes = this.DishMenu.Where(i => i.isSelected == true).Select(n => n.Dish.Name).ToList();
            IOrderService ios = new MockOrderSercice();
            ios.PlaceOrder(selectDishes);
            MessageBox.Show("订餐成功");
        }

        private void SelectMenuItemExecute() {
            this.Count = this.DishMenu.Count(i => i.isSelected == true);
        }


    }
}
