using Iteration4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Iteration4
{
    public class Bag : Item, IHaveInventory
    {
        private Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (!this.AreYou(id))
            {
                if (this.Inventory.Fetch(id) != null)
                {
                    return this.Inventory.Fetch(id);
                }
            }
            else
            {
                return this;
            }
            return null;
        }

        public string FullDescription
        {
            get
            {
                return "In the " + Name + " you can see:\n" + Inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}
