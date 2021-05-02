using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        private long id;
        private string name;
        private float price;
        private bool active;
        private DateTime dateOfLaunch;
        private string category;
        private bool freeDelivery;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        public DateTime DateOfLaunch
        {
            get { return dateOfLaunch; }
            set { dateOfLaunch = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public bool FreeDelivery
        {
            get { return freeDelivery; }
            set { freeDelivery = value; }
        }
        public MenuItem()
        {

        }
        public MenuItem(long id, string name, float price, bool active, DateTime dateOfLaunch, string category, bool freeDelivery)
        {
            Id = id;
            Name = name;
            Price = price;
            Active = active;
            DateOfLaunch = dateOfLaunch;
            Category = category;
            FreeDelivery = freeDelivery;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
