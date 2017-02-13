using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVIP.Models
{
    public class MenuModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageName { get; set; }
        public string NavName { get; set; }
    }

    public class Data
    {
        #region DrawerList
        public static ObservableCollection<MenuModel> DrawerList = new ObservableCollection<MenuModel>
        {
            new MenuModel() { Title = "Home", SubTitle = "Where the Heart Is", ImageName = "home", NavName = "Navigation/MainPage"},
            new MenuModel() { Title = "Appointments", SubTitle = "See Available Times", ImageName = "calendar", NavName = "Navigation/Appointments"},
            //new MenuModel() { Title = "Make An Appointment", SubTitle = "Schedule A Cut", ImageName = "appointment", NavName = "Navigation/CreateTime"},
            new MenuModel() { Title = "About", SubTitle = "About V.I.P", ImageName = "about2", NavName = "Navigation/About"},
            new MenuModel() { Title = "Contact", SubTitle = "Contact the Owner", ImageName = "contact", NavName = "Navigation/ContactUs"},
        };
        #endregion
    }
}
